using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;


namespace PI2
{
    public partial class Form1 : Form
    {
        Thread th;

        MySqlConnection conn = new MySqlConnection("server=localhost;database=asistencia;uid=root;pwd=");
        string mat = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT count(*) from docentes WHERE matricula = '" + txtUser.Text + "' AND pass = '" + txtPass.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /*
                this.Hide();
                Form f2 = new menu(txtUser.Text);
                f2.ShowDialog();
                this.Close();
                */
                mat = user;
                this.Close();
                th = new Thread(openNewForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

                /*
                menu m = new menu();
                m.Show();
                */
                //MessageBox.Show("username and password are matched", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Datos Incorrectos", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void openNewForm()
        {

            Application.Run(new menu(mat));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
     