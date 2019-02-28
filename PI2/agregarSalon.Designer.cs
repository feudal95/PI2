namespace PI2
{
    partial class agregarSalon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.salon = new System.Windows.Forms.TextBox();
            this.materia = new System.Windows.Forms.TextBox();
            this.semestre = new System.Windows.Forms.TextBox();
            this.hE = new System.Windows.Forms.TextBox();
            this.hF = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lunes = new System.Windows.Forms.CheckBox();
            this.martes = new System.Windows.Forms.CheckBox();
            this.miercoles = new System.Windows.Forms.CheckBox();
            this.jueves = new System.Windows.Forms.CheckBox();
            this.viernes = new System.Windows.Forms.CheckBox();
            this.sabado = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.minE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.minF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora que empieza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora que termina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Semestre";
            // 
            // salon
            // 
            this.salon.Location = new System.Drawing.Point(103, 94);
            this.salon.Name = "salon";
            this.salon.Size = new System.Drawing.Size(100, 20);
            this.salon.TabIndex = 5;
            // 
            // materia
            // 
            this.materia.Location = new System.Drawing.Point(103, 140);
            this.materia.Name = "materia";
            this.materia.Size = new System.Drawing.Size(100, 20);
            this.materia.TabIndex = 6;
            // 
            // semestre
            // 
            this.semestre.Location = new System.Drawing.Point(103, 182);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(100, 20);
            this.semestre.TabIndex = 7;
            // 
            // hE
            // 
            this.hE.Location = new System.Drawing.Point(147, 221);
            this.hE.Name = "hE";
            this.hE.Size = new System.Drawing.Size(24, 20);
            this.hE.TabIndex = 8;
            this.hE.TextChanged += new System.EventHandler(this.hE_TextChanged);
            this.hE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hE_KeyDown);
            this.hE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hE_KeyPress);
            // 
            // hF
            // 
            this.hF.Location = new System.Drawing.Point(334, 221);
            this.hF.Name = "hF";
            this.hF.Size = new System.Drawing.Size(24, 20);
            this.hF.TabIndex = 9;
            this.hF.TextChanged += new System.EventHandler(this.hF_TextChanged);
            this.hF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hF_KeyPress);
            this.hF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hF_MouseDown);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(596, 28);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(35, 13);
            this.usuario.TabIndex = 10;
            this.usuario.Text = "label6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lunes
            // 
            this.lunes.AutoSize = true;
            this.lunes.Location = new System.Drawing.Point(123, 284);
            this.lunes.Name = "lunes";
            this.lunes.Size = new System.Drawing.Size(32, 17);
            this.lunes.TabIndex = 12;
            this.lunes.Text = "L";
            this.lunes.UseVisualStyleBackColor = true;
            this.lunes.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // martes
            // 
            this.martes.AutoSize = true;
            this.martes.Location = new System.Drawing.Point(161, 284);
            this.martes.Name = "martes";
            this.martes.Size = new System.Drawing.Size(35, 17);
            this.martes.TabIndex = 13;
            this.martes.Text = "M";
            this.martes.UseVisualStyleBackColor = true;
            this.martes.CheckedChanged += new System.EventHandler(this.martes_CheckedChanged);
            // 
            // miercoles
            // 
            this.miercoles.AutoSize = true;
            this.miercoles.Location = new System.Drawing.Point(202, 284);
            this.miercoles.Name = "miercoles";
            this.miercoles.Size = new System.Drawing.Size(35, 17);
            this.miercoles.TabIndex = 14;
            this.miercoles.Text = "M";
            this.miercoles.UseVisualStyleBackColor = true;
            this.miercoles.CheckedChanged += new System.EventHandler(this.miercoles_CheckedChanged);
            // 
            // jueves
            // 
            this.jueves.AutoSize = true;
            this.jueves.Location = new System.Drawing.Point(243, 284);
            this.jueves.Name = "jueves";
            this.jueves.Size = new System.Drawing.Size(31, 17);
            this.jueves.TabIndex = 15;
            this.jueves.Text = "J";
            this.jueves.UseVisualStyleBackColor = true;
            this.jueves.CheckedChanged += new System.EventHandler(this.jueves_CheckedChanged);
            // 
            // viernes
            // 
            this.viernes.AutoSize = true;
            this.viernes.Location = new System.Drawing.Point(280, 284);
            this.viernes.Name = "viernes";
            this.viernes.Size = new System.Drawing.Size(33, 17);
            this.viernes.TabIndex = 16;
            this.viernes.Text = "V";
            this.viernes.UseVisualStyleBackColor = true;
            this.viernes.CheckedChanged += new System.EventHandler(this.viernes_CheckedChanged);
            // 
            // sabado
            // 
            this.sabado.AutoSize = true;
            this.sabado.Location = new System.Drawing.Point(319, 284);
            this.sabado.Name = "sabado";
            this.sabado.Size = new System.Drawing.Size(33, 17);
            this.sabado.TabIndex = 17;
            this.sabado.Text = "S";
            this.sabado.UseVisualStyleBackColor = true;
            this.sabado.CheckedChanged += new System.EventHandler(this.sabado_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Frecuencia";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // minE
            // 
            this.minE.Location = new System.Drawing.Point(187, 221);
            this.minE.Name = "minE";
            this.minE.Size = new System.Drawing.Size(24, 20);
            this.minE.TabIndex = 19;
            this.minE.TextChanged += new System.EventHandler(this.minE_TextChanged);
            this.minE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minE_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = ":";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = ":";
            // 
            // minF
            // 
            this.minF.Location = new System.Drawing.Point(371, 221);
            this.minF.Name = "minF";
            this.minF.Size = new System.Drawing.Size(24, 20);
            this.minF.TabIndex = 22;
            this.minF.TextChanged += new System.EventHandler(this.minF_TextChanged);
            this.minF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minF_KeyPress);
            this.minF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minF_MouseDown);
            // 
            // agregarSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sabado);
            this.Controls.Add(this.viernes);
            this.Controls.Add(this.jueves);
            this.Controls.Add(this.miercoles);
            this.Controls.Add(this.martes);
            this.Controls.Add(this.lunes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.hF);
            this.Controls.Add(this.hE);
            this.Controls.Add(this.semestre);
            this.Controls.Add(this.materia);
            this.Controls.Add(this.salon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "agregarSalon";
            this.Text = "agregarSalon";
            this.Load += new System.EventHandler(this.agregarSalon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox salon;
        private System.Windows.Forms.TextBox materia;
        private System.Windows.Forms.TextBox semestre;
        private System.Windows.Forms.TextBox hE;
        private System.Windows.Forms.TextBox hF;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox lunes;
        private System.Windows.Forms.CheckBox martes;
        private System.Windows.Forms.CheckBox miercoles;
        private System.Windows.Forms.CheckBox jueves;
        private System.Windows.Forms.CheckBox viernes;
        private System.Windows.Forms.CheckBox sabado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox minE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox minF;
    }
}