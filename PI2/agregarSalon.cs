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
    public partial class agregarSalon : Form
    {
        Thread th;
        string mat = "";
        string docenteID = "";
        string lun = "0";
        string mar = "0";
        string mie = "0";
        string jue = "0";
        string vie = "0";
        string sab = "0";
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=asistencia;SslMode=none");
        public agregarSalon(string welcm)
        {
            mat = welcm;
            InitializeComponent();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT nombreDocente, id from docentes WHERE matricula = '" + welcm + "';", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string welcom = dt.Rows[0][0].ToString();
            docenteID = dt.Rows[0][1].ToString();
            usuario.Text = "Docente: " + welcom;
 
        }

        private void agregarSalon_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO `asistencia`.`salon` (`num_salon`, `materia`, `horaInicio`, `horaFinal`, `semestre`, `lunes`, `martes`, `miercoles`, `jueves`, `viernes`, `sabado`, `docentes_id`) VALUES ('" + salon.Text+ "', '"+materia.Text+"', '"+semestre.Text+"', '"+hE.Text+"', '"+hF.Text+ "','"+lun+"', '"+mar+"', '"+mie+"', '"+jue+"', '"+vie+"','"+sab+"', '" + docenteID+"');";
            MessageBox.Show(query);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (lunes.Checked == true)
            {
                lun = "1";
            }else if (lunes.Checked == false)
            {
                lun = "0";
            }
        }

        private void martes_CheckedChanged(object sender, EventArgs e)
        {
            if (martes.Checked == true)
            {
                mar = "1";
            }
            else if (martes.Checked == false)
            {
                mar = "0";
            }
        }

        private void miercoles_CheckedChanged(object sender, EventArgs e)
        {
            if (miercoles.Checked == true)
            {
                mie = "1";
            }
            else if (miercoles.Checked == false)
            {
                mie = "0";
            }
        }

        private void jueves_CheckedChanged(object sender, EventArgs e)
        {
            if (jueves.Checked == true)
            {
                jue = "1";
            }
            else if (jueves.Checked == false)
            {
                jue = "0";
            }
        }

        private void viernes_CheckedChanged(object sender, EventArgs e)
        {
            if (viernes.Checked == true)
            {
                vie = "1";
            }
            else if (viernes.Checked == false)
            {
                vie = "0";
            }
        }

        private void sabado_CheckedChanged(object sender, EventArgs e)
        {
            if (sabado.Checked == true)
            {
                sab = "1";
            }
            else if (sabado.Checked == false)
            {
                sab ="0";
            }
        }
    }
}
