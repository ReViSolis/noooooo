namespace noooooo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Definición de los controles
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBTempC;
        private System.Windows.Forms.TextBox TBTempF;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTemperaturaC;
        private System.Windows.Forms.Label lblTemperaturaF;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox TBDate;
        private System.Windows.Forms.Label lblLEDStatus;
        private System.Windows.Forms.CheckBox checkBoxLED;

        // Función de disposición de los componentes
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Método de inicialización del formulario y los controles
        private void InitializeComponent()
        {
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBTempC = new System.Windows.Forms.TextBox();
            this.TBTempF = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTemperaturaC = new System.Windows.Forms.Label();
            this.lblTemperaturaF = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.TBDate = new System.Windows.Forms.TextBox();
            this.lblLEDStatus = new System.Windows.Forms.Label();
            this.checkBoxLED = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(81, 121);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(100, 20);
            this.TBUsuario.TabIndex = 0;
            this.TBUsuario.TextChanged += new System.EventHandler(this.TBUsuario_TextChanged);
            // 
            // TBTempC
            // 
            this.TBTempC.Location = new System.Drawing.Point(365, 122);
            this.TBTempC.Name = "TBTempC";
            this.TBTempC.Size = new System.Drawing.Size(100, 20);
            this.TBTempC.TabIndex = 1;
            // 
            // TBTempF
            // 
            this.TBTempF.Location = new System.Drawing.Point(365, 159);
            this.TBTempF.Name = "TBTempF";
            this.TBTempF.Size = new System.Drawing.Size(100, 20);
            this.TBTempF.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(162, 241);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(229, 68);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTemperaturaC
            // 
            this.lblTemperaturaC.AutoSize = true;
            this.lblTemperaturaC.Location = new System.Drawing.Point(267, 122);
            this.lblTemperaturaC.Name = "lblTemperaturaC";
            this.lblTemperaturaC.Size = new System.Drawing.Size(84, 13);
            this.lblTemperaturaC.TabIndex = 4;
            this.lblTemperaturaC.Text = "Temperatura C°:";
            // 
            // lblTemperaturaF
            // 
            this.lblTemperaturaF.AutoSize = true;
            this.lblTemperaturaF.Location = new System.Drawing.Point(267, 162);
            this.lblTemperaturaF.Name = "lblTemperaturaF";
            this.lblTemperaturaF.Size = new System.Drawing.Size(83, 13);
            this.lblTemperaturaF.TabIndex = 5;
            this.lblTemperaturaF.Text = "Temperatura F°:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 121);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario:";
            // 
            // TBDate
            // 
            this.TBDate.Location = new System.Drawing.Point(81, 152);
            this.TBDate.Name = "TBDate";
            this.TBDate.Size = new System.Drawing.Size(100, 20);
            this.TBDate.TabIndex = 7;
            // 
            // lblLEDStatus
            // 
            this.lblLEDStatus.AutoSize = true;
            this.lblLEDStatus.Location = new System.Drawing.Point(54, 241);
            this.lblLEDStatus.Name = "lblLEDStatus";
            this.lblLEDStatus.Size = new System.Drawing.Size(62, 13);
            this.lblLEDStatus.TabIndex = 8;
            this.lblLEDStatus.Text = "Apaga LED";
            // 
            // checkBoxLED
            // 
            this.checkBoxLED.AutoSize = true;
            this.checkBoxLED.Location = new System.Drawing.Point(81, 282);
            this.checkBoxLED.Name = "checkBoxLED";
            this.checkBoxLED.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLED.TabIndex = 9;
            this.checkBoxLED.UseVisualStyleBackColor = true;
            this.checkBoxLED.CheckedChanged += new System.EventHandler(this.checkBoxLED_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(960, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxLED);
            this.Controls.Add(this.lblLEDStatus);
            this.Controls.Add(this.TBDate);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTemperaturaF);
            this.Controls.Add(this.lblTemperaturaC);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.TBTempF);
            this.Controls.Add(this.TBTempC);
            this.Controls.Add(this.TBUsuario);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}

