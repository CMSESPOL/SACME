using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACME
{
    public partial class Form_main : Form
    {
        Form inicialForm = null;
        public Connector conn;
        User us;
        String usern;
        public Form_main()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        public Form_main(Form fini, Connector conn, String username)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.usern = username;
            this.conn = conn;
            this.us = new User(conn, this.usern);
            this.inicialForm = fini;
            ultraLabel_Perfil.Text = this.usern;

            Form_myAccount myaccountform = new Form_myAccount(this.usern, conn);
            AddForm(myaccountform);
            

            if (us.getDirectorshipName() == "NINGUNO" || us.getDirectorshipName() == "ENCARGADO DE PROYECTO")
            {
                this.ultraLabel_ControlAcademico.Visible = false;
                this.ultraLabel_Reportes.Visible = false;
                this.ultraLabel_Ramas.Visible = false;
                this.ultraLabel_Usuario.Visible = false;
                this.ultraLabel_Eventos.Location = new Point(350, 30);
                this.ultraLabel_AcercaDe.Location = new Point(465, 30);
            }

            if (us.getDirectorshipName() == "LIDER DE RAMA")
            {
                this.ultraLabel_ControlAcademico.Visible = false;
                this.ultraLabel_Ramas.Visible = false;
                this.ultraLabel_Usuario.Visible = false;
                this.ultraLabel_Eventos.Location = new Point(299, 30);
                this.ultraLabel_Reportes.Location = new Point(400, 30);
                this.ultraLabel_AcercaDe.Location = new Point(514, 30 );
            }
        }

        public void AddForm(object form)
        {
            if (this.ultraPanel_main.ClientArea.Controls.Count > 0)
            {
                //MessageBox.Show(""+this.ultraPanel_main.ClientArea.Controls.Count);
                this.ultraPanel_main.ClientArea.Controls.RemoveAt(0);
            }

            Form f = form as Form;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.ultraPanel_main.ClientArea.Controls.Add(f);
            this.ultraPanel_main.ClientArea.Tag = f;
            
            f.Show();
        }
        private void ultraLabel_Usuario_Click(object sender, EventArgs e)
        {     
            AddForm(new Form_users(conn, us.getDirectorshipName()));
            ultraSplitter1.Collapsed = true;
            
        }

        private void ultraLabel_ControlAcademico_Click(object sender, EventArgs e)
        {
            Form_academicControl acform = new Form_academicControl(conn, us);
            AddForm(acform);
            ultraSplitter1.Collapsed = true;
        }

        private void ultraLabel_Ramas_Click(object sender, EventArgs e)
        {
            Form_branch branchform = new Form_branch(conn, us.getDirectorshipName());
            AddForm(branchform);
            ultraSplitter1.Collapsed = true;
        }

        private void ultraLabel_Reportes_Click(object sender, EventArgs e)
        {
            Menu_Reporte reporte = new Menu_Reporte(us.getDirectorshipName());
            AddForm(reporte);
            ultraSplitter1.Collapsed = true;
        }

        private void ultraLabel_Eventos_Click(object sender, EventArgs e)
        {
            Form_event eventform = new Form_event(conn, this, us.getDirectorshipName(), us.getId());
            AddForm(eventform);
            ultraSplitter1.Collapsed = true;
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿ Desea Salir de la Aplicacion S/N ?",
                       "Salir de Aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogo == DialogResult.OK)
            {
                this.inicialForm.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ultraSplitter1_CollapsedChanged(object sender, EventArgs e)
        {

            if (!ultraSplitter1.Collapsed)
            {
                ultraPanel_Top.Size = new Size(934, 130);
                ultraPanel_main.Size = new Size(950, 470);
            }

            else
            {                
                ultraPanel_Top.Size = new Size(0, 0);
                ultraPanel_main.Size = new Size(950, 599);                
            }
        }

        private void ultraLabel_AcercaDe_Click(object sender, EventArgs e)
        {
            Form_aboutUs eventform = new Form_aboutUs();
            AddForm(eventform);
            ultraSplitter1.Collapsed = true;
        }

        private void ultraLabel_Perfil_Click(object sender, EventArgs e)
        {
            AddForm(new Form_myAccount(this.usern, conn));
            ultraSplitter1.Collapsed = true;
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }        

       
    }
}
