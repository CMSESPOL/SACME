namespace SACME
{
    partial class Form_Inicial
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
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditor_Usuario = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditor_Contrasenia = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraButton_Ingresar = new Infragistics.Win.Misc.UltraButton();
            this.ultraCheckEditor_PrimeraVez = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_Contrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditor_PrimeraVez)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Location = new System.Drawing.Point(50, 37);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel1.TabIndex = 0;
            this.ultraLabel1.Text = "Usuario:";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(50, 66);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel2.TabIndex = 1;
            this.ultraLabel2.Text = "Contraseña:";
            // 
            // ultraTextEditor_Usuario
            // 
            this.ultraTextEditor_Usuario.Location = new System.Drawing.Point(134, 37);
            this.ultraTextEditor_Usuario.Name = "ultraTextEditor_Usuario";
            this.ultraTextEditor_Usuario.Size = new System.Drawing.Size(155, 21);
            this.ultraTextEditor_Usuario.TabIndex = 2;
            // 
            // ultraTextEditor_Contrasenia
            // 
            this.ultraTextEditor_Contrasenia.Location = new System.Drawing.Point(134, 68);
            this.ultraTextEditor_Contrasenia.Name = "ultraTextEditor_Contrasenia";
            this.ultraTextEditor_Contrasenia.PasswordChar = '*';
            this.ultraTextEditor_Contrasenia.Size = new System.Drawing.Size(155, 21);
            this.ultraTextEditor_Contrasenia.TabIndex = 3;
            // 
            // ultraButton_Ingresar
            // 
            this.ultraButton_Ingresar.Location = new System.Drawing.Point(153, 104);
            this.ultraButton_Ingresar.Name = "ultraButton_Ingresar";
            this.ultraButton_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.ultraButton_Ingresar.TabIndex = 4;
            this.ultraButton_Ingresar.Text = "Ingresar";
            this.ultraButton_Ingresar.Click += new System.EventHandler(this.ultraButton_Ingresar_Click);
            // 
            // ultraCheckEditor_PrimeraVez
            // 
            this.ultraCheckEditor_PrimeraVez.Location = new System.Drawing.Point(83, 142);
            this.ultraCheckEditor_PrimeraVez.Name = "ultraCheckEditor_PrimeraVez";
            this.ultraCheckEditor_PrimeraVez.Size = new System.Drawing.Size(233, 20);
            this.ultraCheckEditor_PrimeraVez.TabIndex = 5;
            this.ultraCheckEditor_PrimeraVez.Text = "¿Resetear Contraseña? ... CHECK AQUI";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Location = new System.Drawing.Point(129, 158);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(160, 23);
            this.ultraLabel3.TabIndex = 6;
            this.ultraLabel3.Text = "Ingresa Credenciales ESPOL";
            // 
            // Form_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 190);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.ultraCheckEditor_PrimeraVez);
            this.Controls.Add(this.ultraButton_Ingresar);
            this.Controls.Add(this.ultraTextEditor_Contrasenia);
            this.Controls.Add(this.ultraTextEditor_Usuario);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraLabel1);
            this.Name = "Form_Inicial";
            this.Text = "Bienvenido a SACME";
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_Contrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditor_PrimeraVez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor_Usuario;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor_Contrasenia;
        private Infragistics.Win.Misc.UltraButton ultraButton_Ingresar;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditor_PrimeraVez;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
    }
}