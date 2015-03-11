namespace SACME
{
    partial class Reporte_Actividades_Rama_Mensual
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
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_columna)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1286, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmb_columna
            // 
            this.cmb_columna.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.cmb_columna.Location = new System.Drawing.Point(728, 3);
            this.cmb_columna.Name = "cmb_columna";
            this.cmb_columna.Size = new System.Drawing.Size(144, 21);
            this.cmb_columna.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1130, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Buscar Rama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_campo
            // 
            this.text_campo.Location = new System.Drawing.Point(1024, 4);
            this.text_campo.Name = "text_campo";
            this.text_campo.Size = new System.Drawing.Size(100, 20);
            this.text_campo.TabIndex = 12;
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel2.Location = new System.Drawing.Point(925, 4);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(93, 21);
            this.ultraLabel2.TabIndex = 15;
            this.ultraLabel2.Text = "Ingrese Rama";
            this.ultraLabel2.Click += new System.EventHandler(this.ultraLabel2_Click);
            // 
            // Reporte_Actividades_Rama_Mensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 262);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.cmb_columna);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_campo);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Actividades_Rama_Mensual";
            this.Text = "Reporte_Actividades_Rama_Mensual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reporte_Actividades_Rama_Mensual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_columna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmb_columna;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox text_campo;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
    }
}