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
    public partial class Form_myAccount : Form
    {
        Connector conn;
        String username;
        String name = null, lastname = null, address = null, phone = null, cellphone = null, emailPersona = null, password = null;
        String editName = null, editLastname = null, editAddress = null, editPhone = null, editCellphone = null, editEmailPersona = null, editPassword = null, newPass = null, confirmNewPass = null;
            
        public Form_myAccount()
        {
            InitializeComponent();
        }

        public Form_myAccount(String user, Connector con)
        {
            InitializeComponent();
            this.username = user;
            this.conn = con;
            this.ultraLabel_Usuario.Text = this.username;
            fillForm();

        }

        private void fillForm() {
            String q = "SELECT name,lastname,address,phone,cellphone,emailPersonal,password FROM users WHERE username='" + this.username + "';";
           SqlDataReader info = null;

            info = SqlManager.getQuery(q, this.conn);

            if (info.HasRows) 
            {
                while (info.Read()) 
                {
                    this.name = info[0].ToString();
                    this.lastname = info[1].ToString();
                    this.address = info[2].ToString();
                    this.phone = info[3].ToString();
                    this.cellphone = info[4].ToString();
                    this.emailPersona = info[5].ToString();
                    this.password = info[6].ToString();
                }
            }

            info.Close();

            if(this.name!="")
                ultraTextEditor_Nombres.Text = this.name;
            if(this.lastname!="")
                ultraTextEditor_Apellidos.Text = this.lastname;
            if(this.address!="")
                ultraTextEditor_Direccion.Text = this.address;
            if(this.phone!="")
                ultraTextEditor_Telefono.Text = this.phone;
            if(this.cellphone!="")
                ultraTextEditor_Celular.Text = this.cellphone;
            if(this.emailPersona!="")
                ultraTextEditor_EmailPersonal.Text = this.emailPersona;

            ultraTextEditor_Contrasenia.Text = "";
        }

        private void ultraLabel_Editar_Click(object sender, EventArgs e)
        {
            ultraButton_Guardar.Visible = true;
            ultraButton_Cancelar.Visible = true;
            ultraLabel_Editar.Visible = false;
        }

        private void ultraButton_Cancelar_Click(object sender, EventArgs e)
        {
            ultraButton_Guardar.Visible = false;
            ultraButton_Cancelar.Visible = false;
            ultraLabel_Editar.Visible = true;
            fillForm();
        }

        private void ultraButton_Guardar_Click(object sender, EventArgs e)
        {
            this.editName = ultraTextEditor_Nombres.Text;
            this.editLastname = ultraTextEditor_Apellidos.Text;
            this.editAddress = ultraTextEditor_Direccion.Text;
            this.editPhone = ultraTextEditor_Telefono.Text;
            this.editCellphone = ultraTextEditor_Celular.Text;
            this.editEmailPersona = ultraTextEditor_EmailPersonal.Text;
            this.editPassword = ultraTextEditor_Contrasenia.Text;
            
            if (this.editPassword != this.password)
                MessageBox.Show("Por favor escriba correctamente las contraseña");
            else if (this.editName == "" || this.editLastname == "" || this.editEmailPersona == "")
            {
                this.ultraLabel8.Visible = true;
            }
            else 
            {
                this.ultraLabel8.Visible = false;
                updateData();
                fillForm();
                ultraButton_Guardar.Visible = false;
                ultraButton_Cancelar.Visible = false;
                ultraLabel_Editar.Visible = true;
            }
        }

        private void updateData() 
        {
            String q = "UPDATE users SET name = '" + this.editName +
                                        "', lastname = '" + this.editLastname +
                                        "', address = '" + this.editAddress +
                                        "', phone = '" + this.editPhone +
                                        "', cellphone = '" + this.editCellphone +
                                        "', emailPersonal = '" + this.editEmailPersona +
                                        "' WHERE username='" + this.username + "';";
            SqlManager.executeQuery(q, this.conn);
        
        }

        private void ultraLabel_nuevaCont_Click(object sender, EventArgs e)
        {
            ultraLabel_CancelCont.Visible = true;
            ultraLabel_ConfCont.Visible = true;
            ultraLabel_nuevCont.Visible = true;
            ultraTextEditor_NuevaContrasenia.Visible = true;
            ultraTextEditor_ConfirmContrasenia.Visible = true;
            ultraLabel_GuardarCont.Visible = true;
        }

        private void ultraLabel_CancelCont_Click(object sender, EventArgs e)
        {
            ultraLabel_CancelCont.Visible = false;
            ultraLabel_ConfCont.Visible = false;
            ultraLabel_nuevCont.Visible = false;
            ultraTextEditor_NuevaContrasenia.Visible = false;
            ultraTextEditor_ConfirmContrasenia.Visible = false;
            ultraLabel_GuardarCont.Visible = false;
        }

        private void ultraLabel_GuardarCont_Click(object sender, EventArgs e)
        {
            this.newPass = ultraTextEditor_NuevaContrasenia.Text;
            this.confirmNewPass = ultraTextEditor_ConfirmContrasenia.Text;
            this.editPassword = ultraTextEditor_Contrasenia.Text;

            if (this.editPassword != this.password)
                MessageBox.Show("Su contraseña actual no coincide");
            else if (this.newPass != this.confirmNewPass)
                MessageBox.Show("La nueva contraseña no coincide");
            else if (this.newPass == "" || this.confirmNewPass == "")
                MessageBox.Show("Por favor llene los campos correspondientes");
            else
            {
                savePassword();
                ultraLabel_CancelCont.Visible = false;
                ultraLabel_ConfCont.Visible = false;
                ultraLabel_nuevCont.Visible = false;
                ultraTextEditor_NuevaContrasenia.Visible = false;
                ultraTextEditor_ConfirmContrasenia.Visible = false;
                ultraLabel_GuardarCont.Visible = false;
                fillForm();
            }
        }

        private void savePassword()
        {
            String q = "UPDATE users SET password = '" + this.newPass +
                                        "' WHERE username = '" + this.username + "'";
            SqlManager.executeQuery(q, this.conn);
        }
    }
}
