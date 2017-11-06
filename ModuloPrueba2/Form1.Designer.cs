namespace ModuloPrueba2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Guardar = new System.Windows.Forms.Button();
            this.espasivo = new System.Windows.Forms.RadioButton();
            this.esactivo = new System.Windows.Forms.RadioButton();
            this.efpasivo = new System.Windows.Forms.RadioButton();
            this.efactivo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trcodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvtransacciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtidcuenta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnombrecuenta = new System.Windows.Forms.TextBox();
            this.dtptran = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransacciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(27, 359);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 80;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // espasivo
            // 
            this.espasivo.AutoSize = true;
            this.espasivo.Location = new System.Drawing.Point(172, 14);
            this.espasivo.Name = "espasivo";
            this.espasivo.Size = new System.Drawing.Size(57, 17);
            this.espasivo.TabIndex = 78;
            this.espasivo.TabStop = true;
            this.espasivo.Text = "Pasivo";
            this.espasivo.UseVisualStyleBackColor = true;
            this.espasivo.CheckedChanged += new System.EventHandler(this.espasivo_CheckedChanged);
            // 
            // esactivo
            // 
            this.esactivo.AutoSize = true;
            this.esactivo.Location = new System.Drawing.Point(110, 14);
            this.esactivo.Name = "esactivo";
            this.esactivo.Size = new System.Drawing.Size(55, 17);
            this.esactivo.TabIndex = 77;
            this.esactivo.TabStop = true;
            this.esactivo.Text = "Activo";
            this.esactivo.UseVisualStyleBackColor = true;
            this.esactivo.CheckedChanged += new System.EventHandler(this.esactivo_CheckedChanged);
            // 
            // efpasivo
            // 
            this.efpasivo.AutoSize = true;
            this.efpasivo.Location = new System.Drawing.Point(169, 12);
            this.efpasivo.Name = "efpasivo";
            this.efpasivo.Size = new System.Drawing.Size(57, 17);
            this.efpasivo.TabIndex = 76;
            this.efpasivo.TabStop = true;
            this.efpasivo.Text = "Pasivo";
            this.efpasivo.UseVisualStyleBackColor = true;
            this.efpasivo.CheckedChanged += new System.EventHandler(this.efpasivo_CheckedChanged);
            // 
            // efactivo
            // 
            this.efactivo.AutoSize = true;
            this.efactivo.Location = new System.Drawing.Point(108, 12);
            this.efactivo.Name = "efactivo";
            this.efactivo.Size = new System.Drawing.Size(55, 17);
            this.efactivo.TabIndex = 75;
            this.efactivo.TabStop = true;
            this.efactivo.Text = "Activo";
            this.efactivo.UseVisualStyleBackColor = true;
            this.efactivo.CheckedChanged += new System.EventHandler(this.efactivo_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "CTACódigo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "TREstatus:";
            // 
            // trnombre
            // 
            this.trnombre.Location = new System.Drawing.Point(120, 143);
            this.trnombre.Name = "trnombre";
            this.trnombre.Size = new System.Drawing.Size(109, 20);
            this.trnombre.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "TREfecto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "TRNombre:";
            // 
            // trcodigo
            // 
            this.trcodigo.Location = new System.Drawing.Point(120, 102);
            this.trcodigo.Name = "trcodigo";
            this.trcodigo.Size = new System.Drawing.Size(109, 20);
            this.trcodigo.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "TR Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Transacciones";
            // 
            // dgvtransacciones
            // 
            this.dgvtransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtransacciones.Location = new System.Drawing.Point(334, 90);
            this.dgvtransacciones.Name = "dgvtransacciones";
            this.dgvtransacciones.Size = new System.Drawing.Size(589, 224);
            this.dgvtransacciones.TabIndex = 66;
            this.dgvtransacciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtransacciones_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Mantenimiento Transacciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.efactivo);
            this.groupBox1.Controls.Add(this.efpasivo);
            this.groupBox1.Location = new System.Drawing.Point(16, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 35);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.esactivo);
            this.groupBox2.Controls.Add(this.espasivo);
            this.groupBox2.Location = new System.Drawing.Point(16, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 40);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            // 
            // txtidcuenta
            // 
            this.txtidcuenta.Location = new System.Drawing.Point(120, 298);
            this.txtidcuenta.Name = "txtidcuenta";
            this.txtidcuenta.Size = new System.Drawing.Size(100, 20);
            this.txtidcuenta.TabIndex = 84;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 26);
            this.button1.TabIndex = 85;
            this.button1.Text = "Elegir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnombrecuenta
            // 
            this.txtnombrecuenta.Enabled = false;
            this.txtnombrecuenta.Location = new System.Drawing.Point(120, 324);
            this.txtnombrecuenta.Name = "txtnombrecuenta";
            this.txtnombrecuenta.Size = new System.Drawing.Size(100, 20);
            this.txtnombrecuenta.TabIndex = 86;
            // 
            // dtptran
            // 
            this.dtptran.Location = new System.Drawing.Point(120, 262);
            this.dtptran.Name = "dtptran";
            this.dtptran.Size = new System.Drawing.Size(200, 20);
            this.dtptran.TabIndex = 87;
            this.dtptran.ValueChanged += new System.EventHandler(this.dtptran_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Fecha:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 89;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 404);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtptran);
            this.Controls.Add(this.txtnombrecuenta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtidcuenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trcodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvtransacciones);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransacciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.RadioButton espasivo;
        private System.Windows.Forms.RadioButton esactivo;
        private System.Windows.Forms.RadioButton efpasivo;
        private System.Windows.Forms.RadioButton efactivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox trnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox trcodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvtransacciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtidcuenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnombrecuenta;
        private System.Windows.Forms.DateTimePicker dtptran;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}

