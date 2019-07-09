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
    public partial class ModAlumno : Form
    {
        Thread th;
        string mat = "";
        string docenteID = "";
        string idalumno = "";
        string saltem = "";
        string mattem = "";
        Boolean centinela = false;
       


        MySqlConnection conn = new MySqlConnection("server=localhost;database=asistencia;uid=root;pwd=");
        public ModAlumno(string welcm)
        {
            mat = welcm;
            InitializeComponent();
            button2.Enabled = false;
            button4.Enabled = false;
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT nombreDocente, id from docentes WHERE matricula = '" + welcm + "';", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string welcom = dt.Rows[0][0].ToString();
            docenteID = dt.Rows[0][1].ToString();
            usuario.Text = "Docente: " + welcom;
            
 
        }

        

        private void ModAlumno_Load(object sender, EventArgs e)
        {
            //
            fill();
        }


        void fill()
        {
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT * FROM asistencia.alumnos;", conn);

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






        private void test()
        {
            MessageBox.Show("LLEGASTE");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

      

        private void label7_Click(object sender, EventArgs e)
        {

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




        private void button2_Click(object sender, EventArgs e)
        {
         
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
                dataGridView1.CurrentRow.Selected = true;
                matricula.Text = dataGridView1.Rows[e.RowIndex].Cells["matricula"].FormattedValue.ToString();
                saltem = matricula.Text;
                nombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombreAlumno"].FormattedValue.ToString();
                mattem = nombre.Text;
                idalumno = dataGridView1.Rows[e.RowIndex].Cells["idalumnos"].FormattedValue.ToString();






                if (agregarSalon.InputBox() == DialogResult.OK)
                {
                    try
                    {
                       String query = string.Format("DELETE FROM `asistencia`.`alumnos` WHERE idalumnos='" + idalumno + "';");
                        MessageBox.Show(query);
                        MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                        MySqlCommandBuilder comando = new MySqlCommandBuilder(adaptador);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);

                        MessageBox.Show("¡Datos borrados exitosamente!");

                        fill();

                        matricula.Text = "";
                        nombre.Text = "";

                        centinela = false;
                        button2.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error al borrar datos" + ex.Message);
                        return;
                    }
                }
                else
                {
                    button4.Enabled = true;
                    button2.Enabled = true;
                }
                    
            }
            
        }

     

        private void button2_Click_1(object sender, EventArgs e)
        {
            centinela = true;

            if (matricula.Text == "" || nombre.Text == "")
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {


                try
                {
                    String query = string.Format("UPDATE `asistencia`.`alumnos` SET matricula='"+matricula.Text+ "' , nombreAlumno='"+nombre.Text+" 'WHERE idalumnos='" + idalumno + "';");
                    MessageBox.Show(query);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                    MySqlCommandBuilder comando = new MySqlCommandBuilder(adaptador);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    MessageBox.Show("¡Datos actualizados exitosamente!");

                    fill();

                    matricula.Text = "";
                    nombre.Text = "";
                    centinela = false;
                    button2.Enabled = false;
                    button4.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error insertar datos" + ex.Message);
                    return;
                }
                return;


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

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button4.Enabled = false;
        }
    }
}
