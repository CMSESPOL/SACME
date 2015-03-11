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
    public partial class Form_usersRegistry : Form
    {
        public Connector conn;
        private String name = null, lastName = null, id = null, birthDate = null, address = null, personalEmail = null, emailESPOL = null, phone = null, cellPhone = null;
        private String regnumber = null, fac = null, career = null;
        private String member = null, candidate = null, observationUserTreatment = null, observationUserDirectorship = null, observationUserState = null;
        private String directorship = null, state = null;
        private String branchOne = null, branchTwo = null, branchOneObservation = null, branchTwoObservation = null;
        private DateTime birthd ;

        public Form_usersRegistry()
        {
            InitializeComponent();
        }

        public Form_usersRegistry(Connector conn)
        {
            InitializeComponent();
            this.conn = conn;
            addItemtoComboEditor(ultraComboEditor_Facultad, "SELECT shortName FROM faculty");
            addItemtoComboEditor(ultraComboEditor_Cargo, "SELECT name FROM directorship");
            addItemtoComboEditor(ultraComboEditor_RamaUno, "SELECT name FROM branch ");
        }

        private void addItemtoComboEditor(Infragistics.Win.UltraWinEditors.UltraComboEditor uce, String query)
        {
            String item;
            SqlDataReader myreader = null;

            myreader = SqlManager.getQuery(query, conn);

            while (uce.Items.Count > 0)
                uce.Items.RemoveAt(0);

            if (myreader.HasRows)
            {
                while (myreader.Read())
                {
                    item = myreader[0].ToString();
                    uce.Items.Add(item);
                }
            }
            myreader.Close();
        }

        private void ultraComboEditor_Facultad_ValueChanged(object sender, EventArgs e)
        {
            String faculty = null, FACid = "";
            faculty = ultraComboEditor_Facultad.Text;
            String query = "SELECT id FROM faculty WHERE shortName='" + faculty + "'";
            FACid = myReader(query);
           
            
            ultraComboEditor_Carrera.Enabled = true;
            ultraComboEditor_Carrera.Text = "Escoja una Carrera";

            addItemtoComboEditor(ultraComboEditor_Carrera, "SELECT Name FROM career WHERE facultyId=" + FACid);
        }

        private void radioButton_Miembro_CheckedChanged(object sender, EventArgs e)
        {
            ultraTextEditor_ObservacionUserState.Enabled = true;
            ultraTextEditor_ObservacionDirectorship.Enabled = true;
            ultraComboEditor_Cargo.Enabled = true;
            ultraComboEditor_Estado.Enabled = true;
            ultraComboEditor_RamaUno.Enabled = true;
            ultraTextEditor_ObservacionRamaUno.Enabled = true;
        }

        private void radioButton_Candidato_CheckedChanged(object sender, EventArgs e)
        {
            ultraTextEditor_ObservacionUserState.Enabled = false;
            ultraTextEditor_ObservacionDirectorship.Enabled = false;
            ultraComboEditor_Cargo.Enabled = false;
            ultraComboEditor_Estado.Enabled = false;
            ultraComboEditor_RamaDos.Enabled = false;
            ultraTextEditor_ObservacionRamaDos.Enabled = false;
            ultraComboEditor_RamaUno.Enabled = false;
            ultraTextEditor_ObservacionRamaUno.Enabled = false;
        }

        private String myReader(String query){
            SqlDataReader myreader = null;
            String var = "";
            myreader = SqlManager.getQuery(query, conn);

            if (myreader.HasRows)
            {
                while (myreader.Read())
                    var = myreader[0].ToString();

            }
            myreader.Close();
            return var;
        }

        private String addtoUserState() {
            
            String isActive = "'False'", isPassive = "'False'", isTesting = "'False'", isInactive = "'False'", isRemoved = "'False'";
            String query;

            if (this.state == "Activo")
                isActive = "'True'";
            else if (this.state == "Pasivo")
                isPassive = "'True'";
            else if (this.state == "Inactivo")
                isInactive = "'True'";
            else if (this.state == "A prueba")
                isTesting = "'True'";
            else if (this.state == "Removido")
                isRemoved = "'True'";

            query = "INSERT INTO userState (isActive,isPassive,isTesting,isInactive,isRemoved,lastChange,observation) VALUES (" + isActive + "," + isPassive + "," + isTesting + "," + isInactive + "," + isRemoved + ",GETDATE(),'" + this.observationUserState + "'); SELECT SCOPE_IDENTITY();";
            
            return myReader(query);
        }

        private String addToUserTreatment() {
            String query;
            String memberT = "'False'", candidateT = "'False'";

            if (radioButton_Miembro.Checked)
                memberT = "'True'";
            else
                candidateT = "'True'";

            query = "INSERT INTO userTreatment (isMember,isCandidate,lastChange,observation) VALUES(" + memberT + "," + candidateT + ",GETDATE(),'" + this.observationUserTreatment + "'); SELECT SCOPE_IDENTITY();";
            return myReader(query);
        }

        private void ultraTextEditor_EmailESPOL_ValueChanged(object sender, EventArgs e)
        {
            ultraTextEditor_Usuario.Text = ultraTextEditor_EmailESPOL.Text;
        }

        private void ultraButton_Guardar_Click(object sender, EventArgs e)
        {
            int i = 0;

            this.name = ultraTextEditor_Nombre.Text;
            this.lastName = ultraTextEditor_Apellido.Text;
            this.birthd = (DateTime)ultraDateTimeEditor_FechaNacimiento.Value;
            this.birthDate = this.birthd.Year + "-" + this.birthd.Month + "-" + this.birthd.Day;
            this.id = ultraText_Cedula.Text;
            this.address = ultraTextEditor_Direccion.Text;
            this.emailESPOL = ultraTextEditor_EmailESPOL.Text;
            this.personalEmail = ultraTextEditor_EmailPersonal.Text;
            this.phone = ultraTextEditor_Telefono.Text;
            this.cellPhone = ultraTextEditor_Celular.Text;
            this.regnumber = ultraTextEditor_Matricula.Text;
            this.fac = ultraComboEditor_Facultad.Text;
            this.career = ultraComboEditor_Carrera.Text;
            this.directorship = ultraComboEditor_Cargo.Text;
            this.state = ultraComboEditor_Estado.Text;
            this.observationUserTreatment = ultraTextEditor_ObservacionUserTreatment.Text;
            this.branchOne = ultraComboEditor_RamaUno.Text;
            this.branchTwo = ultraComboEditor_RamaDos.Text;
            this.branchOneObservation = ultraTextEditor_ObservacionRamaUno.Text;
            this.branchTwoObservation = ultraTextEditor_ObservacionRamaDos.Text;

            if (radioButton_Candidato.Checked)
            {
                this.candidate = "true";
                this.directorship = "";
                this.branchOne = "";
                this.state = "";
                i = 1;
            }
            else if (radioButton_Miembro.Checked)
            {
                this.member = "true";
                this.observationUserState = ultraTextEditor_ObservacionUserState.Text;
                this.observationUserDirectorship = ultraTextEditor_ObservacionDirectorship.Text;
                i = 1;
            }
            else
                MessageBox.Show("¿Es candidato o miembro?");

            if (this.id == "" || this.name == "" || this.lastName == "" || this.emailESPOL == "" || this.regnumber == "" || this.fac == "Escoja una Facultad" || this.career == "Escoja una Carrera" || this.directorship == "Escoja un Cargo" || this.state == "Escoja un Estado" || this.branchOne == "Escoja una Rama")
                ultraLabel_mensaje.Visible = true;

            else if (i == 1)
            {
                if (validateInfo())
                {
                    insertUser();
                    this.Close();
       
                }
            }
             
        }

        private bool validateInfo() 
        {
            String regNumVal = myReader("SELECT lastname FROM users WHERE registrationNumber='" + this.regnumber + "';");
            String usernameVal = myReader("SELECT lastname FROM users WHERE username='" + this.emailESPOL + "';");
            String idVal = myReader("SELECT lastname FROM users WHERE id='" + this.id + "';");


            if (regNumVal != "")
            {
                MessageBox.Show("El número de matrícula \""+this.regnumber+"\" le pertenece a "+ regNumVal);
                return false;
            }
            if (usernameVal != "")
            {
                MessageBox.Show("El usuario \"" + this.emailESPOL + "\" le pertenece a " + usernameVal);
                return false;
            }
            if (idVal != "")
            {
                MessageBox.Show("La cedula \"" + this.id + "\" le pertenece a " + idVal);
                return false;
            }
            return true;
        }

        private void insertUser() {

            String query1 = "", query2 = "", query3 = "", query4 = "", query5 = "";
            String idCareer = myReader("SELECT id FROM career WHERE name='" + this.career + "';");
            String idDirectorship = "", idBranch = "";


            if (radioButton_Miembro.Checked)
            {

                /*Inserto Usuario*/
                query1 = "INSERT INTO users (id,name,lastname,username,birthdate,address,phone,cellphone,emailESPOL,emailPersonal,registrationNumber,careerId,userStateId,userTreatmentId,created)" +
                                    " VALUES ('" + this.id + "','" + this.name + "','" + this.lastName + "','" + this.emailESPOL + "','" +
                                    this.birthDate + "','" + this.address + "','" + this.phone + "','" + this.cellPhone +
                                    "','" + this.emailESPOL + "@espol.edu.ec" + "','" + this.personalEmail + "','" + this.regnumber + "','" +
                                    idCareer + "','" + addtoUserState() + "','" + addToUserTreatment() + "',GETDATE());";

                SqlManager.executeQuery(query1,conn);
                
                /*Busco id Directorship*/
                idDirectorship = myReader("SELECT id FROM directorship WHERE name='" + this.directorship + "';");

                //Inserto DirectorshipHistorial

                query2 = "INSERT INTO directorshipHistorial (directorshipId,usersId,observation,chargeTakenDate)" +
                                                "VALUES('" + idDirectorship + "','" + this.id + "','" + this.observationUserDirectorship +
                                                "',GETDATE())";
                SqlManager.executeQuery(query2, conn);

                //Busco idBranch
                idBranch = myReader("SELECT id FROM branch WHERE name='" + this.branchOne + "'");

                //Inserto en user Branch

                query4 = "INSERT INTO userBranch (userId,branchId,observation) VALUES ('" + this.id + "','" + idBranch + "','" + this.branchOneObservation + "');";
                SqlManager.executeQuery(query4, conn);

                //Inserto Segunda Rama

                if(this.branchTwo!="Escoja una Rama")
                {
                    idBranch = myReader("SELECT id FROM branch WHERE name='" + this.branchTwo + "'");
                    query5 = "INSERT INTO userBranch (userId,branchId,observation) VALUES ('" + this.id + "','" + idBranch + "','" + this.branchTwoObservation + "');";
                    SqlManager.executeQuery(query5, conn);
                
                }

            }
            else {

                query3 = "INSERT INTO users (id,name,lastname,username,birthdate,address,phone,cellphone,emailESPOL,emailPersonal,registrationNumber,careerId,userTreatmentId,created)" +
                                    " VALUES ('" + this.id + "','" + this.name + "','" + this.lastName + "','" + this.emailESPOL + "','" +
                                    this.birthDate + "','" + this.address + "','" + this.phone + "','" + this.cellPhone +
                                    "','" + this.emailESPOL + "@espol.edu.ec" + "','" + this.personalEmail + "','" + this.regnumber + "','" +
                                    idCareer + "','" + addToUserTreatment() + "',GETDATE());";

                SqlManager.executeQuery(query3, conn);
            }
        }

        private void ultraComboEditor_RamaUno_ValueChanged(object sender, EventArgs e)
        {
            String branch1 = "";
            ultraComboEditor_RamaDos.Enabled = true;
            ultraTextEditor_ObservacionRamaDos.Enabled = true;
            
            ultraComboEditor_RamaDos.Text = "Escoja una Rama";
            branch1 = ultraComboEditor_RamaUno.Text;
            addItemtoComboEditor(ultraComboEditor_RamaDos, "SELECT name FROM branch WHERE name not in ('" + branch1 + "')");
            ultraComboEditor_RamaDos.Items.Add("Escoja una Rama");

        }

    }


}