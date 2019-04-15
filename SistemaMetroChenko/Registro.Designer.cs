namespace SistemaMetroChenko
{
    partial class Registro
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.MaskedTextBox();
            this.txt_uid = new System.Windows.Forms.MaskedTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUID = new System.Windows.Forms.Label();
            this.buttonArduino = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txt_documento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(644, 384);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(67, 78);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(128, 57);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(534, 78);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // txt_uid
            // 
            this.txt_uid.Location = new System.Drawing.Point(534, 129);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(100, 20);
            this.txt_uid.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(489, 85);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Nombre";
            // 
            // labelUID
            // 
            this.labelUID.AutoSize = true;
            this.labelUID.Location = new System.Drawing.Point(502, 136);
            this.labelUID.Name = "labelUID";
            this.labelUID.Size = new System.Drawing.Size(26, 13);
            this.labelUID.TabIndex = 6;
            this.labelUID.Text = "UID";
            // 
            // buttonArduino
            // 
            this.buttonArduino.Location = new System.Drawing.Point(146, 294);
            this.buttonArduino.Name = "buttonArduino";
            this.buttonArduino.Size = new System.Drawing.Size(75, 23);
            this.buttonArduino.TabIndex = 9;
            this.buttonArduino.Text = "Lector RFID";
            this.buttonArduino.UseVisualStyleBackColor = true;
            this.buttonArduino.Click += new System.EventHandler(this.ButtonArduino_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(534, 105);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(100, 20);
            this.txt_documento.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "documento";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.buttonArduino);
            this.Controls.Add(this.labelUID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txt_uid);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonExit);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.MaskedTextBox txt_nombre;
        private System.Windows.Forms.MaskedTextBox txt_uid;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUID;
        private System.Windows.Forms.Button buttonArduino;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MaskedTextBox txt_documento;
        private System.Windows.Forms.Label label1;
    }
}