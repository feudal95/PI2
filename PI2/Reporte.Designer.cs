namespace PI2
{
    partial class Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.welc = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.semes = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sabadoC = new System.Windows.Forms.CheckBox();
            this.lunesC = new System.Windows.Forms.CheckBox();
            this.martesC = new System.Windows.Forms.CheckBox();
            this.miercolesC = new System.Windows.Forms.CheckBox();
            this.juevesC = new System.Windows.Forms.CheckBox();
            this.viernesC = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(606, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 458);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.DataGridView1_DataSourceChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(338, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reportes";
            // 
            // welc
            // 
            this.welc.AutoSize = true;
            this.welc.BackColor = System.Drawing.Color.Transparent;
            this.welc.Font = new System.Drawing.Font("Montserrat", 20F);
            this.welc.ForeColor = System.Drawing.Color.White;
            this.welc.Location = new System.Drawing.Point(823, 31);
            this.welc.Name = "welc";
            this.welc.Size = new System.Drawing.Size(129, 33);
            this.welc.TabIndex = 2;
            this.welc.Text = "Nombre";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 27);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Montserrat", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(57, 202);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 27);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salon";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Materia";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Montserrat", 12F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(57, 276);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(231, 27);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 16F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat", 14F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(404, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 64);
            this.button2.TabIndex = 10;
            this.button2.Text = "Generar Reporte";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Montserrat", 16F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(57, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 44);
            this.button3.TabIndex = 11;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Font = new System.Drawing.Font("Montserrat", 16F);
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(228, 337);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(131, 27);
            this.start.TabIndex = 12;
            this.start.Text = "Hora Inicio";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.BackColor = System.Drawing.Color.Transparent;
            this.end.Font = new System.Drawing.Font("Montserrat", 16F);
            this.end.ForeColor = System.Drawing.Color.White;
            this.end.Location = new System.Drawing.Point(399, 337);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(162, 27);
            this.end.TabIndex = 13;
            this.end.Text = "Hora Termina";
            // 
            // semes
            // 
            this.semes.AutoSize = true;
            this.semes.BackColor = System.Drawing.Color.Transparent;
            this.semes.Font = new System.Drawing.Font("Montserrat", 16F);
            this.semes.ForeColor = System.Drawing.Color.White;
            this.semes.Location = new System.Drawing.Point(52, 337);
            this.semes.Name = "semes";
            this.semes.Size = new System.Drawing.Size(119, 27);
            this.semes.TabIndex = 14;
            this.semes.Text = "Semestre";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Indigo;
            this.groupBox1.Controls.Add(this.sabadoC);
            this.groupBox1.Controls.Add(this.lunesC);
            this.groupBox1.Controls.Add(this.martesC);
            this.groupBox1.Controls.Add(this.miercolesC);
            this.groupBox1.Controls.Add(this.juevesC);
            this.groupBox1.Controls.Add(this.viernesC);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(55, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 48);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frecuencia";
            // 
            // sabadoC
            // 
            this.sabadoC.AutoSize = true;
            this.sabadoC.Enabled = false;
            this.sabadoC.Location = new System.Drawing.Point(207, 19);
            this.sabadoC.Name = "sabadoC";
            this.sabadoC.Size = new System.Drawing.Size(38, 23);
            this.sabadoC.TabIndex = 17;
            this.sabadoC.Text = "S";
            this.sabadoC.UseVisualStyleBackColor = true;
            // 
            // lunesC
            // 
            this.lunesC.AutoSize = true;
            this.lunesC.Enabled = false;
            this.lunesC.Location = new System.Drawing.Point(11, 19);
            this.lunesC.Name = "lunesC";
            this.lunesC.Size = new System.Drawing.Size(37, 23);
            this.lunesC.TabIndex = 12;
            this.lunesC.Text = "L";
            this.lunesC.UseVisualStyleBackColor = true;
            // 
            // martesC
            // 
            this.martesC.AutoSize = true;
            this.martesC.Enabled = false;
            this.martesC.Location = new System.Drawing.Point(49, 19);
            this.martesC.Name = "martesC";
            this.martesC.Size = new System.Drawing.Size(44, 23);
            this.martesC.TabIndex = 13;
            this.martesC.Text = "M";
            this.martesC.UseVisualStyleBackColor = true;
            // 
            // miercolesC
            // 
            this.miercolesC.AutoSize = true;
            this.miercolesC.Enabled = false;
            this.miercolesC.Location = new System.Drawing.Point(90, 19);
            this.miercolesC.Name = "miercolesC";
            this.miercolesC.Size = new System.Drawing.Size(44, 23);
            this.miercolesC.TabIndex = 14;
            this.miercolesC.Text = "M";
            this.miercolesC.UseVisualStyleBackColor = true;
            // 
            // juevesC
            // 
            this.juevesC.AutoSize = true;
            this.juevesC.Enabled = false;
            this.juevesC.Location = new System.Drawing.Point(131, 19);
            this.juevesC.Name = "juevesC";
            this.juevesC.Size = new System.Drawing.Size(37, 23);
            this.juevesC.TabIndex = 15;
            this.juevesC.Text = "J";
            this.juevesC.UseVisualStyleBackColor = true;
            // 
            // viernesC
            // 
            this.viernesC.AutoSize = true;
            this.viernesC.Enabled = false;
            this.viernesC.Location = new System.Drawing.Point(168, 19);
            this.viernesC.Name = "viernesC";
            this.viernesC.Size = new System.Drawing.Size(39, 23);
            this.viernesC.TabIndex = 16;
            this.viernesC.Text = "V";
            this.viernesC.UseVisualStyleBackColor = true;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI2.Properties.Resources.graficoback12;
            this.ClientSize = new System.Drawing.Size(1180, 572);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.semes);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.welc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Label semes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox sabadoC;
        private System.Windows.Forms.CheckBox lunesC;
        private System.Windows.Forms.CheckBox martesC;
        private System.Windows.Forms.CheckBox miercolesC;
        private System.Windows.Forms.CheckBox juevesC;
        private System.Windows.Forms.CheckBox viernesC;
    }
}