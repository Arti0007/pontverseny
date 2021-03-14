using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pontverseny
{
    public partial class frmMain : Form
    {
        static string connectionString = @"Server = (localdb)\MSSQLLocalDB;" +
            @"AttachDbFileName=|DataDirectory|Resources\pontverseny.mdf;";

        static SqlConnection connection = new SqlConnection(connectionString);

        public frmMain()
        {
            InitializeComponent();
        }

        private void szerkesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiak diakfrm = new frmDiak(connectionString);
            diakfrm.Show();
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiakLista diaklistafrm = new frmDiakLista(connectionString);
            diaklistafrm.Show();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataReader command = new SqlCommand("SELECT diak.nev, SUM(eredmeny.pont) AS ossz, diak.evfolyam, iskola.iskola_neve FROM diak, eredmeny, iskola WHERE iskola.iskID=diak.iskID AND diak.diakID=eredmeny.diakID GROUP BY nev, evfolyam, iskola_neve ORDER BY ossz DESC;", connection).ExecuteReader();
            int sor = 0;
            while (command.Read())
            {
               sor = sor + 1;
               tabla1.Rows.Add(sor, command[0], command[1], command[2], command[3]);
            }
            connection.Close();
        }
    }
}
