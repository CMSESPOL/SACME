namespace SACME
{
    partial class Form_academicControlConsult
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
            this.radioButton_name = new System.Windows.Forms.RadioButton();
            this.radioButton_mat = new System.Windows.Forms.RadioButton();
            this.radioButton_ced = new System.Windows.Forms.RadioButton();
            this.ultraTextEditor_search = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraButton_courses = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton_espol = new Infragistics.Win.Misc.UltraButton();
            this.dataGridView_AC = new System.Windows.Forms.DataGridView();
            this.ultraButton_accept = new Infragistics.Win.Misc.UltraButton();
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AC)).BeginInit();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            appearance1.BackColor = System.Drawing.Color.Gainsboro;
            this.ultraGroupBox1.Appearance = appearance1;
            this.ultraGroupBox1.Controls.Add(this.radioButton_name);
            this.ultraGroupBox1.Controls.Add(this.radioButton_mat);
            this.ultraGroupBox1.Controls.Add(this.radioButton_ced);
            this.ultraGroupBox1.Controls.Add(this.ultraTextEditor_search);
            this.ultraGroupBox1.Location = new System.Drawing.Point(242, 47);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(438, 97);
            this.ultraGroupBox1.TabIndex = 3;
            this.ultraGroupBox1.Text = "Búsqueda";
            // 
            // radioButton_name
            // 
            this.radioButton_name.AutoSize = true;
            this.radioButton_name.Location = new System.Drawing.Point(305, 19);
            this.radioButton_name.Name = "radioButton_name";
            this.radioButton_name.Size = new System.Drawing.Size(120, 17);
            this.radioButton_name.TabIndex = 4;
            this.radioButton_name.TabStop = true;
            this.radioButton_name.Text = "Nombres y Apellidos";
            this.radioButton_name.UseVisualStyleBackColor = true;
            // 
            // radioButton_mat
            // 
            this.radioButton_mat.AutoSize = true;
            this.radioButton_mat.Location = new System.Drawing.Point(171, 19);
            this.radioButton_mat.Name = "radioButton_mat";
            this.radioButton_mat.Size = new System.Drawing.Size(68, 17);
            this.radioButton_mat.TabIndex = 3;
            this.radioButton_mat.TabStop = true;
            this.radioButton_mat.Text = "Matricula";
            this.radioButton_mat.UseVisualStyleBackColor = true;
            // 
            // radioButton_ced
            // 
            this.radioButton_ced.AutoSize = true;
            this.radioButton_ced.Location = new System.Drawing.Point(45, 19);
            this.radioButton_ced.Name = "radioButton_ced";
            this.radioButton_ced.Size = new System.Drawing.Size(58, 17);
            this.radioButton_ced.TabIndex = 2;
            this.radioButton_ced.TabStop = true;
            this.radioButton_ced.Text = "Cédula";
            this.radioButton_ced.UseVisualStyleBackColor = true;
            // 
            // ultraTextEditor_search
            // 
            this.ultraTextEditor_search.Location = new System.Drawing.Point(131, 53);
            this.ultraTextEditor_search.Name = "ultraTextEditor_search";
            this.ultraTextEditor_search.Size = new System.Drawing.Size(168, 21);
            this.ultraTextEditor_search.TabIndex = 1;
            // 
            // ultraButton_courses
            // 
            this.ultraButton_courses.Location = new System.Drawing.Point(329, 150);
            this.ultraButton_courses.Name = "ultraButton_courses";
            this.ultraButton_courses.Size = new System.Drawing.Size(114, 35);
            this.ultraButton_courses.TabIndex = 5;
            this.ultraButton_courses.Text = "Cursos";
            this.ultraButton_courses.Click += new System.EventHandler(this.ultraButton_courses_Click);
            // 
            // ultraButton_espol
            // 
            this.ultraButton_espol.Location = new System.Drawing.Point(481, 150);
            this.ultraButton_espol.Name = "ultraButton_espol";
            this.ultraButton_espol.Size = new System.Drawing.Size(107, 35);
            this.ultraButton_espol.TabIndex = 6;
            this.ultraButton_espol.Text = "Espol";
            this.ultraButton_espol.Click += new System.EventHandler(this.ultraButton_espol_Click);
            // 
            // dataGridView_AC
            // 
            this.dataGridView_AC.AllowUserToAddRows = false;
            this.dataGridView_AC.AllowUserToDeleteRows = false;
            this.dataGridView_AC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_AC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_AC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_AC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AC.Location = new System.Drawing.Point(19, 194);
            this.dataGridView_AC.Name = "dataGridView_AC";
            this.dataGridView_AC.ReadOnly = true;
            this.dataGridView_AC.RowHeadersVisible = false;
            this.dataGridView_AC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_AC.Size = new System.Drawing.Size(894, 253);
            this.dataGridView_AC.TabIndex = 8;
            this.dataGridView_AC.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.columnGrid_doubleClick);
            // 
            // ultraButton_accept
            // 
            this.ultraButton_accept.Location = new System.Drawing.Point(422, 453);
            this.ultraButton_accept.Name = "ultraButton_accept";
            this.ultraButton_accept.Size = new System.Drawing.Size(75, 23);
            this.ultraButton_accept.TabIndex = 9;
            this.ultraButton_accept.Text = "Aceptar";
            this.ultraButton_accept.Click += new System.EventHandler(this.ultraButton_accept_Click);
            // 
            // ultraPanel1
            // 
            appearance2.ImageBackground = global::SACME.Properties.Resources.fon;
            this.ultraPanel1.Appearance = appearance2;
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraButton_accept);
            this.ultraPanel1.ClientArea.Controls.Add(this.dataGridView_AC);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraButton_espol);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraButton_courses);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraGroupBox1);
            this.ultraPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraPanel1.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(926, 486);
            this.ultraPanel1.TabIndex = 10;
            // 
            // Form_academicControlConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(926, 486);
            this.Controls.Add(this.ultraPanel1);
            this.Name = "Form_academicControlConsult";
            this.Text = "Form_academicControl";
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AC)).EndInit();
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private System.Windows.Forms.RadioButton radioButton_name;
        private System.Windows.Forms.RadioButton radioButton_mat;
        private System.Windows.Forms.RadioButton radioButton_ced;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor_search;
        private Infragistics.Win.Misc.UltraButton ultraButton_courses;
        private Infragistics.Win.Misc.UltraButton ultraButton_espol;
        private System.Windows.Forms.DataGridView dataGridView_AC;
        private Infragistics.Win.Misc.UltraButton ultraButton_accept;
        private Infragistics.Win.Misc.UltraPanel ultraPanel1;

    }
}