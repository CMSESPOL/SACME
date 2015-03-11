using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data.Common;
using Infragistics.Win.UltraWinEditors;
namespace SACME
{
    public partial class Form_modifyEvent : Form
    {
        public Connector conn;
        private SqlDataReader DR;
        Form_main formMain;
        Form_event formEvent;
        string idEvento;
        string sqlString;
        private string fechaInicioOriginal;
        private UltraComboEditor cmbEncargadosId = new UltraComboEditor();
        private UltraComboEditor cmbOrganizadoresM = new UltraComboEditor();
        private UltraComboEditor cmbIdParticipantesM = new UltraComboEditor();
        private UltraComboEditor cmbParticipantesM = new UltraComboEditor();
        public ArrayList eventoBase;
        public ArrayList eventoForm;
        

        public Form_modifyEvent(){}
        public Form_modifyEvent(string idEvento,Form_main formMain,Form_event formEvent,SqlDataReader DR, Connector conn)
        {
            InitializeComponent();
            this.idEvento = idEvento;
            this.formMain = formMain;
            this.formEvent = formEvent;
            this.DR = DR;
            this.conn = conn;
            this.sqlString = null;
            this.eventoBase = new ArrayList();
            this.eventoForm = new ArrayList();
            
            if (idEvento.Length>0)
            {
                sqlString = "select * from SACMEDB.dbo.event where id = '" + idEvento + "'";
                fillArrayList(eventoBase, sqlString);
                sqlString = "SELECT [id] as 'ID', [name] as 'NOMBRE DE EVENTO',[description] as 'DESCRIPCION',(SELECT SACMEDB.dbo.users.name + ' ' + SACMEDB.dbo.users.lastname from SACMEDB.dbo.users where id = responsible) as 'RESPONSABLE',[duration] as 'DURACION',[start] as 'FECHA DE INICIO',(select name from [SACMEDB].[dbo].[eventType] where id=eventTypeId) as 'TIPO DE EVENTO',(select name from [SACMEDB].[dbo].[branch] where id=branchId) as 'RAMA ENCARGADA',[created] as 'FECHA DE CREACION',(SELECT SACMEDB.dbo.users.name + ' ' + SACMEDB.dbo.users.lastname from SACMEDB.dbo.users where id = createdBy) as 'CREADO POR' FROM [SACMEDB].[dbo].[event]  where id = '" + idEvento + "'";
                fillArrayList(eventoForm, sqlString);


                SqlManager.executeQuery("delete from organizersTmp", conn);
                sqlString = "INSERT INTO [SACMEDB].[dbo].[organizersTmp]([name],[institution]) select name,institution from [SACMEDB].[dbo].[organizers] where id = any (select organizerId from [SACMEDB].[dbo].[eventOrganizer] where  eventOrganizer.eventId =  '" + idEvento + "')";
                SqlManager.executeQuery(sqlString, conn);


                SqlManager.executeQuery("delete from usersTmp", conn);
                sqlString = "INSERT INTO [SACMEDB].[dbo].[usersTmp] select * from [SACMEDB].[dbo].[users] where id = any(select userId from eventParticipant where eventId = '"+idEvento+"')";
                SqlManager.executeQuery(sqlString, conn);


                actualizarDataGrids();
                /*
                 * 0)id___________________int
                 * 1)nombre
                 * 2)descripcion
                 * 3)encargado
                 * 4)duracion
                 * 5)fecha de inicio______date
                 * 6)tipo de evento_______int 
                 * 7)id de rama___________int
                 * 8)fecha de creacion____date
                 * 9)creado por
                 */

                this.txtNombreM.Text = eventoForm[1].ToString();
                this.txtDescripcionM.Text = eventoForm[2].ToString();
                this.txtEncargadoM.Text = eventoForm[3].ToString();
                this.txtDuracionM.Text = eventoForm[4].ToString();
                this.dateFechaInicioM.Text = eventoForm[5].ToString(); fechaInicioOriginal = eventoForm[5].ToString();
                this.txtTipoM.Text = eventoForm[6].ToString(); 
                this.txtRamaEncargadaM.Text = eventoForm[7].ToString();
            }
        }
       

        private void Form_modifyEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.formMain.Enabled = true;
            this.formEvent.btnBuscarPorTipoC_Click(new object(),new EventArgs());//Para Actualizar el DataGridEventos
            SqlManager.executeQuery("delete from organizersTmp", conn);
            SqlManager.executeQuery("delete from usersTmp", conn);
        }





        private void btnCancelarM_Click(object sender, EventArgs e)
        {
            this.Close();
            this.formMain.Enabled = true;
        }

        private void btnEliminarEvento_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Esta seguro(a) de querer eliminar este evento?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogo == DialogResult.Yes)
            {
                if (SqlManager.executeQuery("delete from eventParticipant where eventId = '" + idEvento + "'; delete from eventOrganizer where eventId = '" + idEvento + "'; delete from event where id = '" + idEvento + "'", conn))
                {
                    MessageBox.Show("El Evento fue eliminado satisfactoriamente", "Evento Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if (this.ultraTabDataGrids.SelectedTab.Index == 0)
            {

                string sqlStringAdd = "select name as'NOMBRE DE ORGANIZADOR', institution as 'INSTITUCION' from organizers where not exists (select name, institution from organizersTmp where name =SACMEDB.dbo.organizers.name)";
                string sqlStringRemove = "select name as'NOMBRE DE ORGANIZADOR', institution as 'INSTITUCION' from organizersTmp";
                UltraComboEditor u = new UltraComboEditor();
                Form_genericAddRemove g = new Form_genericAddRemove(conn, "Agregar/Remover Organizador(es)", sqlStringAdd, sqlStringRemove, cmbOrganizadoresM, cmbIdParticipantesM, formMain, this, true);
                g.fillDatagridAgregar();
                g.fillDatagridRemover();
                g.Show();
            }
            else if (this.ultraTabDataGrids.SelectedTab.Index == 1)
            {
                string sqlStringAdd = "select name + ' ' + lastname as 'NOMBRES',id as 'CEDULA', registrationNumber as 'MATRICULA', emailPersonal as 'CORREO' from users where not exists( select id from usersTmp where id = SACMEDB.dbo.users.id)";
                string sqlStringRemove = "select name + ' ' + lastname as 'NOMBRES',id as 'CEDULA', registrationNumber as 'MATRICULA', emailPersonal as 'CORREO' from usersTmp";
                UltraComboEditor u = new UltraComboEditor();
                Form_genericAddRemove g = new Form_genericAddRemove(conn, "Agregar/Remover Participante(s)", sqlStringAdd, sqlStringRemove, cmbParticipantesM, cmbIdParticipantesM, formMain, this, false);
                g.fillDatagridAgregar();
                g.fillDatagridRemover();
                g.Show();
            }
        }

        private void btnGuardarM_Click(object sender, EventArgs e)
        {
            bool cambiosValidos = false;
            int j = 0;
            if (this.checkBoxFechaInicio.Checked)
                if (Convert.ToDateTime(fechaInicioOriginal).CompareTo(DateTime.Today) < 0)
                    MessageBox.Show("No puede seleccionar una fecha del pasado", "Fecha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (Convert.ToDateTime(fechaInicioOriginal).CompareTo(DateTime.Today) == 0)
                    MessageBox.Show("El evento es HOY, no puede cambiar la fecha", "Fecha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    cambiosValidos = true;

            if (cambiosValidos)
            {
                if (checkBoxFechaInicio.Checked)
                {
                    sqlString = "update SACMEDB.dbo.event set start = '" + formEvent.dateToSQL(this.dateFechaInicioM.DateTime) + "' where id = '" + idEvento + "'";
                    SqlManager.executeQuery(sqlString, conn);
                    this.fechaInicioOriginal = formEvent.dateToSQL(dateFechaInicioM.DateTime);
                    this.dateFechaInicioM.DateTime = Convert.ToDateTime(fechaInicioOriginal);
                }
            }



            if (this.checkBoxEncargado.Checked)
                if (this.cmbEncargadoM.Text == "")
                    MessageBox.Show("No ha seleccionado a un encargado", "Encargado Sin especificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    cambiosValidos = true;
            if (cambiosValidos)
            {

                if (checkBoxEncargado.Checked)
                {
                    this.cmbEncargadosId.SelectedIndex = this.cmbEncargadoM.SelectedIndex;
                    sqlString = "update SACMEDB.dbo.event set responsible = '" + cmbEncargadosId.SelectedItem.ToString() + "' where id = '" + idEvento + "'";
                    SqlManager.executeQuery(sqlString, conn);

                }
            }



            sqlString = "delete from eventParticipant where eventId = '" + idEvento + "'; delete from eventOrganizer where eventId = '" + idEvento + "'";

            for (int i = 0; i < this.cmbOrganizadoresM.Items.Count; i++)
            {
                sqlString = "insert into [SACMEDB].[dbo].[eventOrganizer] (eventId,organizerId) values ((select id from [SACMEDB].[dbo].[event] where name = '" + this.txtNombreM.Text + "' and description = '" + this.txtDescripcionM.Text + "'),(select id from organizers where name = '" + this.cmbOrganizadoresM.Items[i].ToString() + "'))";
                SqlManager.executeQuery(sqlString, conn);
                j++;
            }

            for (int i = 0; i < this.cmbIdParticipantesM.Items.Count; i++)
            {
                sqlString = "insert into [SACMEDB].[dbo].[eventParticipant] (userId,eventId,rol) values ('" + this.cmbIdParticipantesM.Items[i].ToString() + "',(select id from [SACMEDB].[dbo].[event] where name = '" + this.txtNombreM.Text + "' and description = '" + this.txtDescripcionM.Text + "'),'Participante Evento " + this.txtNombreM.Text + "') ";
                SqlManager.executeQuery(sqlString, conn);
                j++;
            }
            if (cambiosValidos)
                MessageBox.Show("Cambios Guardados");

            if (j > 0)
                MessageBox.Show("Organizadores o Participantes Actualizados");
        }




        private void checkBoxFechaInicio_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBoxFechaInicio.Checked)
                this.dateFechaInicioM.ReadOnly = false;
            else
                this.dateFechaInicioM.ReadOnly = true;
        }

        private void checkBoxEncargado_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxEncargado.Checked)
            {
                this.txtEncargadoM.Visible = false;
                
                sqlString = "select name + ' ' + lastname as 'fullName' from SACMEDB.dbo.users where id = ANY (select userId from userBranch where  branchId =  (select id from SACMEDB.dbo.branch where name = '" + eventoForm[7] + "') and NOT userId = '"+eventoBase[3]+"')";
                this.formEvent.fillComboBox(this.cmbEncargadoM, sqlString, "fullName");

                sqlString = "select id from SACMEDB.dbo.users where id = ANY (select userId from userBranch where  branchId =  (select id from SACMEDB.dbo.branch where name = '" + eventoForm[7] + "') and NOT userId = '" + eventoBase[3] + "')";
                this.formEvent.fillComboBox(cmbEncargadosId, sqlString, "id");
                this.cmbEncargadoM.Visible = true;
            }
            else
            {
                this.txtEncargadoM.Visible = true;
                this.cmbEncargadoM.Visible = false;
            }
        }



        public void actualizarDataGrids()
        {

            sqlString = "select name as'ORGANIZADOR',institution as 'INSTITUCION' from SACMEDB.dbo.OrganizersTmp";
            SqlManager.loadDataGridView(dataGridOrganizadores, sqlString, conn);

            //sqlString = "select (select name+' '+lastname from users where id= userId)as'NOMBRES',rol as 'ROL', registeredDate as'FECHA DE REGISTRO'  from SACMEDB.dbo.eventParticipant where eventId = '" + idEvento + "'";
            sqlString = "select name + ' ' + lastname as 'NOMBRES',id as 'CEDULA', registrationNumber as 'MATRICULA', emailPersonal as 'CORREO' from usersTmp";
            SqlManager.loadDataGridView(dataGridParticipantes, sqlString, conn);
        }
        
        private bool fillArrayList(ArrayList a, string query)
        {
            try
            {
                conn.getConnection();
                DR = SqlManager.getQuery(sqlString, conn);
                if (DR != null)
                    while (DR.Read())
                        for (int i = 0; i < DR.FieldCount; i++)
                            a.Add(DR[i].ToString());
                DR.Close();
            }
            catch (DbException ex)
            {
                MessageBox.Show("No se pudo Llenar el Arraylist:\n " + ex);
            }

            if (a.Count > 0)
                return true;
            else
                return false;
        }




        
       

    }
}
