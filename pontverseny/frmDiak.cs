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
    public partial class frmDiak : Form
    {
        string connectionString;
        SqlConnection connection;

        public frmDiak(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void frmDiak_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataReader command = new SqlCommand("SELECT iskola_neve FROM iskola GROUP BY iskola_neve;", connection).ExecuteReader();
            while (command.Read())
            {
                iskola.Items.Add(command[0]);
            }
            connection.Close();

            if (frmDiakLista.Next == true)
            {
                azon.Text = frmDiakLista.SelectedRow.Cells[0].Value.ToString();
                nev.Text = frmDiakLista.SelectedRow.Cells[1].Value.ToString();
                evfolyam.Text = frmDiakLista.SelectedRow.Cells[2].Value.ToString();
                iskola.Text = frmDiakLista.SelectedRow.Cells[3].Value.ToString();
                frmDiakLista.Next = false;
            }
        }

        private void kereses_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDiakLista diaklistafrm = new frmDiakLista(connectionString);
            diaklistafrm.Show();
        }

        private void blankfrm_Click(object sender, EventArgs e)
        {
            azon.Text = String.Empty;
            nev.Text = String.Empty;
            evfolyam.Value = 0;
            iskola.ResetText();

            torles.Enabled = false;
        }

        private void mentes_Click(object sender, EventArgs e)
        {
            if (nev.Text == "" && iskola.Text == "" )
            {
                string message = "Kérem töltse ki a név és az iskola mezőt!";
                string title = "Hiba";
                MessageBox.Show(message, title);
            }
            else
            {
                if (nev.Text == "")
                {
                    string message = "Kérem töltse ki a név mezőt!";
                    string title = "Hiba";
                    MessageBox.Show(message, title);
                }

                if (iskola.Text == "")
                {
                    string message = "Kérem töltse ki az iskola mezőt!";
                    string title = "Hiba";
                    MessageBox.Show(message, title);
                }
            }
        }

        private void azon_TextChanged(object sender, EventArgs e)
        {
            if (azon.Text != "")
            {
                torles.Enabled = true;
            }
        }

        private void torles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan törli az adatokat?", "Törlés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.Open();
                SqlDataReader delete = new SqlCommand("DELETE FROM diak, eredmeny " +
                    "WHERE diak.diakID=eredmeny.diakID AND diak.diakID="+ azon.Text + ";", connection).ExecuteReader();
                connection.Close();

                azon.Text = String.Empty;
                nev.Text = String.Empty;
                evfolyam.Value = 0;
                iskola.ResetText();
            }
        }
    }
}
