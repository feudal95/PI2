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
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;
using System.Threading;
using System.Text.RegularExpressions;



namespace PI2
{
    public partial class Reporte : Form
    {
        string constring = "server=localhost;user id=root;pwd=;persistsecurityinfo=True;database=asistencia;SslMode=none";
        MySqlConnection conn = new MySqlConnection("server=localhost;database=asistencia;uid=root;pwd=");
        string idsalon = "";
        string nombreMat = "";
        string hourE = "";
        string hourF = "";
        string semestre = "";
        string lun = "0";
        string mar = "0";
        string mie = "0";
        string jue = "0";
        string vie = "0";
        string sab = "0";
        Thread th;
        string matri = "";
        
        string docenteID = "";


        public Reporte(string mat)
        {
            InitializeComponent();
            FillCombo();
            button2.Enabled= false;
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT nombreDocente, id from docentes WHERE matricula = '" + mat + "';", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string welcom = dt.Rows[0][0].ToString();
            docenteID = dt.Rows[0][1].ToString();
            welc.Text = "Docente: " + welcom;
            matri = mat;
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

        }

        void FillCombo()
        {

            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            this.comboBox2.Items.Clear();
            this.comboBox3.Items.Clear();
            semes.Text = "Semestre";
            start.Text = "Hora Inicio";
            end.Text = "Hora Termina";
            lunesC.Checked = false;
            martesC.Checked = false;
            miercolesC.Checked = false;
            juevesC.Checked = false;
            viernesC.Checked = false;

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
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            this.comboBox2.Items.Clear();
            this.comboBox3.Items.Clear();
            semes.Text = "Semestre";
            start.Text = "Hora Inicio";
            end.Text = "Hora Termina";
            lunesC.Checked = false;
            martesC.Checked = false;
            miercolesC.Checked = false;
            juevesC.Checked = false;
            viernesC.Checked = false;


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
            
            comboBox3.SelectedIndex = -1;
            
            this.comboBox3.Items.Clear();
            semes.Text = "Semestre";
            start.Text = "Hora Inicio";
            end.Text = "Hora Termina";
            lunesC.Checked = false;
            martesC.Checked = false;
            miercolesC.Checked = false;
            juevesC.Checked = false;
            viernesC.Checked = false;
            string select = this.comboBox2.GetItemText(this.comboBox2.SelectedItem).ToString();
            string select1;
            select1 = Regex.Replace(select, "[^0-9]+", string.Empty);
            nombreMat= Regex.Replace(select, @"[\d-]", string.Empty);
            idsalon = select1;
            //MessageBox.Show(select1);
            string Query = "select DISTINCT DATE(fecha) AS 'FECHAA' from asistencia WHERE salon_idsalon = '" +select1+"';";
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

        void fillLabelsAndCheckbox()
        {

            string select = this.comboBox2.GetItemText(this.comboBox2.SelectedItem).ToString();
            string select1;
            select1 = Regex.Replace(select, "[^0-9]+", string.Empty);
            
            string Query = "SELECT materia AS materia1, horaInicio, horaFinal, semestre, lunes, martes, miercoles, jueves, viernes, sabado  FROM salon WHERE idsalon = '" + select1 + "' ;";
            MessageBox.Show(Query);
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
                    semes.Text= "Materia: " + myReader.GetString("materia1");
                    start.Text = "Hora Inicio: " + myReader.GetString("horaInicio");
                    end.Text = "Hora Termina: " + myReader.GetString("horaFinal");
                    if (myReader.GetString("lunes") == "1")
                    {
                        lunesC.Checked = true;
                    }
                    if (myReader.GetString("martes") == "1")
                    {
                        martesC.Checked = true;
                    }
                    if (myReader.GetString("miercoles") == "1")
                    {
                        miercolesC.Checked = true;
                    }
                    if (myReader.GetString("jueves") == "1")
                    {
                        juevesC.Checked = true;
                    }
                    if (myReader.GetString("viernes") == "1")
                    {
                        viernesC.Checked = true;
                    }
                    if (myReader.GetString("sabado") == "1")
                    {
                        sabadoC.Checked = true;
                    }




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
            //MySqlCommand cmdDataBase = new MySqlCommand("select * FROM asistencia where fecha LIKE '"+select+ "%' AND salon_idsalon = '"+idsalon+"';", conn); //AND salon_idsalon = '"++"'


            //MySqlCommand cmdDataBase = new MySqlCommand("SELECT asistencia.salon_idsalon AS ID_Materia, salon.materia, asistencia.matricula, nombreAlumno AS Alumno, asistencia.asistencia, asistencia.fecha FROM asistencia INNER JOIN alumnos on asistencia.salon_idsalon = alumnos.salon_idsalon INNER JOIN salon on asistencia.salon_idsalon = salon.idsalon  WHERE asistencia.fecha LIKE '" + select + "%' AND asistencia.salon_idsalon = '" + idsalon + "';", conn);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT  asistencia.salon_idsalon AS ID_Materia, asistencia.matricula, nombreAlumno AS Alumno, asistencia.asistencia, asistencia.fecha FROM asistencia INNER JOIN alumnos on asistencia.matricula = alumnos.matricula WHERE asistencia.fecha LIKE '" + select + "%' AND asistencia.salon_idsalon = '" + idsalon + "';", conn);

            //                                           SELECT  asistencia.salon_idsalon AS ID_Materia, asistencia.matricula, nombreAlumno AS Alumno, asistencia.asistencia, asistencia.fecha FROM asistencia INNER JOIN alumnos on asistencia.matricula = alumnos.matricula 

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




                /*
            DataSet ds = new DataSet("New_DataSet");
            ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
            sda.Fill(dbdataset);
            ds.Tables.Add(dbdataset);
            ExcelLibrary.DataSetHelper.CreateWorkbook("wolololo.xls", ds);
            */



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
            fillLabelsAndCheckbox();
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox3.Text))
            {

            }else { 
            fill();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            
            workbook.SaveAs("Reporte_"+nombreMat+".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Quit();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            this.Close();
            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openNewForm()
        {

            Application.Run(new menu(matri));

        }
    }
}
