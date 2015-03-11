namespace SACME
{
    partial class Reporte_Actividad_Rama_Anual
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmb_columna = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.button1 = new System.Windows.Forms.Button();
            this.text_campo = new System.Windows.Forms.MaskedTextBox();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_columna)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1326, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmb_columna
            // 
            this.cmb_columna.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.cmb_columna.Location = new System.Drawing.Point(792, 2);
            this.cmb_columna.Name = "cmb_columna";
            this.cmb_columna.Size = new System.Drawing.Size(144, 21);
            this.cmb_columna.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1184, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar Año";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_campo
            // 
            this.text_campo.Location = new System.Drawing.Point(1061, 3);
            this.text_campo.Mask = "9999";
            this.text_campo.Name = "text_campo";
            this.text_campo.Size = new System.Drawing.Size(100, 20);
            this.text_campo.TabIndex = 9;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(700, 4);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(86, 20);
            this.ultraLabel1.TabIndex = 12;
            this.ultraLabel1.Text = "Rama Estado";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel2.Location = new System.Drawing.Point(969, 4);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(86, 21);
            this.ultraLabel2.TabIndex = 13;
            this.ultraLabel2.Text = "Ingrese Año";
            // 
            // Reporte_Actividad_Rama_Anual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 262);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.cmb_columna);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_campo);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Actividad_Rama_Anual";
            this.Text = "Reporte_Actividad_Rama_Anual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reporte_Actividad_Rama_Anual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_columna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmb_columna;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox text_campo;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
    }
}