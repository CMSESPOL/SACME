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
    public partial class Form_Inicial : Form
    {
        String usuario, contrasenia;
        Connector sacmeDbConn = new ConnectorSingle();
        User us;

        public Form_Inicial()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ultraButton_Ingresar_Click(object sender, EventArgs e)
        {
            usuario = ultraTextEditor_Usuario.Text;
            contrasenia = ultraTextEditor_Contrasenia.Text;

            if (ultraCheckEditor_PrimeraVez.Checked)
            {
                DirectorioEspol.directorioEspolSoapClient wservice = new DirectorioEspol.directorioEspolSoapClient();
                if (wservice.autenticacion(usuario, contrasenia))
                    MessageBox.Show("Es un usuario espol");
                else
                    MessageBox.Show("NO ES, vayase");
            }


            Form_main formmain = new Form_main(this,sacmeDbConn);
            this.Hide();
            formmain.Show();
        }

       

       
    }
}
