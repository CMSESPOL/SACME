namespace SACME
{
    partial class Form_uploadDataBranch
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
            Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.pnlDataBranch = new Infragistics.Win.Misc.UltraPanel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.btnHabilitarCampos = new System.Windows.Forms.Button();
            this.cmbState_up = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lbNombreR = new Infragistics.Win.Misc.UltraLabel();
            this.txtNameBranch_up = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lblEstRama = new Infragistics.Win.Misc.UltraLabel();
            this.dateCreateBranch_up = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.lblfecCreaRama = new Infragistics.Win.Misc.UltraLabel();
            this.pnlRegistro = new Infragistics.Win.Misc.UltraGroupBox();
            this.txtShorNamet_up = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.pnlDataBranch.ClientArea.SuspendLayout();
            this.pnlDataBranch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbState_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameBranch_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreateBranch_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRegistro)).BeginInit();
            this.pnlRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShorNamet_up)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDataBranch
            // 
            appearance1.BackColor = System.Drawing.Color.White;
            appearance1.BorderColor = System.Drawing.Color.MidnightBlue;
            this.pnlDataBranch.Appearance = appearance1;
            this.pnlDataBranch.BorderStyle = Infragistics.Win.UIElementBorderStyle.Etched;
            // 
            // pnlDataBranch.ClientArea
            // 
            this.pnlDataBranch.ClientArea.Controls.Add(this.txtShorNamet_up);
            this.pnlDataBranch.ClientArea.Controls.Add(this.ultraLabel1);
            this.pnlDataBranch.ClientArea.Controls.Add(this.btnHabilitarCampos);
            this.pnlDataBranch.ClientArea.Controls.Add(this.cmbState_up);
            this.pnlDataBranch.ClientArea.Controls.Add(this.btnCancel);
            this.pnlDataBranch.ClientArea.Controls.Add(this.btnUpload);
            this.pnlDataBranch.ClientArea.Controls.Add(this.lbNombreR);
            this.pnlDataBranch.ClientArea.Controls.Add(this.txtNameBranch_up);
            this.pnlDataBranch.ClientArea.Controls.Add(this.lblEstRama);
            this.pnlDataBranch.ClientArea.Controls.Add(this.dateCreateBranch_up);
            this.pnlDataBranch.ClientArea.Controls.Add(this.lblfecCreaRama);
            this.pnlDataBranch.Location = new System.Drawing.Point(48, 45);
            this.pnlDataBranch.Name = "pnlDataBranch";
            this.pnlDataBranch.Size = new System.Drawing.Size(457, 312);
            this.pnlDataBranch.TabIndex = 151;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ultraLabel1.Location = new System.Drawing.Point(73, 94);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(33, 14);
            this.ultraLabel1.TabIndex = 145;
            this.ultraLabel1.Text = "Alias:";
            // 
            // btnHabilitarCampos
            // 
            this.btnHabilitarCampos.AutoSize = true;
            this.btnHabilitarCampos.BackColor = System.Drawing.Color.Azure;
            this.btnHabilitarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarCampos.Location = new System.Drawing.Point(57, 226);
            this.btnHabilitarCampos.Name = "btnHabilitarCampos";
            this.btnHabilitarCampos.Size = new System.Drawing.Size(136, 26);
            this.btnHabilitarCampos.TabIndex = 140;
            this.btnHabilitarCampos.Text = "Habilitar campos";
            this.btnHabilitarCampos.UseVisualStyleBackColor = false;
            this.btnHabilitarCampos.Click += new System.EventHandler(this.btnHabilitarCampos_Click);
            // 
            // cmbState_up
            // 
            this.cmbState_up.Enabled = false;
            valueListItem1.DataValue = "Activado";
            valueListItem2.DataValue = "Desactivado";
            this.cmbState_up.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1,
            valueListItem2});
            this.cmbState_up.Location = new System.Drawing.Point(207, 119);
            this.cmbState_up.Name = "cmbState_up";
            this.cmbState_up.Size = new System.Drawing.Size(196, 21);
            this.cmbState_up.TabIndex = 139;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.Azure;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(310, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 26);
            this.btnCancel.TabIndex = 138;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.AutoSize = true;
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.Enabled = false;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(212, 226);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(86, 26);
            this.btnUpload.TabIndex = 129;
            this.btnUpload.Text = "Actualizar";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbNombreR
            // 
            this.lbNombreR.AutoSize = true;
            this.lbNombreR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbNombreR.Location = new System.Drawing.Point(72, 59);
            this.lbNombreR.Name = "lbNombreR";
            this.lbNombreR.Size = new System.Drawing.Size(49, 14);
            this.lbNombreR.TabIndex = 130;
            this.lbNombreR.Text = "Nombre:";
            // 
            // txtNameBranch_up
            // 
            this.txtNameBranch_up.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.txtNameBranch_up.Enabled = false;
            this.txtNameBranch_up.Location = new System.Drawing.Point(149, 60);
            this.txtNameBranch_up.Name = "txtNameBranch_up";
            this.txtNameBranch_up.Size = new System.Drawing.Size(254, 21);
            this.txtNameBranch_up.TabIndex = 131;
            // 
            // lblEstRama
            // 
            this.lblEstRama.AutoSize = true;
            this.lblEstRama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEstRama.Location = new System.Drawing.Point(72, 119);
            this.lblEstRama.Name = "lblEstRama";
            this.lblEstRama.Size = new System.Drawing.Size(44, 14);
            this.lblEstRama.TabIndex = 132;
            this.lblEstRama.Text = "Estado:";
            // 
            // dateCreateBranch_up
            // 
            this.dateCreateBranch_up.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateCreateBranch_up.DateTime = new System.DateTime(2013, 4, 11, 0, 0, 0, 0);
            this.dateCreateBranch_up.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.dateCreateBranch_up.Enabled = false;
            this.dateCreateBranch_up.Location = new System.Drawing.Point(207, 152);
            this.dateCreateBranch_up.Name = "dateCreateBranch_up";
            this.dateCreateBranch_up.Size = new System.Drawing.Size(194, 21);
            this.dateCreateBranch_up.TabIndex = 135;
            this.dateCreateBranch_up.Value = new System.DateTime(2013, 4, 11, 0, 0, 0, 0);
            // 
            // lblfecCreaRama
            // 
            this.lblfecCreaRama.AutoSize = true;
            this.lblfecCreaRama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblfecCreaRama.Location = new System.Drawing.Point(72, 152);
            this.lblfecCreaRama.Name = "lblfecCreaRama";
            this.lblfecCreaRama.Size = new System.Drawing.Size(104, 14);
            this.lblfecCreaRama.TabIndex = 133;
            this.lblfecCreaRama.Text = "Fecha de creación:";
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlRegistro.Appearance = appearance2;
            this.pnlRegistro.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.pnlRegistro.Controls.Add(this.pnlDataBranch);
            this.pnlRegistro.Location = new System.Drawing.Point(1, 0);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(560, 402);
            this.pnlRegistro.TabIndex = 152;
            // 
            // txtShorNamet_up
            // 
            this.txtShorNamet_up.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.txtShorNamet_up.Enabled = false;
            this.txtShorNamet_up.Location = new System.Drawing.Point(207, 90);
            this.txtShorNamet_up.Name = "txtShorNamet_up";
            this.txtShorNamet_up.Size = new System.Drawing.Size(196, 21);
            this.txtShorNamet_up.TabIndex = 146;
            // 
            // Form_uploadDataBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 398);
            this.Controls.Add(this.pnlRegistro);
            this.Name = "Form_uploadDataBranch";
            this.Text = "Datos de Rama";
            this.pnlDataBranch.ClientArea.ResumeLayout(false);
            this.pnlDataBranch.ClientArea.PerformLayout();
            this.pnlDataBranch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbState_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameBranch_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreateBranch_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRegistro)).EndInit();
            this.pnlRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtShorNamet_up)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel pnlDataBranch;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbState_up;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpload;
        private Infragistics.Win.Misc.UltraLabel lbNombreR;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtNameBranch_up;
        private Infragistics.Win.Misc.UltraLabel lblEstRama;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor dateCreateBranch_up;
        private Infragistics.Win.Misc.UltraLabel lblfecCreaRama;
        private Infragistics.Win.Misc.UltraGroupBox pnlRegistro;
        private System.Windows.Forms.Button btnHabilitarCampos;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtShorNamet_up;
    }
}