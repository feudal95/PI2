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

        MySqlConnection conn = new MySqlConnection("server=localhost;database=asistencia;uid=root;pwd=contra");
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

            fill();
        }


        void fill()
        {
            MySqlCommand cmdDataBase = new MySqlCommand("select num_salon, materia, horaInicio, horaFinal, semestre, lunes, martes, miercoles, jueves, viernes, sabado from salon;", conn);

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



        private void button1_Click(object sender, EventArgs e)
        {
            if (salon.Text == "" || materia.Text == "" || semestre.Text == ""|| hE.Text == "" || minE.Text == "" ||hF.Text == "" ||minE.Text == "")
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {



                int i = 0;
                foreach (Control c in groupBox1.Controls)
                {

                    if (c is CheckBox)
                    {
                        CheckBox cb = (CheckBox)c;

                        if (cb.Checked == false)
                        {
                            i = i + 1;
                            if (i == 6)
                            {

                                MessageBox.Show("Por favor, seleccione los dias en los que se impartira la clase para que se agregue el grupo.");
 

                            }








                        } else{

                            checarEmpalme();
                            return;
                            //MessageBox.Show("TODO OKAY PARA QUERY");




                            /*
                            try
                            {
                                String query = string.Format("INSERT INTO `asistencia`.`salon` (`num_salon`, `materia`, `horaFinal`, `horaInicio`, `semestre`, `lunes`, `martes`, `miercoles`, `jueves`, `viernes`, `sabado`, `docentes_id`) VALUES ('" + salon.Text + "', '" + materia.Text + "', '" + hF.Text + ":" + minF.Text + ":00', '" + hE.Text + ":" + minE.Text + ":00', '" + semestre.Text + "','" + lun + "', '" + mar + "', '" + mie + "', '" + jue + "', '" + vie + "','" + sab + "', '" + docenteID + "');");
                                MessageBox.Show(query);
                                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                                MySqlCommandBuilder comando = new MySqlCommandBuilder(adaptador);
                                DataTable dt = new DataTable();
                                adaptador.Fill(dt);

                                MessageBox.Show("¡Salon agregado exitosamente!");

                                fill();
                                return;

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("error insertar datos" + ex.Message);
                                return;
                            }
                            */

                        }




                    }
                }
            }





        }

        private void ingresarDatos()
        {
            try
            {
                String query = string.Format("INSERT INTO `asistencia`.`salon` (`num_salon`, `materia`, `horaFinal`, `horaInicio`, `semestre`, `lunes`, `martes`, `miercoles`, `jueves`, `viernes`, `sabado`, `docentes_id`) VALUES ('" + salon.Text + "', '" + materia.Text + "', '" + hF.Text + ":" + minF.Text + ":00', '" + hE.Text + ":" + minE.Text + ":00', '" + semestre.Text + "','" + lun + "', '" + mar + "', '" + mie + "', '" + jue + "', '" + vie + "','" + sab + "', '" + docenteID + "');");
                MessageBox.Show(query);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder comando = new MySqlCommandBuilder(adaptador);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                MessageBox.Show("¡Salon agregado exitosamente!");

                fill();
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("error insertar datos" + ex.Message);
                return;
            }
        }

        private void test()
        {
            MessageBox.Show("LLEGASTE");
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
            if (hF.Text == "")
            {

            }
            else if (hF.Text != "")
            {

                if (int.Parse(hF.Text) > 23)
                {
                    MessageBox.Show("La hora a la que termina la clase no puede exceder de las 23:00 horas ");
                    hF.Text = "";
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void hF_Leave(object sender, EventArgs e)
        {

            if (hF.Text == "")
            {

            }else if (hF.Text != "")
            {
                if (int.Parse(hF.Text) < int.Parse(hE.Text))
                {
                    MessageBox.Show("Por favor, ingrese una hora valida, la hora en la que finaliza la clase, no puede ser menor a la hora que empieza.");
                    hF.Text = "";


                }


            }
                        
        }

        private void minF_Leave(object sender, EventArgs e)
        {


            if (hF.Text == "")
            {
                minF.Text = "";
            }

            if (minF.Text == "")
            {

            }
            else if (minF.Text != "")
            {

                if (int.Parse(hF.Text) == int.Parse(hE.Text))
                {
                    if (int.Parse(minF.Text) <= int.Parse(minE.Text))
                    {
                        MessageBox.Show("Por favor, ingrese una hora valida, la hora en la que finaliza la clase, no puede ser menor a la hora que empieza.");
                        minF.Text = "";


                    }
                }
                else if ((int.Parse(hF.Text) <= int.Parse(hE.Text)))
                {
                    if (int.Parse(minF.Text) <= int.Parse(minE.Text))
                    {
                        MessageBox.Show("Por favor, ingrese una hora valida, la hora en la que finaliza la clase, no puede ser menor a la hora que empieza.");
                        minF.Text = "";


                    }
                }

                


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
/*
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        MessageBox.Show(cell.Value.ToString()); ////ss
                    }
                }
            }
            */
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            checarEmpalme();
            
        }

        private void checarEmpalme()
        {
            string h = "";
            string termina = "";
            string existente = "";

            string horasE = hE.Text + ":" + minE.Text + ":00";
            string horasF = hF.Text + ":" + minF.Text + ":00";
            DateTime horaExistente = new DateTime();
            DateTime horaExistenteTermina = new DateTime();


            DateTime horaIngresar = new DateTime();/**/
            DateTime horaIngresarTermina = new DateTime();
            horaIngresarTermina = DateTime.ParseExact(horasF, "H:m:s", null); /*SIGUELE AQUI 16 MARZO */
            horaIngresar = DateTime.ParseExact(horasE, "H:m:s", null);
            MessageBox.Show("Hora ingrear empieza"+ horaIngresar.ToString("H:m:s"));
            MessageBox.Show("Hora ingrear termina" + horaIngresarTermina.ToString("H:m:s"));



            if (hE.Text != "") { 
                if (lun == "1") {

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i = 10; i < dataGridView1.Columns.Count; i++)
                        {


                            if (row.Cells[2].Value != null)
                            {
                                //MessageBox.Show(row.Cells[2].Value.ToString());
                                h = row.Cells[2].Value.ToString();
                                termina = row.Cells[3].Value.ToString();
                                existente = h;
                                horaExistenteTermina = DateTime.ParseExact(termina, "H:m:s", null);
                                horaExistente = DateTime.ParseExact(existente, "H:m:s", null);
                                MessageBox.Show(horaExistente.ToString("H:m:s"));
                                MessageBox.Show(horaExistenteTermina.ToString("H:m:s"));

                                if (horaIngresar.TimeOfDay > horaExistente.TimeOfDay && horaIngresar.TimeOfDay < horaExistenteTermina.TimeOfDay)
                                {
                                    MessageBox.Show("Hay empalme en la hora de entrada, dia lunes");
                                    return;
                                }


                                if (horaIngresar.TimeOfDay < horaExistente.TimeOfDay || horaIngresar.TimeOfDay == horaExistente.TimeOfDay)
                                {
                                    if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay < horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia lunes");
                                        return;
                                    }
                                    else if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay > horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia lunes");
                                        return;
                                    }

                                    else if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay == horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia lunes");
                                        return;
                                    }
                                }


                               /*
                                if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay < horaExistenteTermina.TimeOfDay)
                                {
                                    MessageBox.Show("Hay empalme en la hora de salida");
                                }

                                /*if (int.Parse(hE.Text) == hStart)
                                {
                                    MessageBox.Show("existe empalme en hora BORRA ESTE MENSAJE");
                                }else
                                {

                                }*/

                            }
                        }
                    }
                }
                if (mar == "1")
                {

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i = 10; i < dataGridView1.Columns.Count; i++)
                        {


                            if (row.Cells[2].Value != null)
                            {
                                //MessageBox.Show(row.Cells[2].Value.ToString());
                                h = row.Cells[2].Value.ToString();
                                termina = row.Cells[3].Value.ToString();
                                existente = h;
                                horaExistenteTermina = DateTime.ParseExact(termina, "H:m:s", null);
                                horaExistente = DateTime.ParseExact(existente, "H:m:s", null);
                                MessageBox.Show(horaExistente.ToString("H:m:s"));
                                MessageBox.Show(horaExistenteTermina.ToString("H:m:s"));


                                if (horaIngresar.TimeOfDay > horaExistente.TimeOfDay && horaIngresar.TimeOfDay < horaExistenteTermina.TimeOfDay)
                                {
                                    MessageBox.Show("Hay empalme en la hora de entrada, dia martes");
                                    return;
                                }


                                if (horaIngresar.TimeOfDay < horaExistente.TimeOfDay)
                                {
                                    if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay < horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia martes");
                                        return;
                                    }
                                    else if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay > horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia martes");
                                        return;
                                    }
                                }

                            }
                        }
                    }
                }
                if (mie == "1")
                {

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i = 10; i < dataGridView1.Columns.Count; i++)
                        {


                            if (row.Cells[2].Value != null)
                            {
                                //MessageBox.Show(row.Cells[2].Value.ToString());
                                h = row.Cells[2].Value.ToString();
                                termina = row.Cells[3].Value.ToString();
                                existente = h;
                                horaExistenteTermina = DateTime.ParseExact(termina, "H:m:s", null);
                                horaExistente = DateTime.ParseExact(existente, "H:m:s", null);
                                MessageBox.Show(horaExistente.ToString("H:m:s"));
                                MessageBox.Show(horaExistenteTermina.ToString("H:m:s"));


                                if (horaIngresar.TimeOfDay > horaExistente.TimeOfDay && horaIngresar.TimeOfDay < horaExistenteTermina.TimeOfDay)
                                {
                                    MessageBox.Show("Hay empalme en la hora de entrada, dia martes");
                                    return;
                                }


                                if (horaIngresar.TimeOfDay < horaExistente.TimeOfDay)
                                {
                                    if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay < horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia miercoles");
                                        return;
                                    }
                                    else if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay > horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia miercoles");
                                        return;
                                    }
                                }

                            }
                        }
                    }
                }
                if (jue == "1")
                {

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i = 10; i < dataGridView1.Columns.Count; i++)
                        {


                            if (row.Cells[2].Value != null)
                            {
                                //MessageBox.Show(row.Cells[2].Value.ToString());
                                h = row.Cells[2].Value.ToString();
                                termina = row.Cells[3].Value.ToString();
                                existente = h;
                                horaExistenteTermina = DateTime.ParseExact(termina, "H:m:s", null);
                                horaExistente = DateTime.ParseExact(existente, "H:m:s", null);
                                MessageBox.Show(horaExistente.ToString("H:m:s"));
                                MessageBox.Show(horaExistenteTermina.ToString("H:m:s"));


                                if (horaIngresar.TimeOfDay > horaExistente.TimeOfDay && horaIngresar.TimeOfDay < horaExistenteTermina.TimeOfDay)
                                {
                                    MessageBox.Show("Hay empalme en la hora de entrada, dia jueves");
                                    return;
                                }


                                if (horaIngresar.TimeOfDay < horaExistente.TimeOfDay)
                                {
                                    if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay < horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia jueves");
                                        return;
                                    }
                                    else if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay > horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia jueves");
                                        return;
                                    }
                                }

                            }
                        }
                    }
                }
                if (vie == "1")
                {

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i = 10; i < dataGridView1.Columns.Count; i++)
                        {


                            if (row.Cells[2].Value != null)
                            {
                                //MessageBox.Show(row.Cells[2].Value.ToString());
                                h = row.Cells[2].Value.ToString();
                                termina = row.Cells[3].Value.ToString();
                                existente = h;
                                horaExistenteTermina = DateTime.ParseExact(termina, "H:m:s", null);
                                horaExistente = DateTime.ParseExact(existente, "H:m:s", null);
                                MessageBox.Show(horaExistente.ToString("H:m:s"));
                                MessageBox.Show(horaExistenteTermina.ToString("H:m:s"));


                                if (horaIngresar.TimeOfDay > horaExistente.TimeOfDay && horaIngresar.TimeOfDay < horaExistenteTermina.TimeOfDay)
                                {
                                    MessageBox.Show("Hay empalme en la hora de entrada, dia viernes");
                                    return;
                                }


                                if (horaIngresar.TimeOfDay < horaExistente.TimeOfDay)
                                {
                                    if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay < horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia viernes");
                                        return;
                                    }
                                    else if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay > horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia viernes");
                                        return;
                                    }
                                }

                            }
                        }
                    }
                }
                if (sab == "1")
                {

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i = 10; i < dataGridView1.Columns.Count; i++)
                        {


                            if (row.Cells[2].Value != null)
                            {
                                //MessageBox.Show(row.Cells[2].Value.ToString());
                                h = row.Cells[2].Value.ToString();
                                termina = row.Cells[3].Value.ToString();
                                existente = h;
                                horaExistenteTermina = DateTime.ParseExact(termina, "H:m:s", null);
                                horaExistente = DateTime.ParseExact(existente, "H:m:s", null);
                                MessageBox.Show(horaExistente.ToString("H:m:s"));
                                MessageBox.Show(horaExistenteTermina.ToString("H:m:s"));


                                if (horaIngresar.TimeOfDay > horaExistente.TimeOfDay && horaIngresar.TimeOfDay < horaExistenteTermina.TimeOfDay)
                                {
                                    MessageBox.Show("Hay empalme en la hora de entrada, dia sabado");
                                    return;
                                }


                                if (horaIngresar.TimeOfDay < horaExistente.TimeOfDay)
                                {
                                    if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay < horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia sabado");
                                        return;
                                    }
                                    else if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay > horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia sabado");
                                        return;
                                        /**/
                                    }
                                }

                            }
                        }
                    }
                }


                ingresarDatos();
            }

        }
    }
}
