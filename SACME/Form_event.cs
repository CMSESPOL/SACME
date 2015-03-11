using System;
using System.Collections.Generic;
using System.Collections;//Necesario para el ArrayList
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Win.UltraWinEditors;
//using Infragistics.Win.UltraWinGrid;
using System.Data.SqlClient;
using System.Data.Common;//DbException


namespace SACME
{
    public partial class Form_event : Form
    {
        public Connector conn;
        private SqlDataReader DR;
        private string sqlString;
        private string sqlStringAdd;
        private string sqlStringRemove;
        private string eventCreator;
        private bool SelectedItems;
        private Form_main formMain;
        private Form_modifyEvent formModify= new Form_modifyEvent();
        private UltraComboEditor idParticipants = new UltraComboEditor();
        private UltraComboEditor idEncargado=new UltraComboEditor();
        ToolTip toolTip = new System.Windows.Forms.ToolTip();
        private String directorshipName;

        /*************************************************************************************************************************************************************/
        /*************************************************************************************************************************************************************/
        /*************************************************************************************************************************************************************/
        public Form_event(Connector conn, Form_main formMain,String directorshipName,string eventCreator)
        {
            InitializeComponent();
            this.conn = conn;
            this.formMain = formMain;
            this.eventCreator=eventCreator;
            this.SelectedItems = true;
            clearRegistryForm();
            
            toolTip.SetToolTip(btnBorrarCampos, "Borrar Campos");
            toolTip.SetToolTip(btnRegistro, "Registrar Evento");
            toolTip.SetToolTip(btnConsulta, "Consultar Evento");

            this.directorshipName = directorshipName;

            if (directorshipName == "CONSEJERO")
            {
                btnRegistro.Visible = false;
                btnConsulta.Location = new Point(250, 4);                
            }
            fillComboBox(this.cmbTipoC, "select * from [SACMEDB].[dbo].[eventType]", "name");
           
            fillComboBox(this.cmbTipoR, "select * from [SACMEDB].[dbo].[eventType]", "name");
            
            fillComboBox(this.cmbRamaEncargadaR, "select * from [SACMEDB].[dbo].[branch]", "name");
        }

        
        
        
        
        
        
        
        
        /*************************************************************************************************************************************************************/
        ///////////////////////////////////////////////////////////////////////////*Buttons*///////////////////////////////////////////////////////////////////////////


        private void btnRegistro_Click(object sender, EventArgs e)
        { 
            this.pnlConsulta.Hide();
            this.btnConsulta.Enabled = true;

            this.pnlRegistro.Show();
            this.btnRegistro.Enabled = false;
        }

        /*************************************************************************************************************************************************************/
        
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.pnlRegistro.Hide();
            this.btnRegistro.Enabled = true;

            this.pnlConsulta.Show();
            this.btnConsulta.Enabled = false;
            this.cmbBuscarPor.SelectedIndex=-1;
            this.dataGridView_Eventos.Rows.Clear();
            this.btnModificar.Visible = false;
        }
        
        /*************************************************************************************************************************************************************/
        
        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            clearRegistryForm();
        }
        
        /*************************************************************************************************************************************************************/
        
        public void btnBuscarPorTipoC_Click(object sender, EventArgs e)
        {
            sqlString = "SELECT[name] as 'NOMBRE DE EVENTO',[description] as 'DESCRIPCION',(SELECT SACMEDB.dbo.users.name + ' ' + SACMEDB.dbo.users.lastname from SACMEDB.dbo.users where id = responsible) as 'RESPONSABLE',[duration] as 'DURACION',[start] as 'FECHA DE INICIO',(select name from [SACMEDB].[dbo].[eventType] where id=eventTypeId) as 'TIPO DE EVENTO',(select name from [SACMEDB].[dbo].[branch] where id=branchId) as 'RAMA ENCARGADA',[created] as 'FECHA DE CREACION',(SELECT SACMEDB.dbo.users.name + ' ' + SACMEDB.dbo.users.lastname from SACMEDB.dbo.users where id = createdBy) as 'CREADO POR' FROM [SACMEDB].[dbo].[event]";
            if (this.cmbBuscarPor.Text == "TIPO")
            {
                if (this.cmbTipoC.Text != "")
                {
                    if (this.txtBuscar.Text == "" || this.txtBuscar.Text == "\r\n")
                        //select * from SACMEDB.dbo.event where eventTypeId =  1 and name like '%GIT%'
                        sqlString = sqlString + " where eventTypeId = (select id from SACMEDB.dbo.eventType where name = '" + this.cmbTipoC.Text + "')";
                    else
                    {
                        sqlString = sqlString + " where eventTypeId = (select id from SACMEDB.dbo.eventType where name = '" + this.cmbTipoC.Text + "') and name like '%" + this.txtBuscar.Text + "%'";
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un Tipo de Proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            else if (this.cmbBuscarPor.Text == "NOMBRE")
            {
                if (this.txtBuscar.Text != "" && this.txtBuscar.Text != "\r\n")
                    sqlString = sqlString + " where name like '%" + this.txtBuscar.Text + "%'";
                else
                {
                    MessageBox.Show("Ingresa algun nombre de evento", "Nombre de evento invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            conn.getConnection();
            SqlManager.loadDataGridView(dataGridView_Eventos, sqlString, conn);

            this.txtBuscar.Text = null;
            this.btnBuscarPorTipoC.Focus();
            
        }
        
        /*************************************************************************************************************************************************************/
        
        private void btnGuardarEvento_Click(object sender, EventArgs e)
        {
            int branchId=0;
            int eventTypeId=0;
            if(isValidRegistryForm())
            {
                try
                {
                    conn.getConnection();
                    DR = SqlManager.getQuery("select id from SACMEDB.dbo.branch where name = '"+this.cmbRamaEncargadaR.Text+"'", conn);
                    if (DR != null)
                        while (DR.Read())
                            branchId = Convert.ToInt32( DR["id"].ToString());
                    DR.Close();
                }
                catch (DbException ex){ MessageBox.Show("No Se Pudo Obtener El Id De La Rama:\n " + ex);}

                try
                {
                    conn.getConnection();
                    DR = SqlManager.getQuery("select id from [SACMEDB].[dbo].[eventType] where name = '" + this.cmbTipoR.Text + "'", conn);
                    if (DR != null)
                        while (DR.Read())
                            eventTypeId = Convert.ToInt32(DR["id"].ToString());
                    DR.Close();
                }
                catch (DbException ex) { MessageBox.Show("No Se Pudo Obtener El Id De La Rama:\n " + ex); }

                Event ev = new Event();
                ev.setName(this.txtNombreR.Text);
                ev.setDescription(this.txtDescripcionR.Text);
                this.idEncargado.SelectedIndex = this.cmbEncargadoR.SelectedIndex;
                ev.setResponsible(idEncargado.SelectedItem.ToString());
                ev.setDuration(this.NumericEditorDuracionR.Value.ToString() +" "+ this.cmbDuracion.Text);
                ev.setStart((DateTime)this.dateFechaDeInicioR.Value);

                ev.setEventTypeId(eventTypeId);
                ev.setBranchId(branchId);
                ev.setCreatedBy(eventCreator);
                insertEvent(ev);

                for (int i = 0; i < this.cmbOrganizadorR.Items.Count; i++)
                {              
                    sqlString = "insert into [SACMEDB].[dbo].[eventOrganizer] (eventId,organizerId) values ((select id from [SACMEDB].[dbo].[event] where name = '" + this.txtNombreR.Text + "' and description = '"+this.txtDescripcionR.Text+"'),(select id from organizers where name = '" + this.cmbOrganizadorR.Items[i].ToString() + "'))";
                    SqlManager.executeQuery(sqlString, conn);
                    
                }

                for (int i = 0; i < this.cmbParticipantesR.Items.Count; i++)
                {
                    sqlString = "insert into [SACMEDB].[dbo].[eventParticipant] (userId,eventId,rol) values ('" + this.idParticipants.Items[i].ToString() + "',(select id from [SACMEDB].[dbo].[event] where name = '" + this.txtNombreR.Text + "' and description = '" + this.txtDescripcionR.Text + "'),'Participante Evento "+this.txtNombreR.Text+"') ";
                    SqlManager.executeQuery(sqlString, conn);
                }
                clearRegistryForm();
                MessageBox.Show("Evento Creado Satisfactoriamente");
            }
        }

        /*************************************************************************************************************************************************************/
        
        private void btnModificar_Click(object sender, EventArgs e)
        {

            ArrayList evento = getSelectedItem(this.dataGridView_Eventos);
            if (SelectedItems)
            {
                string idEvento = null;
                this.formMain.Enabled = false;
                if (evento.Count > 0)
                {
                    sqlString = "select id from [SACMEDB].[dbo].[event] where name = '" + evento[0] + "' and [SACMEDB].[dbo].[event].[description] = '" + evento[1] + "'";
                    try
                    {
                        DR = SqlManager.getQuery(sqlString, conn);
                        if (DR != null)
                            while (DR.Read())
                                idEvento = DR["id"].ToString();
                        DR.Close();
                    }
                    catch (DbException ex)
                    {
                        MessageBox.Show("No se pudo Obtener el Id del Evento:\n " + ex);
                    }
                    formMain.Enabled = false;
                    Form_modifyEvent modify = new Form_modifyEvent(idEvento, formMain, this, DR, conn);
                    modify.Show();
                }
                else
                    MessageBox.Show("No se encontró el evento a buscar:\n ");
            }
        }
        
        /*************************************************************************************************************************************************************/


        





        /*************************************************************************************************************************************************************/
        //////////////////////////////////////////////////////////////////////////*comboBoxes*/////////////////////////////////////////////////////////////////////////
        
        private void cmbOrganizadorR_ValueChanged(object sender, EventArgs e)
        {
            this.cmbOrganizadorR.Text = null;
        }
        
        /*************************************************************************************************************************************************************/
        
        private void cmbBuscarPor_ValueChanged(object sender, EventArgs e)
        {
            dataGridView_Eventos.DataSource = null;
            this.btnModificar.Visible = true;
            if (this.cmbBuscarPor.Text.Equals("TIPO"))
            {
                this.txtBuscar.Visible = true;
                this.cmbTipoC.Visible = true;
                this.btnBuscarPorTipoC.Visible = true;
                this.cmbTipoC.Text = null;

            }
            else if (this.cmbBuscarPor.Text.Equals("NOMBRE"))
            {
                this.cmbTipoC.Visible = false;
                this.txtBuscar.Visible = true;
                this.btnBuscarPorTipoC.Visible = true;
                this.cmbTipoC.Text = null;
            }
            else if (this.cmbBuscarPor.Text.Equals("TODOS"))
            {
                this.txtBuscar.Visible = false;
                this.cmbTipoC.Visible = false;
                this.btnBuscarPorTipoC.Visible = false;
                this.txtBuscar.Text = null;
                this.cmbTipoC.Text = null;
                this.btnBuscarPorTipoC_Click(sender, e);
            }
        }
        
        /*************************************************************************************************************************************************************/

        private void cmbEncargadoR_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ArrayList encargados = new ArrayList();
            if (this.cmbRamaEncargadaR.Text == "")
                MessageBox.Show("Seleccione La Rama Encargada", "Rama Ecargada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.cmbEncargadoR.Items.Clear();
                //sqlString = "select name + ' ' + lastname as 'fullName' from SACMEDB.dbo.users where (SACMEDB.dbo.users.id = (select userId from userBranch where  branchId = (select SACMEDB.dbo.branch.id from branch where name = '" + this.cmbRamaEncargadaR.Text + "')))";
                sqlString = "select userId from userBranch where branchId = (select id from branch where name = '" + this.cmbRamaEncargadaR.Text + "')";
                try
                {

                    DR = SqlManager.getQuery(sqlString, conn);
                    if (DR != null)
                        while (DR.Read())
                        {
                            encargados.Add(DR["userId"].ToString());
                            idEncargado.Items.Add(DR["userId"].ToString());
                        }
                    DR.Close();

                    for (int i = 0; i < encargados.Count; i++)
                    {
                        DR = SqlManager.getQuery("select name +' '+ lastname as 'fullName' from users where id = '" + encargados[i] + "'", conn);
                        if (DR != null)
                            while (DR.Read())
                                this.cmbEncargadoR.Items.Add(DR["fullName"]);
                        DR.Close();
                    }

                }
                catch (DbException ex) { MessageBox.Show("No se pudo Obtener El Encargado:\n " + ex); }

            }
        }
        
        
        /*************************************************************************************************************************************************************/
       
        private void cmbOrganizadorR_EditorButtonClick(object sender, EditorButtonEventArgs e)
        { 
            sqlStringAdd = "select name as'NOMBRE DE ORGANIZADOR', institution as 'INSTITUCION' from organizers where not exists (select name, institution from organizersTmp where name =SACMEDB.dbo.organizers.name)";
            sqlStringRemove = "select name as'NOMBRE DE ORGANIZADOR', institution as 'INSTITUCION' from organizersTmp";
            Form_genericAddRemove g = new Form_genericAddRemove(conn, "Agregar/Remover Organizador(es)", sqlStringAdd, sqlStringRemove, this.cmbOrganizadorR, idParticipants, formMain,formModify, true);
            g.fillDatagridAgregar();
            g.fillDatagridRemover();
            g.Show();
        }

        /*************************************************************************************************************************************************************/

        private void cmbParticipantesR_EditorButtonClick(object sender, EditorButtonEventArgs e)
        {
            sqlStringAdd = "select name + ' ' + lastname as 'NOMBRES',id as 'CEDULA', registrationNumber as 'MATRICULA', emailPersonal as 'CORREO' from users where not exists( select id from usersTmp where id = SACMEDB.dbo.users.id)";
            sqlStringRemove = "select name + ' ' + lastname as 'NOMBRES',id as 'CEDULA', registrationNumber as 'MATRICULA', emailPersonal as 'CORREO' from usersTmp";
            Form_genericAddRemove g = new Form_genericAddRemove(conn, "Agregar/Remover Participante(s)", sqlStringAdd, sqlStringRemove, this.cmbParticipantesR, idParticipants, formMain,formModify, false);
            g.fillDatagridAgregar();
            g.fillDatagridRemover();
            g.Show();
        }

        /*************************************************************************************************************************************************************/





        /*************************************************************************************************************************************************************/
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBuscarPorTipoC_Click(sender, e);
        }
        







        /*************************************************************************************************************************************************************/
      
        private ArrayList getSelectedItem(DataGridView DataGrid)
        {
            
            ArrayList selectedItem = new ArrayList();
            if (DataGrid.SelectedRows.Count > 0)
            {

                int columnas = Convert.ToInt32(DataGrid.Columns.Count);//obtengo el total de columnas que tiene esa fila

                for (int i = 0; i < columnas; i++)
                    selectedItem.Add(DataGrid.Rows[DataGrid.SelectedCells[0].RowIndex].Cells[i].Value);
                SelectedItems = true;
            }
            else
            {
                MessageBox.Show("No hay filas seleccionadas", "Selección de filas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SelectedItems=false;
            }

            return selectedItem;
        }
        
        /*************************************************************************************************************************************************************/

        public string dateToSQL(DateTime date)
        {
            string Date = date.Year + "-" + date.Month + "-" + date.Day;
            return Date;
        }

        /*************************************************************************************************************************************************************/

        private void clearRegistryForm()
        {
            this.txtNombreR.Clear();
            this.txtDescripcionR.Clear();
            this.cmbRamaEncargadaR.Items.Clear();
            this.cmbEncargadoR.Items.Clear();
            this.NumericEditorDuracionR.Value = 0;
            this.cmbDuracion.Text = null;
            this.dateFechaDeInicioR.ResetDateTime();
            this.cmbTipoR.Items.Clear();
            this.cmbOrganizadorR.Items.Clear();
            this.cmbParticipantesR.Items.Clear();
            SqlManager.executeQuery("delete from organizersTmp", conn);
            SqlManager.executeQuery("delete from usersTmp", conn);

        }

        /*************************************************************************************************************************************************************/
        
        private bool isValidRegistryForm() 
        {
            string error = "No se puede ingresar el evento, solucione los siguientes problemas: \n";
            string warning = "";
            DateTime prueba = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string fechaComboBox=dateToSQL(dateFechaDeInicioR.DateTime);
            string fechaNull= dateToSQL(prueba);
            
            if (this.txtNombreR.Text == "")
                error = error + "- Ingresar el nombre del evento\n";

            if (this.txtDescripcionR.Text == "")
                error = error + "- Ingresar la descripción del evento\n";

            if (this.cmbRamaEncargadaR.Text == "")
                error = error + "- Seleccionar una rama encargada\n";

            if (this.cmbEncargadoR.Text == "")
                error = error + "- Agregar un Encargado\n";

            if (this.cmbDuracion.Text == "")
                error = error + "- Seleccionar la duracion del evento\n";

            if (this.NumericEditorDuracionR.Value.ToString().Equals("0"))
                error = error + "- Seleccionar la cantidad de tiempo del evento\n";

            if(this.cmbTipoR.Text == "")
                error = error + "- Seleccionar el tipo de evento\n";

            if(this.cmbOrganizadorR.Items.Count==0)
                error = error + "- Agregar al menos un organizador\n";

            if(fechaComboBox.Equals(fechaNull))
                warning = "La fecha de inicio del evento es la misma de hoy.\n¿Desea modificarla?";



            if (error.Equals("No se puede ingresar el evento, solucione los siguientes problemas: \n"))
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
        
        /*************************************************************************************************************************************************************/
        
        private bool insertEvent(Event e)
        {          
            try
            {
                conn.getConnection();
                this.sqlString = "insert into event(name,description,responsible,duration,start,eventTypeId,branchId,createdBy)" +
                    "VALUES('" + e.getName() + "',"
                                 + "'" + e.getDescription() + "',"
                                 + "'" + e.getResponsible() + "',"
                                 + "'" + e.getDuration() + "',"
                                 + "'" + dateToSQL(e.getStart()) + "',"
                                 + "'" + e.getEventTypeId() + "',"
                                 + "'" + e.getBranchId() + "',"
                                 + "'" + e.getCreatedBy() + "')";
                SqlManager.executeQuery(sqlString, conn);
            }
            catch (DbException ex)
            {
                MessageBox.Show("No se pudo Agregar evento:\n " + ex);
                return false;
            }
            return true;
        }
        
        /*************************************************************************************************************************************************************/
        
        public void fillComboBox(UltraComboEditor u, string sqlString, string campo)
        {
            u.Items.Clear();
            try
            {
                conn.getConnection();
                DR = SqlManager.getQuery(sqlString, conn);
                if (DR != null)
                {
                    while (DR.Read())
                    {
                        u.Items.Add(DR[campo]);
                    }
                }
                DR.Close();
            }
            catch (DbException ex)
            {
                MessageBox.Show("No se pudo Obtener las Ramas:\n " + ex);
            }
        }

        private void dataGridView_Eventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnModificar_Click(sender, new EventArgs());
        }

  


        
        /*************************************************************************************************************************************************************/
        
        



        /*************************************************************************************************************************************************************/
        /*************************************************************************************************************************************************************/
        /*************************************************************************************************************************************************************/





        //private void cmbEncargadoR_BeforeDropDown(object sender, CancelEventArgs e)
        //{
        //    ArrayList encargados = new ArrayList();          
        //    if (this.cmbRamaEncargadaR.Text == "")
        //        MessageBox.Show("Seleccione La Rama Encargada", "Rama Ecargada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    else
        //    {
        //        this.cmbEncargadoR.Items.Clear();
        //        //sqlString = "select name + ' ' + lastname as 'fullName' from SACMEDB.dbo.users where (SACMEDB.dbo.users.id = (select userId from userBranch where  branchId = (select SACMEDB.dbo.branch.id from branch where name = '" + this.cmbRamaEncargadaR.Text + "')))";
        //        sqlString = "select name + ' ' + lastname as 'fullName' from SACMEDB.dbo.users where id = ANY (select userId from userBranch where  branchId =  (select id from SACMEDB.dbo.branch where name = '" + this.cmbRamaEncargadaR.Text + "'))";
        //        fillComboBox(this.cmbEncargadoR, sqlString, "fullName");
        //        //////SqlManager.executeQuery(sqlString, conn);
        //        ////sqlString = "select userId from userBranch where branchId = (select id from branch where name = '" + this.cmbRamaEncargadaR.Text + "')";
        //        ////try
        //        ////{

        //        ////    DR = SqlManager.getQuery(sqlString, conn);
        //        ////    if (DR != null)
        //        ////        while (DR.Read())
        //        ////        {
        //        ////            encargados.Add(DR["userId"].ToString());
        //        ////            idEncargado.Items.Add(DR["userId"].ToString());
        //        ////        }
        //        ////    DR.Close();

        //        //for (int i = 0; i < encargados.Count; i++)
        //        //{
        //        //    DR = SqlManager.getQuery("select name +' '+ lastname as 'fullName' from users where id = '" + encargados[i] + "'", conn);
        //        //    if (DR != null)
        //        //        while (DR.Read())
        //        //            this.cmbEncargadoR.Items.Add(DR["fullName"]);
        //        //    DR.Close();
        //        //}

        //        ////}catch (DbException ex){MessageBox.Show("No se pudo Obtener El Encargado:\n " + ex);}

        //    }
        //}
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        ///*Buttons Left -Add- */
        //private void btnAddBranch_Click(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        //{
        //    MessageBox.Show("Presionaste + Branch");
        //}
        //private void btnAddResponsible_Click(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        //{
        //    MessageBox.Show("Presionaste + Responsible");
        //}
        //private void btnAddOrganizer_Click(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        //{
        //    Form_genericAddRemove g = new Form_genericAddRemove(conn, "Agregar/Remover Organizador(es)");
        //    g.Show();
        //}
        //private void btnAddParticipants_Click(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        //{
        //    Form_addParticipants p = new Form_addParticipants();
        //    p.Show();
        //}
        ///*Buttons Left -Delete- */
        //private void btnDeleteBranch_Click(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        //{
        //    MessageBox.Show("Presionaste - Branch");
        //}
        //private void btnDeleteResponsible_Click(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        //{
        //    MessageBox.Show("Presionaste - Responsible");
        //}
        //private void btnDeleteOrganizer_Click(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        //{
        //    MessageBox.Show("Presionaste - Organizer");
        //}
        //private void btnDeleteParticipants_Click(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        //{
        //    MessageBox.Show("Presionaste - Participants");
        //}
        ///*addButtonsLeft*/
        //private void addButtonsLeft()
        //{
        //    Infragistics.Win.Appearance add = new Infragistics.Win.Appearance();
        //    Infragistics.Win.Appearance delete = new Infragistics.Win.Appearance();
        //    add.Image = global::SACME.Properties.Resources.Add;
        //    delete.Image = global::SACME.Properties.Resources.Delete;

        //    //// 
        //    //// cmbRamaEncargadaR
        //    ////
        //    //EditorButton addBranch = new EditorButton();
        //    //EditorButton deleteBranch = new EditorButton();
        //    //addBranch.Appearance = add;
        //    //deleteBranch.Appearance = delete;
        //    //this.cmbRamaEncargadaR.ButtonsLeft.Add(addBranch);
        //    //this.cmbRamaEncargadaR.ButtonsLeft.Add(deleteBranch);
        //    //addBranch.Click += btnAddBranch_Click;
        //    //deleteBranch.Click += btnDeleteBranch_Click;

        //    //// 
        //    //// cmbEncargadoR
        //    ////
        //    //EditorButton addResponsible = new EditorButton();
        //    //EditorButton deleteResponsible = new EditorButton();
        //    //addResponsible.Appearance = add;
        //    //deleteResponsible.Appearance = delete;
        //    //this.cmbEncargadoR.ButtonsLeft.Add(addResponsible);
        //    //this.cmbEncargadoR.ButtonsLeft.Add(deleteResponsible);
        //    //addResponsible.Click += btnAddResponsible_Click;
        //    //deleteResponsible.Click += btnDeleteResponsible_Click;

        //    // cmbOrganizadorR
        //    //
        //    EditorButton addOrganizer = new EditorButton();
        //    EditorButton deleteOrganizer = new EditorButton();
        //    addOrganizer.Appearance = add;
        //    deleteOrganizer.Appearance = delete;
        //    this.cmbOrganizadorR.ButtonsLeft.Add(addOrganizer);
        //    this.cmbOrganizadorR.ButtonsLeft.Add(deleteOrganizer);
        //    addOrganizer.Click += btnAddOrganizer_Click;
        //    deleteOrganizer.Click += btnDeleteOrganizer_Click;

        //    // 
        //    // cmbParticipantes
        //    //
        //    EditorButton addParticipants = new EditorButton();
        //    EditorButton deleteParticipants = new EditorButton();
        //    addParticipants.Appearance = add;
        //    deleteParticipants.Appearance = delete;
        //    this.cmbParticipantesR.ButtonsLeft.Add(addParticipants);
        //    this.cmbParticipantesR.ButtonsLeft.Add(deleteParticipants);
        //    addParticipants.Click += btnAddParticipants_Click;
        //    deleteParticipants.Click += btnDeleteParticipants_Click;
        //}

     
        


    }    
}
