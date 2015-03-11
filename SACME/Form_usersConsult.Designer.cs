namespace SACME
{
    partial class Form_usersConsult
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
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraButton_Buscar = new Infragistics.Win.Misc.UltraButton();
            this.ultraTextEditor_Buscar = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.radioButton_Apellido = new System.Windows.Forms.RadioButton();
            this.radioButton_Nombre = new System.Windows.Forms.RadioButton();
            this.radioButton_Matricula = new System.Windows.Forms.RadioButton();
            this.radioButton_Cedula = new System.Windows.Forms.RadioButton();
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.dataGridView_Users = new System.Windows.Forms.DataGridView();
            this.ultraButton_Guardar = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton_Cancelar = new Infragistics.Win.Misc.UltraButton();
            this.ultraPanel2 = new Infragistics.Win.Misc.UltraPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_Buscar)).BeginInit();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).BeginInit();
            this.ultraPanel2.ClientArea.SuspendLayout();
            this.ultraPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            appearance1.BackColor = System.Drawing.Color.Gainsboro;
            this.ultraGroupBox1.Appearance = appearance1;
            this.ultraGroupBox1.Controls.Add(this.ultraButton_Buscar);
            this.ultraGroupBox1.Controls.Add(this.ultraTextEditor_Buscar);
            this.ultraGroupBox1.Controls.Add(this.radioButton_Apellido);
            this.ultraGroupBox1.Controls.Add(this.radioButton_Nombre);
            this.ultraGroupBox1.Controls.Add(this.radioButton_Matricula);
            this.ultraGroupBox1.Controls.Add(this.radioButton_Cedula);
            this.ultraGroupBox1.Location = new System.Drawing.Point(248, 69);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(435, 107);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.Text = "Buscar Por";
            // 
            // ultraButton_Buscar
            // 
            this.ultraButton_Buscar.Location = new System.Drawing.Point(256, 68);
            this.ultraButton_Buscar.Name = "ultraButton_Buscar";
            this.ultraButton_Buscar.Size = new System.Drawing.Size(75, 23);
            this.ultraButton_Buscar.TabIndex = 5;
            this.ultraButton_Buscar.Text = "Buscar";
            this.ultraButton_Buscar.Click += new System.EventHandler(this.ultraButton_Buscar_Click);
            // 
            // ultraTextEditor_Buscar
            // 
            this.ultraTextEditor_Buscar.Location = new System.Drawing.Point(117, 68);
            this.ultraTextEditor_Buscar.Name = "ultraTextEditor_Buscar";
            this.ultraTextEditor_Buscar.Size = new System.Drawing.Size(131, 21);
            this.ultraTextEditor_Buscar.TabIndex = 4;
            // 
            // radioButton_Apellido
            // 
            this.radioButton_Apellido.AutoSize = true;
            this.radioButton_Apellido.Location = new System.Drawing.Point(330, 32);
            this.radioButton_Apellido.Name = "radioButton_Apellido";
            this.radioButton_Apellido.Size = new System.Drawing.Size(62, 17);
            this.radioButton_Apellido.TabIndex = 3;
            this.radioButton_Apellido.TabStop = true;
            this.radioButton_Apellido.Text = "Apellido";
            this.radioButton_Apellido.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nombre
            // 
            this.radioButton_Nombre.AutoSize = true;
            this.radioButton_Nombre.Location = new System.Drawing.Point(242, 32);
            this.radioButton_Nombre.Name = "radioButton_Nombre";
            this.radioButton_Nombre.Size = new System.Drawing.Size(62, 17);
            this.radioButton_Nombre.TabIndex = 2;
            this.radioButton_Nombre.TabStop = true;
            this.radioButton_Nombre.Text = "Nombre";
            this.radioButton_Nombre.UseVisualStyleBackColor = true;
            // 
            // radioButton_Matricula
            // 
            this.radioButton_Matricula.AutoSize = true;
            this.radioButton_Matricula.Location = new System.Drawing.Point(148, 32);
            this.radioButton_Matricula.Name = "radioButton_Matricula";
            this.radioButton_Matricula.Size = new System.Drawing.Size(68, 17);
            this.radioButton_Matricula.TabIndex = 1;
            this.radioButton_Matricula.TabStop = true;
            this.radioButton_Matricula.Text = "Matricula";
            this.radioButton_Matricula.UseVisualStyleBackColor = true;
            // 
            // radioButton_Cedula
            // 
            this.radioButton_Cedula.AutoSize = true;
            this.radioButton_Cedula.Location = new System.Drawing.Point(59, 32);
            this.radioButton_Cedula.Name = "radioButton_Cedula";
            this.radioButton_Cedula.Size = new System.Drawing.Size(58, 17);
            this.radioButton_Cedula.TabIndex = 0;
            this.radioButton_Cedula.TabStop = true;
            this.radioButton_Cedula.Text = "Cédula";
            this.radioButton_Cedula.UseVisualStyleBackColor = true;
            // 
            // ultraPanel1
            // 
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.dataGridView_Users);
            this.ultraPanel1.Location = new System.Drawing.Point(26, 197);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(894, 227);
            this.ultraPanel1.TabIndex = 1;
            // 
            // dataGridView_Users
            // 
            this.dataGridView_Users.AllowUserToOrderColumns = true;
            this.dataGridView_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Users.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Users.Name = "dataGridView_Users";
            this.dataGridView_Users.Size = new System.Drawing.Size(894, 227);
            this.dataGridView_Users.TabIndex = 0;
            // 
            // ultraButton_Guardar
            // 
            this.ultraButton_Guardar.Location = new System.Drawing.Point(331, 464);
            this.ultraButton_Guardar.Name = "ultraButton_Guardar";
            this.ultraButton_Guardar.Size = new System.Drawing.Size(75, 23);
            this.ultraButton_Guardar.TabIndex = 2;
            this.ultraButton_Guardar.Text = "Guargar";
            // 
            // ultraButton_Cancelar
            // 
            this.ultraButton_Cancelar.Location = new System.Drawing.Point(517, 464);
            this.ultraButton_Cancelar.Name = "ultraButton_Cancelar";
            this.ultraButton_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.ultraButton_Cancelar.TabIndex = 3;
            this.ultraButton_Cancelar.Text = "Cancelar";
            // 
            // ultraPanel2
            // 
            this.ultraPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            appearance2.BorderColor = System.Drawing.Color.Black;
            appearance2.BorderColor3DBase = System.Drawing.Color.Black;
            appearance2.ImageBackground = global::SACME.Properties.Resources.fon;
            this.ultraPanel2.Appearance = appearance2;
            // 
            // ultraPanel2.ClientArea
            // 
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraButton_Guardar);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraButton_Cancelar);
            this.ultraPanel2.Location = new System.Drawing.Point(0, -1);
            this.ultraPanel2.Name = "ultraPanel2";
            this.ultraPanel2.Size = new System.Drawing.Size(951, 511);
            this.ultraPanel2.TabIndex = 4;
            // 
            // Form_usersConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 509);
            this.Controls.Add(this.ultraPanel1);
            this.Controls.Add(this.ultraGroupBox1);
            this.Controls.Add(this.ultraPanel2);
            this.Name = "Form_usersConsult";
            this.Text = "Form_Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_Buscar)).EndInit();
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).EndInit();
            this.ultraPanel2.ClientArea.ResumeLayout(false);
            this.ultraPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraButton ultraButton_Buscar;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor_Buscar;
        private System.Windows.Forms.RadioButton radioButton_Apellido;
        private System.Windows.Forms.RadioButton radioButton_Nombre;
        private System.Windows.Forms.RadioButton radioButton_Matricula;
        private System.Windows.Forms.RadioButton radioButton_Cedula;
        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private System.Windows.Forms.DataGridView dataGridView_Users;
        private Infragistics.Win.Misc.UltraButton ultraButton_Guardar;
        private Infragistics.Win.Misc.UltraButton ultraButton_Cancelar;
        private Infragistics.Win.Misc.UltraPanel ultraPanel2;
    }
}