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
    public partial class Form_usersPassword : Form
    {
        String pass = "", confirPass = "";
        String user = "";
        String query = "";
        Connector conn;
        Form_Initial ini;

        public Form_usersPassword()
        {
            InitializeComponent();
        }

        public Form_usersPassword(String us,Connector con, Form_Initial initial)
        {
            InitializeComponent();
            this.CenterToScreen();
            
            this.user = us;
            this.conn = con;
            this.ini = initial;
            ultraLabel1.Text = "Bienvenido " + this.user;
        }

        private void ultraButton_Guardar_Click(object sender, EventArgs e)
        {
            pass = ultraTextEditor_Contrasenia.Text;
            confirPass = ultraTextEditor_ConfirmContrasenia.Text;

            if (pass == "" || confirPass == "")
                MessageBox.Show("Ingrese correctamente los valores correspondientes");
            else if (pass != confirPass)
                MessageBox.Show("Contraseñas no coinciden");
            else
            {
                this.query = "UPDATE users SET password='" + pass + "' WHERE username='" + this.user + "';";
                if (SqlManager.executeQuery(query, conn))
                {
                   Form_main formmain = new Form_main(ini,conn,user);
                   this.Hide();
                   formmain.Show();
                }

            }
                
            
        }

        private void ultraButton_Cancelar_Click(object sender, EventArgs e)
        {
            ini.Show();
            this.Hide();
        }
    }
}
