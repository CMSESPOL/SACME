namespace SACME
{
    partial class Form_academicControl
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
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraPanelAcademicControl = new Infragistics.Win.Misc.UltraPanel();
            this.ultraPanel2 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraButtonConsulta = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonRegistro = new Infragistics.Win.Misc.UltraButton();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            this.ultraPanelAcademicControl.SuspendLayout();
            this.ultraPanel2.ClientArea.SuspendLayout();
            this.ultraPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraPanel1
            // 
            this.ultraPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.ImageBackground = global::SACME.Properties.Resources.fondonew;
            this.ultraPanel1.Appearance = appearance1;
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraPanelAcademicControl);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraPanel2);
            this.ultraPanel1.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(932, 493);
            this.ultraPanel1.TabIndex = 1;
            // 
            // ultraPanelAcademicControl
            // 
            this.ultraPanelAcademicControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.ultraPanelAcademicControl.Appearance = appearance2;
            this.ultraPanelAcademicControl.Location = new System.Drawing.Point(0, 33);
            this.ultraPanelAcademicControl.Name = "ultraPanelAcademicControl";
            this.ultraPanelAcademicControl.Size = new System.Drawing.Size(931, 461);
            this.ultraPanelAcademicControl.TabIndex = 3;
            // 
            // ultraPanel2
            // 
            appearance3.BackColor = System.Drawing.Color.Transparent;
            this.ultraPanel2.Appearance = appearance3;
            // 
            // ultraPanel2.ClientArea
            // 
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraButtonConsulta);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraButtonRegistro);
            this.ultraPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraPanel2.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel2.Name = "ultraPanel2";
            this.ultraPanel2.Size = new System.Drawing.Size(932, 36);
            this.ultraPanel2.TabIndex = 2;
            // 
            // ultraButtonConsulta
            // 
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraButtonConsulta.Appearance = appearance4;
            this.ultraButtonConsulta.Location = new System.Drawing.Point(467, 4);
            this.ultraButtonConsulta.Name = "ultraButtonConsulta";
            this.ultraButtonConsulta.Size = new System.Drawing.Size(461, 29);
            this.ultraButtonConsulta.TabIndex = 1;
            this.ultraButtonConsulta.Text = "Consulta";
            this.ultraButtonConsulta.Click += new System.EventHandler(this.ultraButtonConsulta_Click);
            // 
            // ultraButtonRegistro
            // 
            appearance5.BackColor = System.Drawing.Color.Transparent;
            this.ultraButtonRegistro.Appearance = appearance5;
            this.ultraButtonRegistro.Location = new System.Drawing.Point(4, 4);
            this.ultraButtonRegistro.Name = "ultraButtonRegistro";
            this.ultraButtonRegistro.Size = new System.Drawing.Size(468, 29);
            this.ultraButtonRegistro.TabIndex = 0;
            this.ultraButtonRegistro.Text = "Registro";
            this.ultraButtonRegistro.Click += new System.EventHandler(this.ultraButtonRegistro_Click);
            // 
            // Form_academicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 493);
            this.Controls.Add(this.ultraPanel1);
            this.Name = "Form_academicControl";
            this.Text = "Form_academicControl";
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            this.ultraPanelAcademicControl.ResumeLayout(false);
            this.ultraPanel2.ClientArea.ResumeLayout(false);
            this.ultraPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private Infragistics.Win.Misc.UltraPanel ultraPanelAcademicControl;
        private Infragistics.Win.Misc.UltraPanel ultraPanel2;
        private Infragistics.Win.Misc.UltraButton ultraButtonConsulta;
        private Infragistics.Win.Misc.UltraButton ultraButtonRegistro;

    }
}