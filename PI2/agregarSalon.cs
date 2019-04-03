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
        string horaeoriginal = "";
        string horaforiginal = "";
        string saltem = "";
        string mattem = "";
        Boolean centinela = false;
       


        MySqlConnection conn = new MySqlConnection("server=localhost;database=asistencia;uid=root;pwd=contra");
        public agregarSalon(string welcm)
        {
            mat = welcm;
            InitializeComponent();
            button2.Visible = false;
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

                salon.Text = "";
                materia.Text = "";
                semestre.Text = "";
                hF.Text = "";
                minF.Text = "";
                hE.Text = "";
                minE.Text = "";
                lunes.Checked = false;
                martes.Checked = false;
                miercoles.Checked = false;
                jueves.Checked = false;
                viernes.Checked = false;
                sabado.Checked = false;
                centinela = false;
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
            

            

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string dia = "";
                dataGridView1.CurrentRow.Selected = true;
                salon.Text = dataGridView1.Rows[e.RowIndex].Cells["num_salon"].FormattedValue.ToString();
                saltem = salon.Text;
                materia.Text = dataGridView1.Rows[e.RowIndex].Cells["materia"].FormattedValue.ToString();
                mattem = materia.Text;
                horaeoriginal= dataGridView1.Rows[e.RowIndex].Cells["horaInicio"].FormattedValue.ToString();
                hE.Text = dataGridView1.Rows[e.RowIndex].Cells["horaInicio"].FormattedValue.ToString().Substring(0,2);
                Console.WriteLine(hE.Text);
                string temp = dataGridView1.Rows[e.RowIndex].Cells["horaInicio"].FormattedValue.ToString().Substring(3,3);
                temp = temp.Replace(":", "");
                minE.Text =temp;
                horaforiginal= dataGridView1.Rows[e.RowIndex].Cells["horaFinal"].FormattedValue.ToString();
                hF.Text = dataGridView1.Rows[e.RowIndex].Cells["horaFinal"].FormattedValue.ToString().Substring(0, 2);
                temp = dataGridView1.Rows[e.RowIndex].Cells["horaFinal"].FormattedValue.ToString().Substring(2,4);
                temp = temp.Replace(":", "");
                minF.Text = temp;
                semestre.Text = dataGridView1.Rows[e.RowIndex].Cells["semestre"].FormattedValue.ToString();



                dia = dataGridView1.Rows[e.RowIndex].Cells["lunes"].FormattedValue.ToString();
                if (dia.Equals("1"))
                {
                    lunes.Checked = true;
                }
                dia = dataGridView1.Rows[e.RowIndex].Cells["martes"].FormattedValue.ToString();
                if (dia.Equals("1"))
                {
                    martes.Checked = true;
                }
                dia = dataGridView1.Rows[e.RowIndex].Cells["miercoles"].FormattedValue.ToString();
                if (dia.Equals("1"))
                {
                    miercoles.Checked = true;
                }
                dia = dataGridView1.Rows[e.RowIndex].Cells["jueves"].FormattedValue.ToString();
                if (dia.Equals("1"))
                {
                    jueves.Checked = true;
                }
                dia = dataGridView1.Rows[e.RowIndex].Cells["viernes"].FormattedValue.ToString();
                if (dia.Equals("1"))
                {
                    viernes.Checked = true;
                }
                dia = dataGridView1.Rows[e.RowIndex].Cells["sabado"].FormattedValue.ToString();
                if (dia.Equals("1"))
                {
                    sabado.Checked = true;
                }

                if (agregarSalon.InputBox() == DialogResult.OK)
                {
                    try
                    {
                       String query = string.Format("DELETE FROM `asistencia`.`salon` WHERE num_salon='" + saltem + "' AND materia='" + mattem + "';");
                        MessageBox.Show(query);
                        MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                        MySqlCommandBuilder comando = new MySqlCommandBuilder(adaptador);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);

                        MessageBox.Show("¡Datos borrados exitosamente!");

                        fill();

                        salon.Text = "";
                        materia.Text = "";
                        semestre.Text = "";
                        hF.Text = "";
                        minF.Text = "";
                        hE.Text = "";
                        minE.Text = "";
                        lunes.Checked = false;
                        martes.Checked = false;
                        miercoles.Checked = false;
                        jueves.Checked = false;
                        viernes.Checked = false;
                        sabado.Checked = false;
                        centinela = false;
                        button2.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error al borrar datos" + ex.Message);
                        return;
                    }
                }
                else
                {
                    button2.Visible = true;
                }
                    
            }
            
        }

        private void checarEmpalme()
        {
            string h = "";
            string termina = "";
            string existente = "";
            string ll = "";
            string mm = "";
            string mmm = "";
            string jj = "";
            string vv = "";
            string ss = "";
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
                                ll = row.Cells[5].Value.ToString();
                                MessageBox.Show(horaExistente.ToString("H:m:s"));
                                MessageBox.Show(horaExistenteTermina.ToString("H:m:s"));

                                if ((horaIngresar.TimeOfDay > horaExistente.TimeOfDay && horaIngresar.TimeOfDay < horaExistenteTermina.TimeOfDay) && ll == "1")
                                {
                                    MessageBox.Show("Hay empalme en la hora de entrada, dia lunes");
                                    return;
                                }


                                if ((horaIngresar.TimeOfDay < horaExistente.TimeOfDay || horaIngresar.TimeOfDay == horaExistente.TimeOfDay) && ll == "1")
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
                                mm = row.Cells[6].Value.ToString();
                                existente = h;
                                horaExistenteTermina = DateTime.ParseExact(termina, "H:m:s", null);
                                horaExistente = DateTime.ParseExact(existente, "H:m:s", null);

                                MessageBox.Show(horaExistente.ToString("H:m:s"));
                                MessageBox.Show(horaExistenteTermina.ToString("H:m:s"));

                                if ((horaIngresar.TimeOfDay > horaExistente.TimeOfDay && horaIngresar.TimeOfDay < horaExistenteTermina.TimeOfDay) && mm == "1")
                                {
                                    MessageBox.Show("Hay empalme en la hora de entrada, dia martes");
                                    return;
                                }


                                if ((horaIngresar.TimeOfDay < horaExistente.TimeOfDay || horaIngresar.TimeOfDay == horaExistente.TimeOfDay) && mm == "1")
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

                                    else if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay == horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia martes");
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
                                mmm = row.Cells[7].Value.ToString();
                                existente = h;
                                horaExistenteTermina = DateTime.ParseExact(termina, "H:m:s", null);
                                horaExistente = DateTime.ParseExact(existente, "H:m:s", null);

                                MessageBox.Show(horaExistente.ToString("H:m:s"));
                                MessageBox.Show(horaExistenteTermina.ToString("H:m:s"));

                                if ((horaIngresar.TimeOfDay > horaExistente.TimeOfDay && horaIngresar.TimeOfDay < horaExistenteTermina.TimeOfDay) && mmm == "1")
                                {
                                    MessageBox.Show("Hay empalme en la hora de entrada, dia miercoles");
                                    return;
                                }


                                if ((horaIngresar.TimeOfDay < horaExistente.TimeOfDay || horaIngresar.TimeOfDay == horaExistente.TimeOfDay) && mmm == "1")
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

                                    else if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay == horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia miercoles");
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
                                jj = row.Cells[8].Value.ToString();
                                existente = h;
                                horaExistenteTermina = DateTime.ParseExact(termina, "H:m:s", null);
                                horaExistente = DateTime.ParseExact(existente, "H:m:s", null);

                                MessageBox.Show(horaExistente.ToString("H:m:s"));
                                MessageBox.Show(horaExistenteTermina.ToString("H:m:s"));

                                if ((horaIngresar.TimeOfDay > horaExistente.TimeOfDay && horaIngresar.TimeOfDay < horaExistenteTermina.TimeOfDay) && jj == "1")
                                {
                                    MessageBox.Show("Hay empalme en la hora de entrada, dia jueves");
                                    return;
                                }


                                if ((horaIngresar.TimeOfDay < horaExistente.TimeOfDay || horaIngresar.TimeOfDay == horaExistente.TimeOfDay) && jj == "1")
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

                                    else if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay == horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia jueves");
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
                                vv = row.Cells[9].Value.ToString();
                                existente = h;
                                horaExistenteTermina = DateTime.ParseExact(termina, "H:m:s", null);
                                horaExistente = DateTime.ParseExact(existente, "H:m:s", null);

                                MessageBox.Show(horaExistente.ToString("H:m:s"));
                                MessageBox.Show(horaExistenteTermina.ToString("H:m:s"));

                                if ((horaIngresar.TimeOfDay > horaExistente.TimeOfDay && horaIngresar.TimeOfDay < horaExistenteTermina.TimeOfDay) && vv == "1")
                                {
                                    MessageBox.Show("Hay empalme en la hora de entrada, dia viernes");
                                    return;
                                }


                                if ((horaIngresar.TimeOfDay < horaExistente.TimeOfDay || horaIngresar.TimeOfDay == horaExistente.TimeOfDay) && vv == "1")
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

                                    else if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay == horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia jueves");
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
                                ss = row.Cells[10].Value.ToString();
                                existente = h;
                                horaExistenteTermina = DateTime.ParseExact(termina, "H:m:s", null);
                                horaExistente = DateTime.ParseExact(existente, "H:m:s", null);

                                MessageBox.Show(horaExistente.ToString("H:m:s"));
                                MessageBox.Show(horaExistenteTermina.ToString("H:m:s"));

                                if ((horaIngresar.TimeOfDay > horaExistente.TimeOfDay && horaIngresar.TimeOfDay < horaExistenteTermina.TimeOfDay) && ss == "1")
                                {
                                    MessageBox.Show("Hay empalme en la hora de entrada, dia sabado");
                                    return;
                                }


                                if ((horaIngresar.TimeOfDay < horaExistente.TimeOfDay || horaIngresar.TimeOfDay == horaExistente.TimeOfDay) && ss == "1")
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
                                    }

                                    else if (horaIngresarTermina.TimeOfDay > horaExistente.TimeOfDay && horaIngresarTermina.TimeOfDay == horaExistenteTermina.TimeOfDay)
                                    {
                                        MessageBox.Show("Hay empalme en la hora de salida, dia sabado");
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


                if (centinela == false)
                {
                    ingresarDatos();
                }
                else
                {

                    try
                    {
                        String query = string.Format("UPDATE `asistencia`.`salon` SET num_salon='" + salon.Text + "', materia='" + materia.Text + "', semestre='" + semestre.Text + "', horaFinal='" + hF.Text + ":" + minF.Text + ":00'," + " horaInicio='" + hE.Text + ":" + minE.Text + ":00'" + ", lunes='" + lun + "', martes='" + mar + "', miercoles='" + mie + "', jueves='" + jue + "', viernes='" + vie + "', sabado='" + sab + "' " + "WHERE num_salon='" + saltem + "' AND materia='" + mattem + "';");
                        MessageBox.Show(query);
                        MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                        MySqlCommandBuilder comando = new MySqlCommandBuilder(adaptador);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);

                        MessageBox.Show("¡Datos actualizados exitosamente!");

                        fill();

                        salon.Text = "";
                        materia.Text = "";
                        semestre.Text = "";
                        hF.Text = "";
                        minF.Text = "";
                        hE.Text = "";
                        minE.Text = "";
                        lunes.Checked = false;
                        martes.Checked = false;
                        miercoles.Checked = false;
                        jueves.Checked = false;
                        viernes.Checked = false;
                        sabado.Checked = false;
                        centinela = false;
                        button2.Visible = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error insertar datos" + ex.Message);
                        return;
                    }
                    return;


                }
                 
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            centinela = true;

            if (salon.Text == "" || materia.Text == "" || semestre.Text == "" || hE.Text == "" || minE.Text == "" || hF.Text == "" || minE.Text == "")
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








                        }
                        else
                        {
                            string texto = hE.Text + ":" + minE.Text + ":00";
                            Console.WriteLine(texto);
                            Console.WriteLine(horaeoriginal);
                            if (!(texto.Equals(horaeoriginal)))
                            {
                                checarEmpalme();
                            }

                            else
                            {
                                try
                                {
                                    String query = string.Format("UPDATE `asistencia`.`salon` SET num_salon='" + salon.Text + "', materia='" + materia.Text + "', semestre='" + semestre.Text + "', horaFinal='" + hF.Text + ":" + minF.Text + ":00'," + " horaInicio='" + hE.Text + ":" + minE.Text + ":00'" + ", lunes='" + lun + "', martes='" + mar + "', miercoles='" + mie + "', jueves='" + jue + "', viernes='" + vie + "', sabado='" + sab + "' " + "WHERE num_salon='" + saltem + "' AND materia='" + mattem + "';");
                                    MessageBox.Show(query);
                                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                                    MySqlCommandBuilder comando = new MySqlCommandBuilder(adaptador);
                                    DataTable dt = new DataTable();
                                    adaptador.Fill(dt);

                                    MessageBox.Show("¡Datos actualizados exitosamente!");

                                    fill();

                                    salon.Text = "";
                                    materia.Text = "";
                                    semestre.Text = "";
                                    hF.Text = "";
                                    minF.Text = "";
                                    hE.Text = "";
                                    minE.Text = "";
                                    lunes.Checked = false;
                                    martes.Checked = false;
                                    miercoles.Checked = false;
                                    jueves.Checked = false;
                                    viernes.Checked = false;
                                    sabado.Checked = false;
                                    centinela = false;
                                    button2.Visible = false;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("error insertar datos" + ex.Message);
                                    return;
                                }
                            }
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

        private void openNewForm()
        {

            Application.Run(new menu(mat));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public static DialogResult InputBox()
        {
            Form form = new Form();
            Label label = new Label();
  
            Button buttonBorrar = new Button();
            Button buttonAct = new Button();

 
            label.Text = "¿Desea borrar o actualizar el registro?";


            buttonBorrar.Text = "Borrar";
            buttonAct.Text = "Actualizar";
            buttonBorrar.DialogResult = DialogResult.OK;
            buttonAct.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            buttonBorrar.SetBounds(228, 72, 75, 23);
            buttonAct.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            buttonBorrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, buttonBorrar, buttonAct });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.AcceptButton = buttonBorrar;
            form.CancelButton = buttonAct;


            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }
    }
}
