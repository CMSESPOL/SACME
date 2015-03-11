namespace SACME
{
    partial class Form_Initial
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraButton_Ingresar = new Infragistics.Win.Misc.UltraButton();
            this.ultraTextEditor_Contrasenia = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditor_Usuario = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraCheckEditor_PrimeraVez = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_Contrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditor_PrimeraVez)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraPanel1
            // 
            appearance1.ImageBackground = global::SACME.Properties.Resources.fondoini;
            this.ultraPanel1.Appearance = appearance1;
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraButton_Ingresar);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraTextEditor_Contrasenia);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraTextEditor_Usuario);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraLabel3);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraCheckEditor_PrimeraVez);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraLabel2);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraLabel1);
            this.ultraPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraPanel1.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(377, 190);
            this.ultraPanel1.TabIndex = 7;
            // 
            // ultraButton_Ingresar
            // 
            this.ultraButton_Ingresar.Location = new System.Drawing.Point(165, 116);
            this.ultraButton_Ingresar.Name = "ultraButton_Ingresar";
            this.ultraButton_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.ultraButton_Ingresar.TabIndex = 8;
            this.ultraButton_Ingresar.Text = "Ingresar";
            this.ultraButton_Ingresar.Click += new System.EventHandler(this.ultraButton_Ingresar_Click);
            // 
            // ultraTextEditor_Contrasenia
            // 
            this.ultraTextEditor_Contrasenia.AcceptsTab = true;
            this.ultraTextEditor_Contrasenia.Location = new System.Drawing.Point(165, 78);
            this.ultraTextEditor_Contrasenia.Name = "ultraTextEditor_Contrasenia";
            this.ultraTextEditor_Contrasenia.PasswordChar = '*';
            this.ultraTextEditor_Contrasenia.Size = new System.Drawing.Size(135, 21);
            this.ultraTextEditor_Contrasenia.TabIndex = 7;
            // 
            // ultraTextEditor_Usuario
            // 
            this.ultraTextEditor_Usuario.AcceptsTab = true;
            this.ultraTextEditor_Usuario.Location = new System.Drawing.Point(165, 47);
            this.ultraTextEditor_Usuario.Name = "ultraTextEditor_Usuario";
            this.ultraTextEditor_Usuario.Size = new System.Drawing.Size(135, 21);
            this.ultraTextEditor_Usuario.TabIndex = 6;
            // 
            // ultraLabel3
            // 
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel3.Appearance = appearance2;
            this.ultraLabel3.Location = new System.Drawing.Point(119, 164);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(155, 23);
            this.ultraLabel3.TabIndex = 4;
            this.ultraLabel3.Text = "Ingresa Credenciales ESPOL";
            // 
            // ultraCheckEditor_PrimeraVez
            // 
            this.ultraCheckEditor_PrimeraVez.BackColor = System.Drawing.Color.Transparent;
            this.ultraCheckEditor_PrimeraVez.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCheckEditor_PrimeraVez.Location = new System.Drawing.Point(87, 149);
            this.ultraCheckEditor_PrimeraVez.Name = "ultraCheckEditor_PrimeraVez";
            this.ultraCheckEditor_PrimeraVez.Size = new System.Drawing.Size(231, 20);
            this.ultraCheckEditor_PrimeraVez.TabIndex = 5;
            this.ultraCheckEditor_PrimeraVez.TabStop = false;
            this.ultraCheckEditor_PrimeraVez.Text = "¿Resetear Contraseña? ... CHECK AQUI";
            // 
            // ultraLabel2
            // 
            appearance3.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel2.Appearance = appearance3;
            this.ultraLabel2.Location = new System.Drawing.Point(58, 76);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel2.TabIndex = 1;
            this.ultraLabel2.Text = "Contraseña:";
            // 
            // ultraLabel1
            // 
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel1.Appearance = appearance4;
            this.ultraLabel1.Location = new System.Drawing.Point(58, 47);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel1.TabIndex = 0;
            this.ultraLabel1.Text = "Usuario:";
            // 
            // Form_Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 190);
            this.Controls.Add(this.ultraPanel1);
            this.MaximizeBox = false;
            this.Name = "Form_Initial";
            this.Text = "Bienvenido a SACME";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Initial_FormClosing);
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ClientArea.PerformLayout();
            this.ultraPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_Contrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditor_PrimeraVez)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditor_PrimeraVez;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraButton ultraButton_Ingresar;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor_Contrasenia;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor_Usuario;
    }
}