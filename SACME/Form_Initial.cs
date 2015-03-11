using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACME
{
    public partial class Form_Initial : Form
    {
        String usuario, contrasenia;
        Connector sacmeDbConn = new ConnectorSingle();
        

        public Form_Initial()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ultraButton_Ingresar_Click(object sender, EventArgs e)
        {
            int flag = 0;
            String query = "";
            SqlDataReader user = null;
            Form_usersPassword fm;
            this.usuario = ultraTextEditor_Usuario.Text;
            this.contrasenia = ultraTextEditor_Contrasenia.Text;

            if (this.usuario == "" || this.contrasenia == "")
                MessageBox.Show("Ingrese correctamente sus datos");
            else
            {
                query = "SELECT id FROM users WHERE username='" + this.usuario + "';";
                user = SqlManager.getQuery(query, sacmeDbConn);

                if (!user.HasRows)
                {
                    MessageBox.Show("Ud no pertenece al Sistema");
                    user.Close();
                }
                else
                {
                    user.Close();

                    if (ultraCheckEditor_PrimeraVez.Checked)
                    {
                        DirectorioEspol.directorioEspolSoapClient wservice = new DirectorioEspol.directorioEspolSoapClient();
                        if (wservice.autenticacion(usuario, contrasenia))
                        {
                           flag = 1;
                        }
                        else
                            MessageBox.Show("Ud no pertenece a la ESPOL, no podrá ingresar a SACME");
                    }
                    else
                    {
                        query = "SELECT id FROM users WHERE username='" + this.usuario + "' AND password='" + this.contrasenia + "';";
                        user = SqlManager.getQuery(query, sacmeDbConn);

                        if (!user.HasRows)
                        {
                            MessageBox.Show("El usuario o contraseña es inválido. Intente nuevamente");
                            user.Close();
                        }
                        else
                        {
                            user.Close();
                            Form_main formmain = new Form_main(this, sacmeDbConn,this.usuario);
                            this.Hide();
                            formmain.Show();
                        }
                        user.Close();

                    }

                    if (flag == 1)
                    {
                        fm = new Form_usersPassword(ultraTextEditor_Usuario.Text, sacmeDbConn, this);
                        this.Hide();
                        fm.Show();
                    }
                }
            }
         }

        private void Form_Initial_FormClosing(object sender, FormClosingEventArgs e)
        {
            sacmeDbConn.getConnection().Close();
        }

        private void ultraTextEditor_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraButton_Ingresar_Click(sender, e);
        }

        private void ultraTextEditor_Contrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraButton_Ingresar_Click(sender, e);
        }    
    }
}
