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
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=asistencia;SslMode=none");
        public agregarSalon(string welcm)
        {
            mat = welcm;
            InitializeComponent();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT nombreDocente from docentes WHERE matricula = '" + welcm + "';", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string welcom = dt.Rows[0][0].ToString();
            usuario.Text = "Docente: " + welcom;
 
        }

        private void agregarSalon_Load(object sender, EventArgs e)
        {

        }
    }
}
