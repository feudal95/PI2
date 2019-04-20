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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reportes";
            // 
            // welc
            // 
            this.welc.AutoSize = true;
            this.welc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welc.Location = new System.Drawing.Point(877, 42);
            this.welc.Name = "welc";
            this.welc.Size = new System.Drawing.Size(81, 25);
            this.welc.TabIndex = 2;
            this.welc.Text = "Nombre";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(55, 205);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salon";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Materia";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(55, 276);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(231, 21);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Generar Reporte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 467);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(228, 337);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(58, 13);
            this.start.TabIndex = 12;
            this.start.Text = "Hora Inicio";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(399, 337);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(71, 13);
            this.end.TabIndex = 13;
            this.end.Text = "Hora Termina";
            // 
            // semes
            // 
            this.semes.AutoSize = true;
            this.semes.Location = new System.Drawing.Point(52, 337);
            this.semes.Name = "semes";
            this.semes.Size = new System.Drawing.Size(51, 13);
            this.semes.TabIndex = 14;
            this.semes.Text = "Semestre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sabadoC);
            this.groupBox1.Controls.Add(this.lunesC);
            this.groupBox1.Controls.Add(this.martesC);
            this.groupBox1.Controls.Add(this.miercolesC);
            this.groupBox1.Controls.Add(this.juevesC);
            this.groupBox1.Controls.Add(this.viernesC);
            this.groupBox1.Location = new System.Drawing.Point(55, 389);
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
            this.sabadoC.Size = new System.Drawing.Size(33, 17);
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
            this.lunesC.Size = new System.Drawing.Size(32, 17);
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
            this.martesC.Size = new System.Drawing.Size(35, 17);
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
            this.miercolesC.Size = new System.Drawing.Size(35, 17);
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
            this.juevesC.Size = new System.Drawing.Size(31, 17);
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
            this.viernesC.Size = new System.Drawing.Size(33, 17);
            this.viernesC.TabIndex = 16;
            this.viernesC.Text = "V";
            this.viernesC.UseVisualStyleBackColor = true;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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