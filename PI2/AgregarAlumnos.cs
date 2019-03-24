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

        string entrada ="";

        string matri = "";
        public AgregarAlumnos(string mat)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
                  serialPort1.Open();
            serialPort1.DataReceived += OnDataReceived;
            string matri = mat;
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
