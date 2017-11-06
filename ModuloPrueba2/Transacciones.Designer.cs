namespace ModuloPrueba2
{
    partial class Transacciones
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
            this.dgvtransacciones = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtransacciones
            // 
            this.dgvtransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtransacciones.Location = new System.Drawing.Point(12, 22);
            this.dgvtransacciones.Name = "dgvtransacciones";
            this.dgvtransacciones.Size = new System.Drawing.Size(781, 290);
            this.dgvtransacciones.TabIndex = 0;
            this.dgvtransacciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvtransacciones);
            this.Name = "Transacciones";
            this.Text = "Transacciones";
            this.Load += new System.EventHandler(this.Transacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransacciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtransacciones;
        private System.Windows.Forms.Button button1;
    }
}