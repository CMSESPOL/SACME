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
    /**<summary>Form_uploadDataBranch es la clase encargada de manejar el formulacion de actualizacion de una rama especifica </summary> */
    public partial class Form_uploadDataBranch : Form
    {
        public Connector conn;
        private string sqlString;
        private Branch br;

        /**<summary>Constructor de la clase Form_uploadDataBranch. Inicializa los componentes del Form</summary> */
        /**<return> No devuelve nada </return>*/
        public Form_uploadDataBranch()
        {
            InitializeComponent();
        }

        /**<summary>Metodo que se encarga de cargar la rama seleccionada al momento de consultar.
         * Ademas setea los componentes del Form</summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="b">Rama a modificar</param>*/
        /**<param name="conn1">Conexion a la base de datos</param>*/
        public Form_uploadDataBranch(Branch b, Connector conn1)
        {
            this.conn = conn1;
            this.br=b;
            InitializeComponent();
            this.MaximizeBox = false;
            this.txtNameBranch_up.Text = b.getName();
            this.txtShorNamet_up.Text = b.getShortName();
            bool statedTmp = b.getIsEnable();
            if (statedTmp.ToString() == "True")
            {
               this.cmbState_up.Value = "Activado";
            }
            else
            {
               this.cmbState_up.Value = "Desactivado";
            }
            this.dateCreateBranch_up.Value = b.getCreated();
       }

        /**<summary>Metodo que maneja el evento click del boton Actualizar. Actualiza los datos 
         * de la rama en la base de datos</summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="sender">Objeto</param>*/
        /**<param name="e">Evento</param>*/ 
        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                conn.getConnection();
                Branch br1=new Branch();
                br1.setName(this.txtNameBranch_up.Text);
                br1.setShortName(this.txtShorNamet_up.Text);
                String state = this.cmbState_up.Value.ToString();
                if (state=="Activado"){
                    br1.setIsEnable(true);}
                else {
                    br1.setIsEnable(false);}
                br1.setCreated((DateTime)this.dateCreateBranch_up.Value);

                int idB=br.getId();
                sqlString = "update branch set name='" + br1.getName() + "', shortName='" +br1.getShortName() +"', isEnable='" + br1.getIsEnable() + "'" +
                                 "where id='" + idB + "'";
                                 
                bool result = SqlManager.executeQuery(sqlString, conn);
                if (result)
                {
                    MessageBox.Show("Datos actualizados con exito ");
                    this.habilitarDeshabilitarCampos(false);
                }else
                {
                    MessageBox.Show("No se pudo guardar los datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la rama:\n " + ex);
            }
        }

        /**<summary>Metodo que maneja el evento de clic en el boton Habilitar Campos.</summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="sender">Objeto</param>*/
        /**<param name="e">Evento</param>*/
        private void btnHabilitarCampos_Click(object sender, EventArgs e)
        {
            this.habilitarDeshabilitarCampos(true);
        }

        /**<summary>Metodo que habilita o deshabilita los componentes del Form segun el parametro enviado</summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="estado">si es true habilita los campos caso contrario los deshabilita</param>*/
        private void habilitarDeshabilitarCampos(bool estado)
        {
            this.txtNameBranch_up.Enabled = estado;
            this.txtShorNamet_up.Enabled = estado;
            this.cmbState_up.Enabled = estado;
            this.btnUpload.Enabled = estado;
        }

        /**<summary>Metodo que maneja el evento de clic en el boton cancelar del Form</summary> */
        /**<return> No devuelve nada </return>*/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
   
}
