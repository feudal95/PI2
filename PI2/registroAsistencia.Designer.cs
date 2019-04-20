namespace PI2
{
    partial class registroAsistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRFID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.materia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.salon = new System.Windows.Forms.Label();
            this.horaini = new System.Windows.Forms.Label();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.horaFina = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Matrícula";
            // 
            // textBoxRFID
            // 
            this.textBoxRFID.Location = new System.Drawing.Point(129, 83);
            this.textBoxRFID.Name = "textBoxRFID";
            this.textBoxRFID.ReadOnly = true;
            this.textBoxRFID.Size = new System.Drawing.Size(121, 20);
            this.textBoxRFID.TabIndex = 8;
            this.textBoxRFID.TextChanged += new System.EventHandler(this.textBoxRFID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "RFID";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkMagenta;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(46, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // materia
            // 
            this.materia.AutoSize = true;
            this.materia.BackColor = System.Drawing.Color.Transparent;
            this.materia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materia.ForeColor = System.Drawing.Color.White;
            this.materia.Location = new System.Drawing.Point(360, 67);
            this.materia.Name = "materia";
            this.materia.Size = new System.Drawing.Size(71, 24);
            this.materia.TabIndex = 14;
            this.materia.Text = "Matería";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(41, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 39);
            this.label6.TabIndex = 20;
            this.label6.Text = "Toma de asistencia";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkMagenta;
            this.pictureBox3.BackgroundImage = global::PI2.Properties.Resources.quitar1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(134, 269);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 36);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // salon
            // 
            this.salon.AutoSize = true;
            this.salon.BackColor = System.Drawing.Color.Transparent;
            this.salon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salon.ForeColor = System.Drawing.Color.White;
            this.salon.Location = new System.Drawing.Point(360, 106);
            this.salon.Name = "salon";
            this.salon.Size = new System.Drawing.Size(58, 24);
            this.salon.TabIndex = 5;
            this.salon.Text = "Salon";
            // 
            // horaini
            // 
            this.horaini.AutoSize = true;
            this.horaini.BackColor = System.Drawing.Color.Transparent;
            this.horaini.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaini.ForeColor = System.Drawing.Color.White;
            this.horaini.Location = new System.Drawing.Point(360, 142);
            this.horaini.Name = "horaini";
            this.horaini.Size = new System.Drawing.Size(137, 24);
            this.horaini.TabIndex = 5;
            this.horaini.Text = "Hora que inicia";
            // 
            // textMatricula
            // 
            this.textMatricula.Location = new System.Drawing.Point(129, 162);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.ReadOnly = true;
            this.textMatricula.Size = new System.Drawing.Size(121, 20);
            this.textMatricula.TabIndex = 13;
            this.textMatricula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(129, 124);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(121, 20);
            this.textNombre.TabIndex = 13;
            this.textNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // horaFina
            // 
            this.horaFina.AutoSize = true;
            this.horaFina.BackColor = System.Drawing.Color.Transparent;
            this.horaFina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaFina.ForeColor = System.Drawing.Color.White;
            this.horaFina.Location = new System.Drawing.Point(360, 186);
            this.horaFina.Name = "horaFina";
            this.horaFina.Size = new System.Drawing.Size(150, 24);
            this.horaFina.TabIndex = 23;
            this.horaFina.Text = "Hora que finaliza";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.BackColor = System.Drawing.Color.Transparent;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.SystemColors.Menu;
            this.resultado.Location = new System.Drawing.Point(12, 204);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 25);
            this.resultado.TabIndex = 24;
            // 
            // AgregarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI2.Properties.Resources.graficoback12;
            this.ClientSize = new System.Drawing.Size(633, 317);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.horaFina);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.materia);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textMatricula);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRFID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.horaini);
            this.Controls.Add(this.salon);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarAlumnos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.asignarAccesos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRFID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label materia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label salon;
        private System.Windows.Forms.Label horaini;
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label horaFina;
        private System.Windows.Forms.Label resultado;
    }
}