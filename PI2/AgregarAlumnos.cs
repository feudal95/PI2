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
using System.Text.RegularExpressions;
using System.IO.Ports;

namespace PI2
{

    
    public partial class AgregarAlumnos : Form
    {
        Thread th;

        string constring = "server=localhost;user id=root;pwd=;persistsecurityinfo=True;database=asistencia;SslMode=none";
        MySqlConnection conn = new MySqlConnection("server=localhost;database=asistencia;uid=root;pwd=");
        string entrada ="";
        string dia = "";
        string matri = "";
        public AgregarAlumnos(string mat)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            DateTime dateValue = DateTime.Now;
            int aa = ((int)dateValue.DayOfWeek);

            switch (aa)
            {
                case 0:

                    dia = "domingo";
                    break;

                case 1:
                    dia = "lunes";
                    break;

                case 2:
                    dia = "martes";
                    break;

                case 3:
                    dia = "miercoles";
                    break;

                case 4:
                    dia = "jueves";
                    break;

                case 5:
                    dia = "viernes";
                    break;

                case 6:

                    dia = "sabado";
                    break;

                default:
                    MessageBox.Show("Error");
                    break;


            }

            MessageBox.Show(dia);
            //string hora = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            string hora = DateTime.Now.ToString("HH:mm:ss");
            DateTime horaActual = new DateTime();
            DateTime horaInicia = new DateTime();
            DateTime horaFinaliza = new DateTime();
            horaActual = DateTime.ParseExact(hora, "H:m:s", null);
            
            



            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT idsalon, num_salon, materia, horaInicio, horaFinal  FROM salon  WHERE horaFinal >  TIME_FORMAT(NOW(), '%T') AND "+dia+" = '1' ORDER BY horaFinal  LIMIT 1;", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                string id = dt.Rows[0][0].ToString();
                string num_sal = dt.Rows[0][1].ToString();
                string mate = dt.Rows[0][2].ToString();
                string bdHoraI = dt.Rows[0][3].ToString();
                string bdHoraF = dt.Rows[0][4].ToString();
                horaInicia = DateTime.ParseExact(bdHoraI, "H:m:s", null);
                horaFinaliza = DateTime.ParseExact(bdHoraF, "H:m:s", null);
                
                if (horaActual.TimeOfDay < horaInicia.TimeOfDay) {


                    MessageBox.Show("La clase " + mate + " Inicia a las: " + bdHoraI + ". Por favor Vuelva a intentar cuando sea la hora de clase");
                    



                } else if (horaActual.TimeOfDay >= horaInicia.TimeOfDay && horaActual.TimeOfDay <= horaFinaliza.TimeOfDay)
                {
                    MessageBox.Show("La clase a comenzando, por favor pase su credencial en el lector");
                    materia.Text = "Matería: " + mate;
                    salon.Text = "Salon: " +num_sal;
                    horaini.Text ="Hora que inicia: " + bdHoraI;
                    horaFina.Text = "Hora que finaliza: " +bdHoraF;
                    

                }

                
            }
            else
            {
                MessageBox.Show("No hay clases para el dia de hoy");

            }


            

            
            
            
            

            //serialPort1.Open();
            //serialPort1.DataReceived += OnDataReceived;
            matri = mat;
        }

        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
             entrada = serialPort1.ReadLine();
            serialPort1.Close();
            textBoxRFID.Text = entrada;
            serialPort1.Open();

        }





        private void button1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                string selectt = this.comboBox1.GetItemText(this.comboBox1.SelectedItem).ToString();
                string idUser;
                idUser = Regex.Replace(selectt, "[^0-9]+", string.Empty);


                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=seguridad3;SslMode=none");
                String consulta5 = string.Format("INSERT INTO `seguridad3`.`accesos` (`usuarios_ID`, `empresa_ID`, `RFID`, `patrones_ID`, `pass`) VALUES ('"+ idUser + "', '"+ textBox_idEmp.Text + "', '"+textBoxRFID.Text+"', '"+ textBox_idP.Text +"', '"+pass.Text+"');");
                MySqlDataAdapter adaptador5 = new MySqlDataAdapter(consulta5, conn);
                MySqlCommandBuilder comando5 = new MySqlCommandBuilder(adaptador5);
                DataTable dt5 = new DataTable();
                adaptador5.Fill(dt5);
                MessageBox.Show("Agregado");

                
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
            */
        }
        

        private void asignarAccesos_Load(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void openNewForm()
        {

            Application.Run(new menu(matri));

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void textBoxRFID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
