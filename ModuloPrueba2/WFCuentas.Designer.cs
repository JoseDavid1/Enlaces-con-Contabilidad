namespace ModuloPrueba2
{
    partial class WFCuentas
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
            this.dgvcuentas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcuentas
            // 
            this.dgvcuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcuentas.Location = new System.Drawing.Point(23, 12);
            this.dgvcuentas.Name = "dgvcuentas";
            this.dgvcuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcuentas.Size = new System.Drawing.Size(406, 182);
            this.dgvcuentas.TabIndex = 0;
            this.dgvcuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcuentas_CellContentClick);
            this.dgvcuentas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcuentas_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WFCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 249);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvcuentas);
            this.Name = "WFCuentas";
            this.Text = "WFCuentas";
            this.Load += new System.EventHandler(this.WFCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcuentas;
        private System.Windows.Forms.Button button1;
    }
}