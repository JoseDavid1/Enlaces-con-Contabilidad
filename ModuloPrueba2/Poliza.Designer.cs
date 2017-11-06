namespace ModuloPrueba2
{
    partial class Poliza
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
            this.Guardar = new System.Windows.Forms.Button();
            this.fechapoliza = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.concepto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fechafinal = new System.Windows.Forms.DateTimePicker();
            this.fechainicial = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.periodo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(397, 71);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 60;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // fechapoliza
            // 
            this.fechapoliza.Location = new System.Drawing.Point(120, 251);
            this.fechapoliza.Name = "fechapoliza";
            this.fechapoliza.Size = new System.Drawing.Size(200, 20);
            this.fechapoliza.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Fecha de Póliza:";
            // 
            // concepto
            // 
            this.concepto.Location = new System.Drawing.Point(120, 208);
            this.concepto.Name = "concepto";
            this.concepto.Size = new System.Drawing.Size(109, 20);
            this.concepto.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Concepto:";
            // 
            // fechafinal
            // 
            this.fechafinal.Location = new System.Drawing.Point(120, 161);
            this.fechafinal.Name = "fechafinal";
            this.fechafinal.Size = new System.Drawing.Size(200, 20);
            this.fechafinal.TabIndex = 55;
            // 
            // fechainicial
            // 
            this.fechainicial.Location = new System.Drawing.Point(120, 117);
            this.fechainicial.Name = "fechainicial";
            this.fechainicial.Size = new System.Drawing.Size(200, 20);
            this.fechainicial.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Fecha Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Fecha Inicial:";
            // 
            // periodo
            // 
            this.periodo.Location = new System.Drawing.Point(120, 71);
            this.periodo.Name = "periodo";
            this.periodo.Size = new System.Drawing.Size(109, 20);
            this.periodo.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Periodo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Traslado de Inventario a Póliza";
            // 
            // Poliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 314);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.fechapoliza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.concepto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechafinal);
            this.Controls.Add(this.fechainicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.periodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Poliza";
            this.Text = "Poliza";
            this.Load += new System.EventHandler(this.Poliza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.DateTimePicker fechapoliza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox concepto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fechafinal;
        private System.Windows.Forms.DateTimePicker fechainicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox periodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}