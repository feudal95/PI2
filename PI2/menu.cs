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
    public partial class menu : Form
    {
        Thread th;
        MySqlConnection conn = new MySqlConnection("server=localhost;database=asistencia;uid=root;pwd=contra");
        string mat = "";
        
        public menu(string welcm)
        {
            string matricula = welcm;
            mat = welcm;

            InitializeComponent();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT nombreDocente from docentes WHERE matricula = '" + welcm+"';", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string welcom = dt.Rows[0][0].ToString();
            welcome.Text = "Bienvenido " + welcom + " ¿Que desea hacer hoy?";

                
          
        }


        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            /* */


        }


        private void openNewForm()
        {

                Application.Run(new agregarSalon(mat));
                
        }

        private void openNewForm2()
        {

            Application.Run(new registroAsistencia(mat));

        }

        private void openNewForm3()
        {

            Application.Run(new registroAlumnos(mat));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm4);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openNewForm4()
        {

            Application.Run(new Reporte(mat));

        }


        private void openNewForm5()
        {

            Application.Run(new ModAlumno(mat));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm5);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
