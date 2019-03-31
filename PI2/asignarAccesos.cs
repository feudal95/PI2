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


    public partial class asignarAccesos : Form
    {
        Thread th;

        string entrada = "";

        string matri = "";
        string constring = "server=localhost;user id=root;persistsecurityinfo=True;database=asistencia;SslMode=none";
        public asignarAccesos(string mat)
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            CheckForIllegalCrossThreadCalls = false;
            //  serialPort1.Open();
            //serialPort1.DataReceived += OnDataReceived;
            string matri = mat;
            FillCombo();
        }


        void FillCombo()
        {


            string Query = "SELECT DISTINCT num_salon FROM salon;";
            //string Query = "select CONCAT_WS('    ', idsalon, num_salon) AS nombre  from patrones;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString("num_salon");
                    comboBox1.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en: " + ex.Message);
            }
        }



        void FillCombo2()
        {

            comboBox2.SelectedIndex = -1;
            this.comboBox2.Items.Clear();


            string select = this.comboBox1.GetItemText(this.comboBox1.SelectedItem).ToString();

            //string select1;
            //select1 = Regex.Replace(select, "[^0-9]+", string.Empty);

            //   MessageBox.Show(select1);




            //MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=seguridad3;SslMode=none");
            string Query = "SELECT CONCAT_WS('    ', idsalon, materia) AS materia  FROM salon WHERE num_salon = '" + select + "' ;";
            //"(SELECT CONCAT_WS('    ', ID, nombre ) AS nombreUsuario, empleado, patron from usuarios ID = '" + select1 + "') UNION (SELECT CONCAT_WS('    ', empleados.usuarios_ID, empleados.nombre ) nombreUsuario, patron, empleado from usuarios INNER JOIN patrones ON usuarios.ID = patrones.usuarios_ID INNER JOIN empleados ON patrones.ID = empleados.patrones_ID WHERE usuarios.ID = '" + select1 + "'); ";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString("materia");
                    comboBox2.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en: " + ex.Message);
            }
        }


        void fill3(){
            string select = this.comboBox2.GetItemText(this.comboBox2.SelectedItem).ToString();
            string select1;
            select1 = Regex.Replace(select, "[^0-9]+", string.Empty);
            string Query = "SELECT horaInicio, horaFinal FROM salon WHERE idsalon = '"+select1+"';";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string horaI = myReader.GetString("horaInicio");
                    string horaF = myReader.GetString("horaFinal");
                    horaInicioTxt.Text = horaI;
                    horaFinTxt.Text = horaF;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en: " + ex.Message);
            }


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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCombo2();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fill3();
        }
    }
}
