namespace SACME
{
    partial class Form_genericAddRemove
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            this.dataGridAgregar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UltraGroupBoxAgregar = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGroupBoxRemover = new Infragistics.Win.Misc.UltraGroupBox();
            this.dataGridRemover = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBoxAgregar)).BeginInit();
            this.UltraGroupBoxAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxRemover)).BeginInit();
            this.ultraGroupBoxRemover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAgregar
            // 
            this.dataGridAgregar.AllowUserToAddRows = false;
            this.dataGridAgregar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAgregar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAgregar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAgregar.Location = new System.Drawing.Point(3, 16);
            this.dataGridAgregar.Name = "dataGridAgregar";
            this.dataGridAgregar.ReadOnly = true;
            this.dataGridAgregar.RowHeadersVisible = false;
            this.dataGridAgregar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAgregar.Size = new System.Drawing.Size(681, 219);
            this.dataGridAgregar.TabIndex = 1;
            this.dataGridAgregar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAgregar_CellContentClick);
            this.dataGridAgregar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAgregar_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = " ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "";
            this.Column1.Width = 17;
            // 
            // UltraGroupBoxAgregar
            // 
            this.UltraGroupBoxAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.BackColor = System.Drawing.Color.Transparent;
            this.UltraGroupBoxAgregar.Appearance = appearance1;
            this.UltraGroupBoxAgregar.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Rounded;
            this.UltraGroupBoxAgregar.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.UltraGroupBoxAgregar.ContentAreaAppearance = appearance2;
            this.UltraGroupBoxAgregar.Controls.Add(this.dataGridAgregar);
            this.UltraGroupBoxAgregar.Location = new System.Drawing.Point(12, 12);
            this.UltraGroupBoxAgregar.Name = "UltraGroupBoxAgregar";
            this.UltraGroupBoxAgregar.Size = new System.Drawing.Size(687, 238);
            this.UltraGroupBoxAgregar.TabIndex = 0;
            this.UltraGroupBoxAgregar.Text = "Agregar";
            this.UltraGroupBoxAgregar.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // ultraGroupBoxRemover
            // 
            this.ultraGroupBoxRemover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance3.BackColor = System.Drawing.Color.Transparent;
            this.ultraGroupBoxRemover.Appearance = appearance3;
            this.ultraGroupBoxRemover.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Rounded;
            this.ultraGroupBoxRemover.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraGroupBoxRemover.ContentAreaAppearance = appearance4;
            this.ultraGroupBoxRemover.Controls.Add(this.dataGridRemover);
            this.ultraGroupBoxRemover.Location = new System.Drawing.Point(12, 279);
            this.ultraGroupBoxRemover.Name = "ultraGroupBoxRemover";
            this.ultraGroupBoxRemover.Size = new System.Drawing.Size(687, 238);
            this.ultraGroupBoxRemover.TabIndex = 1;
            this.ultraGroupBoxRemover.Text = "Remover";
            this.ultraGroupBoxRemover.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // dataGridRemover
            // 
            this.dataGridRemover.AllowUserToAddRows = false;
            this.dataGridRemover.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridRemover.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridRemover.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRemover.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1});
            this.dataGridRemover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRemover.Location = new System.Drawing.Point(3, 16);
            this.dataGridRemover.Name = "dataGridRemover";
            this.dataGridRemover.ReadOnly = true;
            this.dataGridRemover.RowHeadersVisible = false;
            this.dataGridRemover.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRemover.Size = new System.Drawing.Size(681, 219);
            this.dataGridRemover.TabIndex = 1;
            this.dataGridRemover.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRemover_CellContentClick);
            this.dataGridRemover.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRemover_CellContentDoubleClick);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewButtonColumn1.Frozen = true;
            this.dataGridViewButtonColumn1.HeaderText = " ";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "";
            this.dataGridViewButtonColumn1.Width = 16;
            // 
            // ultraGroupBox1
            // 
            appearance5.BackColor = System.Drawing.Color.LightBlue;
            this.ultraGroupBox1.Appearance = appearance5;
            this.ultraGroupBox1.Controls.Add(this.ultraGroupBoxRemover);
            this.ultraGroupBox1.Controls.Add(this.UltraGroupBoxAgregar);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(711, 529);
            this.ultraGroupBox1.TabIndex = 4;
            // 
            // Form_genericAddRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 529);
            this.Controls.Add(this.ultraGroupBox1);
            this.MaximizeBox = false;
            this.Name = "Form_genericAddRemove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_genericAddRemove_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBoxAgregar)).EndInit();
            this.UltraGroupBoxAgregar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxRemover)).EndInit();
            this.ultraGroupBoxRemover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAgregar;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private Infragistics.Win.Misc.UltraGroupBox UltraGroupBoxAgregar;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxRemover;
        private System.Windows.Forms.DataGridView dataGridRemover;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;


    }
}