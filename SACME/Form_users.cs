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
    public partial class Form_users : Form
    {
        public Connector conn;
        String directorpShip = "";

        public Form_users()
        {
            InitializeComponent();
        }

        public Form_users(Connector conn,String directorshipName)
        {
            InitializeComponent();
            this.conn = conn;
            this.directorpShip = directorshipName;

            if (this.directorpShip == "CONSEJERO")
            {
                ultraButtonRegistro.Visible = false;
                ultraButtonConsulta.Location = new Point(250, 4);
            }
        }

        public void AddForm(object form)
        {
            if (this.ultraPanelUsuarios.ClientArea.Controls.Count > 0)
            {
                // MessageBox.Show("" + this.ultraPanelUsuarios.ClientArea.Controls.Count);
                this.ultraPanelUsuarios.ClientArea.Controls.RemoveAt(0);
            }

            Form f = form as Form;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.ultraPanelUsuarios.ClientArea.Controls.Add(f);
            this.ultraPanelUsuarios.ClientArea.Tag = f;

            f.Show();
        }

        private void ultraButtonRegistro_Click(object sender, EventArgs e)
        {
            AddForm(new Form_usersRegistry(conn));
        }

        private void ultraButtonConsulta_Click(object sender, EventArgs e)
        {
            AddForm(new Form_usersConsult(conn, this.directorpShip));
        }

       
    }
}
