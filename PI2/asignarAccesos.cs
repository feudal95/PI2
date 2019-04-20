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
        string idsalon ="";
        string idDocente = "";
        string constring = "server=localhost;user id=root;pwd=;persistsecurityinfo=True;database=asistencia;SslMode=none";
        MySqlConnection conn = new MySqlConnection("server=localhost;database=asistencia;uid=root;pwd=");
        public asignarAccesos(string mat)
        {

            
            InitializeComponent();

            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT nombreDocente , id FROM docentes WHERE matricula = '" + mat + "';", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string welcom = dt.Rows[0][0].ToString();
            idDocente = dt.Rows[0][1].ToString();
            
            name.Text = "Docente: " + welcom;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            CheckForIllegalCrossThreadCalls = false;

            if (serialPort1.IsOpen)
            {
                serialPort1.Open();
                serialPort1.DataReceived += OnDataReceived;
            }
            else
            {
                MessageBox.Show("por favor conecte el lector para proceder con la asignacion de accesos");
            }

            matri = mat;
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
            idsalon = select1;
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


            if (comboBox1.SelectedIndex < -1 || comboBox2.SelectedIndex < -1 || horaInicioTxt.Text=="" || horaFinTxt.Text == "" || textNombre.Text == "" || textMatricula.Text=="" || textBoxRFID.Text == "")
            {
                MessageBox.Show("Porfavor, complete todos ");
            }
            else
            {

                try
                {


                    //string query = "INSERT INTO `asistencia`.`alumnos` (`RFID`, `matricula`, `nombreAlumno`, `docentes_id`, `salon_idsalon`) VALUES ('"+ textBoxRFID.Text+ "', '"+ textMatricula.Text+ "', '"+ textNombre .Text+ "', '"+idDocente+"', '"+idsalon+"')";



                    String consulta5 = string.Format("INSERT INTO `asistencia`.`alumnos` (`RFID`, `matricula`, `nombreAlumno`, `docentes_id`, `salon_idsalon`) VALUES ('" + textBoxRFID.Text + "', '" + textMatricula.Text + "', '" + textNombre.Text + "', '" + idDocente + "', '" + idsalon + "')");
                    MySqlDataAdapter adaptador5 = new MySqlDataAdapter(consulta5, conn);
                    MySqlCommandBuilder comando5 = new MySqlCommandBuilder(adaptador5);
                    DataTable dt5 = new DataTable();
                    adaptador5.Fill(dt5);
                    MessageBox.Show("Alumno agregado exitosamente");
                    comboBox1.SelectedIndex = -1;
                    this.comboBox1.Items.Clear();
                    comboBox2.SelectedIndex = -1;
                    this.comboBox2.Items.Clear();
                    horaInicioTxt.Text = "";
                    horaFinTxt.Text = "";
                    textNombre.Text = "";
                    textMatricula.Text = "";
                    textBoxRFID.Text = "";







                    /* RECUERDA PONER RESTIRCCION AQUI PARA QUE NO PONGA DUPLICADOS*/


                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message);
                }


                
            }

            
            
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
            serialPort1.Close();

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
