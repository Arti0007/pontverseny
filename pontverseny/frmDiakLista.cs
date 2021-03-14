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
    public partial class frmDiakLista : Form
    {
        string connectionString;
        SqlConnection connection;
        public static DataGridViewRow SelectedRow { get; set; }

        private static bool next = false;
        public static Boolean Next
        {
            get { return next; }
            set { next = frmDiakLista.Next; }
        }

        public frmDiakLista(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void frmDiakLista_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataReader command = new SqlCommand("SELECT diak.diakID, diak.nev, diak.evfolyam, iskola.iskola_neve FROM diak, iskola WHERE diak.iskID=iskola.iskID;", connection).ExecuteReader();
            while (command.Read())
            {
                tabla2.Rows.Add(command[0], command[1], command[2], command[3]);
            }
            connection.Close();
        }

        private void nev_TextChanged(object sender, EventArgs e)
        {
            if (iskola.Text == "")
            {
                tabla2.Rows.Clear();
                tabla2.Refresh();
                connection.Open();
                SqlDataReader command = new SqlCommand("SELECT diak.diakID, diak.nev, diak.evfolyam, iskola.iskola_neve FROM diak, iskola WHERE diak.iskID=iskola.iskID AND diak.nev LIKE '" + nev.Text + "%';", connection).ExecuteReader();
                while (command.Read())
                {
                    tabla2.Rows.Add(command[0], command[1], command[2], command[3]);
                }
                connection.Close();
            }
            else if(iskola.Text != "" && nev.Text != "")
            {
                tabla2.Rows.Clear();
                tabla2.Refresh();
                connection.Open();
                SqlDataReader command = new SqlCommand("SELECT diak.diakID, diak.nev, diak.evfolyam, iskola.iskola_neve FROM diak, iskola WHERE diak.iskID=iskola.iskID AND diak.nev LIKE '" + nev.Text + "%' AND iskola.iskola_neve LIKE '" + iskola.Text + "%';", connection).ExecuteReader();
                while (command.Read())
                {
                    tabla2.Rows.Add(command[0], command[1], command[2], command[3]);
                }
                connection.Close();
            }
            else if (nev.Text == "")
            {
                tabla2.Rows.Clear();
                tabla2.Refresh();
                connection.Open();
                SqlDataReader command = new SqlCommand("SELECT diak.diakID, diak.nev, diak.evfolyam, iskola.iskola_neve FROM diak, iskola WHERE diak.iskID=iskola.iskID AND iskola.iskola_neve LIKE '" + iskola.Text + "%';", connection).ExecuteReader();
                while (command.Read())
                {
                    tabla2.Rows.Add(command[0], command[1], command[2], command[3]);
                }
                connection.Close();
            }
            else
            {
                tabla2.Rows.Clear();
                tabla2.Refresh();
                connection.Open();
                connection.Open();
                SqlDataReader command = new SqlCommand("SELECT diak.diakID, diak.nev, diak.evfolyam, iskola.iskola_neve FROM diak, iskola WHERE diak.iskID=iskola.iskID;", connection).ExecuteReader();
                while (command.Read())
                {
                    tabla2.Rows.Add(command[0], command[1], command[2], command[3]);
                }
                connection.Close();
            }
        }

        private void iskola_TextChanged(object sender, EventArgs e)
        {
            if (nev.Text == "")
            {
                tabla2.Rows.Clear();
                tabla2.Refresh();
                connection.Open();
                SqlDataReader command = new SqlCommand("SELECT diak.diakID, diak.nev, diak.evfolyam, iskola.iskola_neve FROM diak, iskola WHERE diak.iskID=iskola.iskID AND iskola.iskola_neve LIKE '" + iskola.Text + "%';", connection).ExecuteReader();
                while (command.Read())
                {
                    tabla2.Rows.Add(command[0], command[1], command[2], command[3]);
                }
                connection.Close();
            }
            else if (iskola.Text != "" && nev.Text != "")
            {
                tabla2.Rows.Clear();
                tabla2.Refresh();
                connection.Open();
                SqlDataReader command = new SqlCommand("SELECT diak.diakID, diak.nev, diak.evfolyam, iskola.iskola_neve FROM diak, iskola WHERE diak.iskID=iskola.iskID AND diak.nev LIKE '" + nev.Text + "%' AND iskola.iskola_neve LIKE '" + iskola.Text + "%';", connection).ExecuteReader();
                while (command.Read())
                {
                    tabla2.Rows.Add(command[0], command[1], command[2], command[3]);
                }
                connection.Close();
            }
            else if (iskola.Text == "")
            {
                tabla2.Rows.Clear();
                tabla2.Refresh();
                connection.Open();
                SqlDataReader command = new SqlCommand("SELECT diak.diakID, diak.nev, diak.evfolyam, iskola.iskola_neve FROM diak, iskola WHERE diak.iskID=iskola.iskID AND diak.nev LIKE '" + nev.Text + "%';", connection).ExecuteReader();
                while (command.Read())
                {
                    tabla2.Rows.Add(command[0], command[1], command[2], command[3]);
                }
                connection.Close();
            }
            else
            {
                tabla2.Rows.Clear();
                tabla2.Refresh();
                connection.Open();
                connection.Open();
                SqlDataReader command = new SqlCommand("SELECT diak.diakID, diak.nev, diak.evfolyam, iskola.iskola_neve FROM diak, iskola WHERE diak.iskID=iskola.iskID;", connection).ExecuteReader();
                while (command.Read())
                {
                    tabla2.Rows.Add(command[0], command[1], command[2], command[3]);
                }
                connection.Close();
            }
        }

        private void tabla2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRow = tabla2.Rows[e.RowIndex];

                next = true;

                this.Close();

                frmDiak form2 = new frmDiak(connectionString);
                form2.Show();
            }

        }
    }
}
