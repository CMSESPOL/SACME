using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACME
{
    public partial class Form_academicControl : Form
    {
        Connector conn;
        User userSession;
        
        public Form_academicControl()
        {
            InitializeComponent();
        }

        public Form_academicControl(Connector conn,User userSession)
        {            
            InitializeComponent();
            this.conn = conn;
            this.userSession = userSession;

            if (this.userSession.getDirectorshipName() == "CONSEJERO")
            {
                ultraButtonRegistro.Visible = false;
                ultraButtonConsulta.Location = new Point(250, 4);
            }
        }

        public void AddForm(object form)
        {
            if (this.ultraPanelAcademicControl.ClientArea.Controls.Count > 0)
            {
                this.ultraPanelAcademicControl.ClientArea.Controls.RemoveAt(0);
            }

            Form f = form as Form;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.ultraPanelAcademicControl.ClientArea.Controls.Add(f);
            this.ultraPanelAcademicControl.ClientArea.Tag = f;

            f.Show();
        }

        private void ultraButtonRegistro_Click(object sender, EventArgs e)
        {
            this.AddForm(new Form_academicControlRegistry(conn,userSession));
        }

        private void ultraButtonConsulta_Click(object sender, EventArgs e)
        {
            this.AddForm(new Form_academicControlConsult(conn,userSession));
        }

        
    }
}
