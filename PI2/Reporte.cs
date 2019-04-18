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

namespace PI2
{
    public partial class Reporte : Form
    {
        string constring = "server=localhost;user id=root;pwd=;persistsecurityinfo=True;database=asistencia;SslMode=none";
        MySqlConnection conn = new MySqlConnection("server=localhost;database=asistencia;uid=root;pwd=");
        string idsalon = "";

        public Reporte(string mat)
        {
            InitializeComponent();

            FillCombo();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

        }

        void FillCombo()
        {

            MessageBox.Show("llegaste a fillcombo1");
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
            comboBox3.SelectedIndex = -1;
            this.comboBox2.Items.Clear();
            this.comboBox3.Items.Clear();


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

        void FillCombo3()
        {
            string select = this.comboBox2.GetItemText(this.comboBox2.SelectedItem).ToString();
            string select1;
            select1 = Regex.Replace(select, "[^0-9]+", string.Empty);
            idsalon = select1;
            MessageBox.Show(select1);
            string Query = "select DATE(fecha) AS 'FECHAA' from asistencia WHERE salon_idsalon = '" +select1+"';";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString("FECHAA");
                    DateTime oDate = Convert.ToDateTime(sName);
                    string fechaBD = oDate.ToString("yyyy-MM-dd");
                    comboBox3.Items.Add(fechaBD);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en: " + ex.Message);
            }

        }

        void fill()
        {

            string select = this.comboBox3.GetItemText(this.comboBox3.SelectedItem).ToString();
            MessageBox.Show("select * FROM asistencia where fecha LIKE '" + select + "%' AND salon_idsalon = '" + idsalon + "';");
            MySqlCommand cmdDataBase = new MySqlCommand("select * FROM asistencia where fecha LIKE '"+select+ "%' AND salon_idsalon = '"+idsalon+"';", conn); //AND salon_idsalon = '"++"'

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCombo2();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCombo3();
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill();
        }
    }
}
