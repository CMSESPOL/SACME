namespace SACME
{
    partial class Form_main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            this.ultraPanel_main = new Infragistics.Win.Misc.UltraPanel();
            this.ultraPanel_Top = new Infragistics.Win.Misc.UltraPanel();
            this.ultraLabel_Perfil = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel_Eventos = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel_AcercaDe = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel_Reportes = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel_Ramas = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel_ControlAcademico = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel_Usuario = new Infragistics.Win.Misc.UltraLabel();
            this.ultraSplitter1 = new Infragistics.Win.Misc.UltraSplitter();
            this.ultraToolTipManager1 = new Infragistics.Win.UltraWinToolTip.UltraToolTipManager(this.components);
            this.ultraPanel_main.SuspendLayout();
            this.ultraPanel_Top.ClientArea.SuspendLayout();
            this.ultraPanel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraPanel_main
            // 
            appearance1.BackColor = System.Drawing.Color.Transparent;
            appearance1.BorderColor = System.Drawing.Color.Transparent;
            appearance1.ImageBackground = global::SACME.Properties.Resources.fondonew;
            this.ultraPanel_main.Appearance = appearance1;
            this.ultraPanel_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraPanel_main.Location = new System.Drawing.Point(0, 136);
            this.ultraPanel_main.Name = "ultraPanel_main";
            this.ultraPanel_main.Size = new System.Drawing.Size(934, 470);
            this.ultraPanel_main.TabIndex = 4;
            // 
            // ultraPanel_Top
            // 
            appearance2.BackColor = System.Drawing.Color.Transparent;
            appearance2.BorderColor = System.Drawing.Color.Transparent;
            appearance2.ImageBackground = global::SACME.Properties.Resources.top;
            this.ultraPanel_Top.Appearance = appearance2;
            // 
            // ultraPanel_Top.ClientArea
            // 
            this.ultraPanel_Top.ClientArea.Controls.Add(this.ultraLabel_Perfil);
            this.ultraPanel_Top.ClientArea.Controls.Add(this.ultraLabel_Eventos);
            this.ultraPanel_Top.ClientArea.Controls.Add(this.ultraLabel_AcercaDe);
            this.ultraPanel_Top.ClientArea.Controls.Add(this.ultraLabel_Reportes);
            this.ultraPanel_Top.ClientArea.Controls.Add(this.ultraLabel_Ramas);
            this.ultraPanel_Top.ClientArea.Controls.Add(this.ultraLabel_ControlAcademico);
            this.ultraPanel_Top.ClientArea.Controls.Add(this.ultraLabel_Usuario);
            this.ultraPanel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraPanel_Top.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel_Top.Name = "ultraPanel_Top";
            this.ultraPanel_Top.Size = new System.Drawing.Size(934, 130);
            this.ultraPanel_Top.TabIndex = 3;
            // 
            // ultraLabel_Perfil
            // 
            this.ultraLabel_Perfil.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel_Perfil.Location = new System.Drawing.Point(852, 8);
            this.ultraLabel_Perfil.Name = "ultraLabel_Perfil";
            this.ultraLabel_Perfil.Size = new System.Drawing.Size(81, 45);
            this.ultraLabel_Perfil.TabIndex = 6;
            this.ultraLabel_Perfil.Click += new System.EventHandler(this.ultraLabel_Perfil_Click);
            // 
            // ultraLabel_Eventos
            // 
            appearance3.ImageBackground = global::SACME.Properties.Resources.eventos;
            this.ultraLabel_Eventos.Appearance = appearance3;
            this.ultraLabel_Eventos.Location = new System.Drawing.Point(505, 31);
            this.ultraLabel_Eventos.Name = "ultraLabel_Eventos";
            this.ultraLabel_Eventos.Size = new System.Drawing.Size(90, 78);
            this.ultraLabel_Eventos.TabIndex = 5;
            this.ultraLabel_Eventos.Click += new System.EventHandler(this.ultraLabel_Eventos_Click);
            // 
            // ultraLabel_AcercaDe
            // 
            appearance4.ImageBackground = global::SACME.Properties.Resources.acerca;
            this.ultraLabel_AcercaDe.Appearance = appearance4;
            this.ultraLabel_AcercaDe.Location = new System.Drawing.Point(724, 23);
            this.ultraLabel_AcercaDe.Name = "ultraLabel_AcercaDe";
            this.ultraLabel_AcercaDe.Size = new System.Drawing.Size(108, 92);
            this.ultraLabel_AcercaDe.TabIndex = 4;
            this.ultraLabel_AcercaDe.Click += new System.EventHandler(this.ultraLabel_AcercaDe_Click);
            // 
            // ultraLabel_Reportes
            // 
            appearance5.ImageBackground = global::SACME.Properties.Resources.report;
            this.ultraLabel_Reportes.Appearance = appearance5;
            this.ultraLabel_Reportes.Location = new System.Drawing.Point(613, 23);
            this.ultraLabel_Reportes.Name = "ultraLabel_Reportes";
            this.ultraLabel_Reportes.Size = new System.Drawing.Size(100, 87);
            this.ultraLabel_Reportes.TabIndex = 3;
            this.ultraLabel_Reportes.Click += new System.EventHandler(this.ultraLabel_Reportes_Click);
            // 
            // ultraLabel_Ramas
            // 
            appearance6.ImageBackground = global::SACME.Properties.Resources.dia;
            this.ultraLabel_Ramas.Appearance = appearance6;
            this.ultraLabel_Ramas.Location = new System.Drawing.Point(391, 32);
            this.ultraLabel_Ramas.Name = "ultraLabel_Ramas";
            this.ultraLabel_Ramas.Size = new System.Drawing.Size(99, 78);
            this.ultraLabel_Ramas.TabIndex = 2;
            this.ultraLabel_Ramas.Click += new System.EventHandler(this.ultraLabel_Ramas_Click);
            // 
            // ultraLabel_ControlAcademico
            // 
            appearance7.ImageBackground = global::SACME.Properties.Resources.academic;
            this.ultraLabel_ControlAcademico.Appearance = appearance7;
            this.ultraLabel_ControlAcademico.Location = new System.Drawing.Point(290, 23);
            this.ultraLabel_ControlAcademico.Name = "ultraLabel_ControlAcademico";
            this.ultraLabel_ControlAcademico.Size = new System.Drawing.Size(95, 87);
            this.ultraLabel_ControlAcademico.TabIndex = 1;
            this.ultraLabel_ControlAcademico.Click += new System.EventHandler(this.ultraLabel_ControlAcademico_Click);
            // 
            // ultraLabel_Usuario
            // 
            appearance8.ImageBackground = global::SACME.Properties.Resources.user;
            this.ultraLabel_Usuario.Appearance = appearance8;
            this.ultraLabel_Usuario.Location = new System.Drawing.Point(193, 23);
            this.ultraLabel_Usuario.Name = "ultraLabel_Usuario";
            this.ultraLabel_Usuario.Size = new System.Drawing.Size(91, 87);
            this.ultraLabel_Usuario.TabIndex = 0;
            this.ultraLabel_Usuario.Click += new System.EventHandler(this.ultraLabel_Usuario_Click);
            // 
            // ultraSplitter1
            // 
            this.ultraSplitter1.BackColor = System.Drawing.SystemColors.Control;
            this.ultraSplitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraSplitter1.Location = new System.Drawing.Point(0, 130);
            this.ultraSplitter1.MinExtra = 0;
            this.ultraSplitter1.Name = "ultraSplitter1";
            this.ultraSplitter1.RestoreExtent = 130;
            this.ultraSplitter1.Size = new System.Drawing.Size(934, 6);
            this.ultraSplitter1.TabIndex = 5;
            this.ultraSplitter1.CollapsedChanged += new System.EventHandler(this.ultraSplitter1_CollapsedChanged);
            // 
            // ultraToolTipManager1
            // 
            this.ultraToolTipManager1.ContainingControl = this;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 606);
            this.Controls.Add(this.ultraSplitter1);
            this.Controls.Add(this.ultraPanel_main);
            this.Controls.Add(this.ultraPanel_Top);
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S.A.C.M.E";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.ultraPanel_main.ResumeLayout(false);
            this.ultraPanel_Top.ClientArea.ResumeLayout(false);
            this.ultraPanel_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel ultraPanel_main;
        private Infragistics.Win.Misc.UltraPanel ultraPanel_Top;
        private Infragistics.Win.Misc.UltraLabel ultraLabel_Eventos;
        private Infragistics.Win.Misc.UltraLabel ultraLabel_AcercaDe;
        private Infragistics.Win.Misc.UltraLabel ultraLabel_Reportes;
        private Infragistics.Win.Misc.UltraLabel ultraLabel_Ramas;
        private Infragistics.Win.Misc.UltraLabel ultraLabel_ControlAcademico;
        private Infragistics.Win.Misc.UltraLabel ultraLabel_Usuario;
        private Infragistics.Win.Misc.UltraSplitter ultraSplitter1;
        private Infragistics.Win.UltraWinToolTip.UltraToolTipManager ultraToolTipManager1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel_Perfil;






    }
}

