namespace SistemaMetroChenko
{
    partial class Principal
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
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonRecharge = new System.Windows.Forms.Button();
            this.buttonDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(349, 147);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(75, 23);
            this.buttonReg.TabIndex = 0;
            this.buttonReg.Text = "Registrar";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.ButtonReg_Click);
            // 
            // buttonRecharge
            // 
            this.buttonRecharge.Location = new System.Drawing.Point(349, 187);
            this.buttonRecharge.Name = "buttonRecharge";
            this.buttonRecharge.Size = new System.Drawing.Size(75, 23);
            this.buttonRecharge.TabIndex = 1;
            this.buttonRecharge.Text = "Recargar";
            this.buttonRecharge.UseVisualStyleBackColor = true;
            this.buttonRecharge.Click += new System.EventHandler(this.ButtonRecharge_Click);
            // 
            // buttonDB
            // 
            this.buttonDB.Location = new System.Drawing.Point(349, 228);
            this.buttonDB.Name = "buttonDB";
            this.buttonDB.Size = new System.Drawing.Size(75, 23);
            this.buttonDB.TabIndex = 2;
            this.buttonDB.Text = "Conectarse";
            this.buttonDB.UseVisualStyleBackColor = true;
            this.buttonDB.Click += new System.EventHandler(this.ButtonDB_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDB);
            this.Controls.Add(this.buttonRecharge);
            this.Controls.Add(this.buttonReg);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonRecharge;
        private System.Windows.Forms.Button buttonDB;
    }
}

