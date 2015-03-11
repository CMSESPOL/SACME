namespace SACME
{
    partial class Form_usersPassword
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
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditor_Contrasenia = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditor_ConfirmContrasenia = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraButton_Cancelar = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton_Guardar = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_Contrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_ConfirmContrasenia)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraPanel1
            // 
            appearance1.ImageBackground = global::SACME.Properties.Resources.fondopass;
            this.ultraPanel1.Appearance = appearance1;
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraLabel4);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraLabel3);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraLabel2);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraLabel1);
            this.ultraPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraPanel1.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(405, 311);
            this.ultraPanel1.TabIndex = 10;
            // 
            // ultraLabel1
            // 
            appearance5.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel1.Appearance = appearance5;
            this.ultraLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(130, 33);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(226, 70);
            this.ultraLabel1.TabIndex = 0;
            // 
            // ultraLabel2
            // 
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel2.Appearance = appearance4;
            this.ultraLabel2.Location = new System.Drawing.Point(74, 120);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(253, 23);
            this.ultraLabel2.TabIndex = 1;
            this.ultraLabel2.Text = "Antes de continuar, por favor setea tu contraseña";
            // 
            // ultraTextEditor_Contrasenia
            // 
            this.ultraTextEditor_Contrasenia.Location = new System.Drawing.Point(224, 151);
            this.ultraTextEditor_Contrasenia.Name = "ultraTextEditor_Contrasenia";
            this.ultraTextEditor_Contrasenia.PasswordChar = '*';
            this.ultraTextEditor_Contrasenia.Size = new System.Drawing.Size(100, 21);
            this.ultraTextEditor_Contrasenia.TabIndex = 6;
            // 
            // ultraTextEditor_ConfirmContrasenia
            // 
            this.ultraTextEditor_ConfirmContrasenia.Location = new System.Drawing.Point(224, 195);
            this.ultraTextEditor_ConfirmContrasenia.Name = "ultraTextEditor_ConfirmContrasenia";
            this.ultraTextEditor_ConfirmContrasenia.PasswordChar = '*';
            this.ultraTextEditor_ConfirmContrasenia.Size = new System.Drawing.Size(100, 21);
            this.ultraTextEditor_ConfirmContrasenia.TabIndex = 7;
            // 
            // ultraButton_Cancelar
            // 
            this.ultraButton_Cancelar.Location = new System.Drawing.Point(213, 251);
            this.ultraButton_Cancelar.Name = "ultraButton_Cancelar";
            this.ultraButton_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.ultraButton_Cancelar.TabIndex = 9;
            this.ultraButton_Cancelar.Text = "Cancelar";
            this.ultraButton_Cancelar.Click += new System.EventHandler(this.ultraButton_Cancelar_Click);
            // 
            // ultraButton_Guardar
            // 
            this.ultraButton_Guardar.Location = new System.Drawing.Point(105, 251);
            this.ultraButton_Guardar.Name = "ultraButton_Guardar";
            this.ultraButton_Guardar.Size = new System.Drawing.Size(75, 23);
            this.ultraButton_Guardar.TabIndex = 8;
            this.ultraButton_Guardar.Text = "Aceptar";
            this.ultraButton_Guardar.Click += new System.EventHandler(this.ultraButton_Guardar_Click);
            // 
            // ultraLabel3
            // 
            appearance3.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel3.Appearance = appearance3;
            this.ultraLabel3.Location = new System.Drawing.Point(83, 155);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel3.TabIndex = 2;
            this.ultraLabel3.Text = "Contraseña:";
            // 
            // ultraLabel4
            // 
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel4.Appearance = appearance2;
            this.ultraLabel4.Location = new System.Drawing.Point(83, 198);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(122, 23);
            this.ultraLabel4.TabIndex = 3;
            this.ultraLabel4.Text = "Confirmar Contraseña:";
            // 
            // Form_usersPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 311);
            this.ControlBox = false;
            this.Controls.Add(this.ultraButton_Cancelar);
            this.Controls.Add(this.ultraButton_Guardar);
            this.Controls.Add(this.ultraTextEditor_ConfirmContrasenia);
            this.Controls.Add(this.ultraTextEditor_Contrasenia);
            this.Controls.Add(this.ultraPanel1);
            this.MaximizeBox = false;
            this.Name = "Form_usersPassword";
            this.Text = "Form_usersPassword";
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_Contrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_ConfirmContrasenia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor_Contrasenia;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor_ConfirmContrasenia;
        private Infragistics.Win.Misc.UltraButton ultraButton_Cancelar;
        private Infragistics.Win.Misc.UltraButton ultraButton_Guardar;
    }
}