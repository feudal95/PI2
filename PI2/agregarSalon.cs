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
            if (salon.Text == "" || materia.Text == "" || semestre.Text == ""|| hE.Text == "" || minE.Text == "" ||hF.Text == "" ||minE.Text == "")
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                try
                {
                    String query = string.Format("INSERT INTO `asistencia`.`salon` (`num_salon`, `materia`, `horaInicio`, `horaFinal`, `semestre`, `lunes`, `martes`, `miercoles`, `jueves`, `viernes`, `sabado`, `docentes_id`) VALUES ('" + salon.Text + "', '" + materia.Text + "', '" + semestre.Text + "', '" + hE.Text + ":" + minE.Text + ":00', '" + hF.Text + ":" + minF.Text + ":00','" + lun + "', '" + mar + "', '" + mie + "', '" + jue + "', '" + vie + "','" + sab + "', '" + docenteID + "');");
                    MessageBox.Show(query);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                    MySqlCommandBuilder comando = new MySqlCommandBuilder(adaptador);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (lunes.Checked == false || martes.Checked == false || miercoles.Checked == false || jueves.Checked == false || viernes.Checked == false || sabado.Checked == false ) // CHECAR ESTA PARTE!!!
                    {
                        MessageBox.Show("¡El salon fue agradado con exito! sin embbargo faltaron asignar los dias que se impartira la materia, esto puede ser modificado previamente, pero hasta entonces, no se podra tomar asistencia en esta materia hasta que se asignen los dias");
                    }
                    else
                    {
                        MessageBox.Show("¡Salon agregado exitosamente!");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error insertar datos" + ex.Message);
                }
            }





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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void hE_TextChanged(object sender, EventArgs e)
        {
            if (hE.Text == "")
            {

            }
            else if (hE.Text != "") {

                if (int.Parse(hE.Text) > 23){
                    MessageBox.Show("La hora de inicio no puede exceder de las 23:00 horas ");
                    hE.Text = "";
                }
            }

        }

        private void hE_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void hE_KeyPress(object sender, KeyPressEventArgs e)
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

        private void minE_TextChanged(object sender, EventArgs e)
        {
            if (minE.Text == "")
            {

            }
            else if (minE.Text != "")
            {

                if (int.Parse(minE.Text) > 59)
                {
                    MessageBox.Show("Los minutos de la clase no pueden exceder de 59 minutos ");
                    minE.Text = "";
                }
            }


        }

        private void minE_KeyPress(object sender, KeyPressEventArgs e)
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

        private void hF_TextChanged(object sender, EventArgs e)
        {
            if (hE.Text == "" || minE.Text == "")
            {
                hF.Text = "";

            }

        }

        private void hF_MouseDown(object sender, MouseEventArgs e)
        {
            if (hE.Text == "" || minE.Text == "")
            {
                hF.Text = "";
                MessageBox.Show("Por favor, primero escoja la hora de inicio de la clase");
            }
        }

        private void hF_KeyPress(object sender, KeyPressEventArgs e)
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

        private void minF_KeyPress(object sender, KeyPressEventArgs e)
        {
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
        }

        private void minF_MouseDown(object sender, MouseEventArgs e)
        {
            if (hE.Text == "" || minE.Text == "")
            {
                minF.Text = "";
                MessageBox.Show("Por favor, primero escoja la hora de inicio de la clase");
            }
        }

        private void minF_TextChanged(object sender, EventArgs e)
        {
            if (hE.Text == "" || minE.Text == "")
            {
                minF.Text = "";

            }
        }
    }
}
