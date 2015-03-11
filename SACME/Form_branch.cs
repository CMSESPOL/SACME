using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using System.Data.SqlClient;
using System.Data.Common;
using SACME;

namespace SACME
{
    /**<summary>Form_branch es la clase donde se maneja los objetos y funciones del formulario de branch </summary> */
    public partial class Form_branch : Form
    {
        public Connector conn;
        private string sqlString;
        private SqlDataReader DR;
        private string ex;

        /**<summary>Constructor de la clase Form_branch </summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="conn">Objeto que maneja la conexion a la base de datos</param>*/
        /**<param name="directorshipName">Parametro que maneja el rol del usuario que ha iniciado sesion en el sistema</param>*/
        public Form_branch(Connector conn,String directorshipName)
        {
            InitializeComponent();
            this.conn = conn;
            this.btnModificar.Visible = false;
            this.cmbState.Items.Clear();
            this.cmbState.Items.Add("Activado");
            this.cmbState.Items.Add("Desactivado");
            this.txtSearchName.Visible = false;
            this.cmbStated.Visible = false;
            this.pnlRegisterBranch.Hide();
            this.pnlConsulta.Hide();
            this.dataGridView_Branch.AllowUserToAddRows = false;
            this.dataGridView_Branch.AllowUserToDeleteRows = false;
            this.dataGridView_Branch.AllowUserToResizeColumns = false;
            this.dataGridView_Branch.AllowUserToResizeRows = false;

            if (directorshipName == "CONSEJERO")
            {
                btnRegisterBranch.Visible = false;
                btnConsultBranch.Location = new Point(250, 4);                
            }
         }

        /**<summary>Metodo que maneja el evento de clic en el boton registrar rama </summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="sender">Objeto</param>*/
        /**<param name="e">Evento</param>*/
        private void btnRegisterBranch_Click(object sender, EventArgs e)
        {
            this.pnlRegisterBranch.Show();
            this.pnlConsulta.Hide();
        }

        /**<summary>Metodo que maneja el evento de clic en el boton consutar rama </summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="sender">Objeto</param>*/
        /**<param name="e">Evento</param>*/
        private void btnConsultBranch_Click_1(object sender, EventArgs e)
        {
            this.pnlConsulta.Show();
            this.pnlRegisterBranch.Hide();
            this.btnSearch.Hide();
        }

        /**<summary>Metodo encargado de validar los campos del formulario de registro de rama</summary> */
        /**<return>Retorna true cuando el formulario es valido. Retorna false cuando es invalido </return>*/
        private bool isValidRegistryForm()
        {
            string error = "No se puede registrar la rama, solucione los siguientes problemas: \n";
            string warning = "";
            DateTime prueba = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            if (this.txtNameBranch.Text == "")
                error = error + "- Ingresar el nombre de rama\n";
            
            if (this.txtShortName.Text == "")
                error = error + "- Ingresar el alias de la rama\n";
            
            if (this.cmbState.Text == "Seleccione un estado")
                error = error + "- Seleccionar estado para la rama\n";
            if (error.Equals("No se puede registrar la rama, solucione los siguientes problemas: \n"))
            {
                if (warning != "")
                {
                    DialogResult dialogo = MessageBox.Show(warning, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogo == DialogResult.Yes)
                        return false;
                }
                return true;
            }
            else
            {
                MessageBox.Show(error, "Campos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /**<summary>Metodo que maneja el evento de clic en el boton guardar rama. 
         * Antes de guardar la rama verifica que no haya ningun problema </summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="sender">Objeto</param>*/
        /**<param name="e">Evento</param>*/
        private void btnSave_Click(object sender, EventArgs b)
        {
            if (isValidRegistryForm())
            {
                try
                {
                    conn.getConnection();
                    Branch br = new Branch();
                    Branch resultB = new Branch();
                    br.setName(this.txtNameBranch.Text);
                    br.setShortName(this.txtShortName.Text);
                    String state = this.cmbState.Value.ToString();
                    DateTime thisDay = DateTime.Today;
                    if (state == "Activado")
                    {
                        br.setIsEnable(true);}
                    else
                    {
                        br.setIsEnable(false);}
                    
                    resultB=isExitsBranch(br);
                    if (resultB.getName() == null)
                     {
                        sqlString = "insert into branch (name,shortName, isEnable)VALUES('" + br.getName() + "',"
                                      + "'" + br.getShortName() + "','" + br.getIsEnable() + "')";
                        MessageBox.Show(sqlString);
                        bool result = SqlManager.executeQuery(sqlString, conn);
                        MessageBox.Show(result.ToString());
                        if (result)
                        {
                            MessageBox.Show("Rama registrada con exito ");
                            emptyFieldForm();
                        }
                        else
                        {   MessageBox.Show("No se pudo guardar los datos");  }
                    }
                    else {
                        MessageBox.Show("La rama ya se encuentra registrada en el sistema\n ");
                        emptyFieldForm();
                    }
                }
                catch (Exception ex)
                {
                    emptyFieldForm();
                    MessageBox.Show("La rama ya se encuentra registrada en el sistema\n ");
                }
             }
        }

        /**<summary>Metodo verifica si la rama a registrar no existe en el sistema</summary> */
        /**<return> Devuelve la rama encontrada en caso de que exista en el sistema. 
         * Devuelve null en caso de que no exista</return>*/
        /**<param name="sender">Objeto</param>*/
        /**<param name="e">Evento</param>*/
        private Branch isExitsBranch(Branch br) {
            Branch brx = new Branch();
            sqlString = "select name,shortName from branch where name like '%" + br.getName() + "%' OR shortName like '%" + br.getShortName() + "%';";
            DR = SqlManager.getQuery(sqlString, conn);
            
            if (DR != null)
            {
                while (DR.Read())
                {
                    brx.setName((String)(DR["name"]));
                    brx.setShortName((String)(DR["shortName"]));
                }
            }
            DR.Close();
            return brx;
        }

        /**<summary>Metodo que limpia todos los campos de formulario Branch </summary> */
        /**<return> No devuelve nada </return>*/
        private void emptyFieldForm()
        {
            this.txtNameBranch.Text = "";
            this.txtShortName.Text = "";
            this.cmbState.Text = "Seleccione un estado";
        }

        /**<summary>Metodo que maneja las acciones al cambiar el combo relacionado con los valores de busqueda.
         * En este caso son dos: nombres y estado </summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="sender">Objeto</param>*/
        /**<param name="e">Evento</param>*/
        private void cmbSearchBy_ValueChanged(object sender, EventArgs e)
        {
            dataGridView_Branch.DataSource = null;
            if (this.cmbSearchBy.Text.Equals("Nombre"))
            {
                this.txtSearchName.Text = "";
                this.txtSearchName.Visible = true;
                this.btnSearch.Visible = true;
                this.cmbStated.Visible = false;
            }else 
            {
                this.txtSearchName.Text = "";
                this.cmbStated.Visible = true;
                this.txtSearchName.Visible = false;
                this.btnSearch.Visible = false;
             }
        }

        /**<summary>Metodo que maneja la accion al cambiar el combo relacionado con el estado. 
         * Segun el estado se muestra las ramas.</summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="sender">Objeto</param>*/
        /**<param name="e">Evento</param>*/
        private void cmbStated_ValueChanged(object sender, EventArgs e)
        {
            try {
                String estado = this.cmbStated.Value.ToString();
                int estadoEntero;
                if (estado == "Activado")
                {
                    estadoEntero = 1;
                }
                else {
                    estadoEntero = 0;
                }

                sqlString = "SELECT [id] as '#', [name] as 'NOMBRE DE RAMA', [shortName] as 'ALIAS DE RAMA', [isEnable] as 'Estado',[created] as 'FECHA DE CREACION'" +
                        "FROM [SACMEDB].[dbo].[branch] where isEnable="+estadoEntero+"";
                SqlManager.loadDataGridView(dataGridView_Branch, sqlString, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error"+ex);
            }
          }

        /**<summary>Metodo que maneja el evento de clic en el boton consultar/actualizar rama.
         * Toma el id de la fila del GridLayout y segun eso realiza la busqueda de la rama que coincida con el id. 
         * Muestra los datos en una nueva ventana</summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="sender">Objeto</param>*/
        /**<param name="e">Evento</param>*/
        private void btnConsult_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =dataGridView_Branch.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                int numFila;
                try{
                    String fila = this.dataGridView_Branch.SelectedRows[selectedRowCount - 1].Index.ToString();
                    numFila = Int32.Parse(fila);
                    string idRama = this.dataGridView_Branch[0, numFila].Value.ToString();
                    int idBranch = Int32.Parse(idRama);
                    sqlString = "select name,shortName, isEnable, created from branch where id='" + idBranch + "';";
                    DR = SqlManager.getQuery(sqlString, conn);
                    Branch br=new Branch();
                    br.setId(idBranch);
                    if (DR != null)
                    {
                        while (DR.Read())
                        {
                            br.setName((String)(DR["name"]));
                            br.setShortName((String)(DR["shortName"]));
                            br.setIsEnable((bool)(DR["isEnable"]));
                            br.setCreated((DateTime)(DR["created"]));
                        }
                    }
                    DR.Close();
                   Form_uploadDataBranch consulta = new Form_uploadDataBranch(br, conn);
                   consulta.Show();
                 }

                catch (Exception ex)
                {
                    MessageBox.Show("Disculpe las molestias.Se produjo un error inesperado:\n " + ex);
                }
            }
            else {
                MessageBox.Show("Para consultar debe elegir una rama de la lista");
            }
        }

        /**<summary>Metodo que realiza la busqueda por nombre de una rama</summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="sender">Objeto</param>*/
        /**<param name="e">Evento</param>*/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String parametro = this.cmbSearchBy.Value.ToString();
            try
            {
                if (parametro == "Nombre")
                {
                    String nameSearch = this.txtSearchName.Text;
                    this.cmbStated.Visible = false;
                    sqlString = "SELECT [id] as '#', [name] as 'NOMBRE DE RAMA', [shortName] as 'ALIAS DE RAMA',[isEnable] as 'Estado',[created] as 'FECHA DE CREACION'" +
                            "FROM [SACMEDB].[dbo].[branch] where name like '%" + nameSearch + "%'";
                    SqlManager.loadDataGridView(dataGridView_Branch, sqlString, conn);
                }
                else
                {
                    this.cmbStated.Visible = true;
                    this.txtSearchName.Visible = false;

                }
            }
            catch (Exception ex)
            {
                string ex1 = ex.ToString();
                MessageBox.Show("No existen datos que se ajusten\na sus parametros de busqueda");
            }
        }

        /**<summary>Metodo que maneja el evento de clic en el boton cancelar que se encuentra en el
         * panel de registro de rama</summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="sender">Objeto</param>*/
        /**<param name="e">Evento</param>*/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.pnlConsulta.Hide();
            this.pnlRegisterBranch.Hide();
        }

        /**<summary>Metodo que maneja el evento de clic en el boton cancelar que se encuentra en 
         * el panel de consulta </summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="sender">Objeto</param>*/
        /**<param name="e">Evento</param>*/
        private void btnCancelar_cons_Click(object sender, EventArgs e)
        {
            this.pnlBranch.Hide();
        }
    }
}
