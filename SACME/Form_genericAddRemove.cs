using System;
using System.Collections.Generic;
using System.Collections; //Necesario para el ArrayList
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Infragistics.Win.UltraWinEditors;//UltraComboBoxEditor
namespace SACME
{
    public partial class Form_genericAddRemove : Form
    {

        public Connector conn;
        private string sqlStringAdd;
        private string sqlStringRemove;
        private Form_main formMain;
        private Form_modifyEvent formModify;
        private int row=0;
        private bool b;
        private UltraComboEditor comboBox;
        private UltraComboEditor idParticipants;
        public Form_genericAddRemove(Connector conn, string titulo, string sqlStringAdd, string sqlStringRemove, UltraComboEditor comboBox, UltraComboEditor idParticipants, Form_main formMain, Form_modifyEvent formModify, bool b)
        {
            InitializeComponent();
            this.Text = titulo;
            this.conn = conn;
            this.sqlStringAdd = sqlStringAdd;
            this.sqlStringRemove = sqlStringRemove;
            this.comboBox = comboBox;
            this.idParticipants = idParticipants;
            this.formMain = formMain;
            this.formModify = formModify;
            this.b = b;
            formMain.Enabled = false;
            
        }


        public void fillDatagridAgregar()
        {
            SqlManager.loadDataGridView(dataGridAgregar, sqlStringAdd, conn);
        }

        public void fillDatagridRemover()
        {
            SqlManager.loadDataGridView(dataGridRemover, sqlStringRemove, conn);
        }

        public void DataGridViewGetSelectedRow(DataGridView grid)
        {
            int fila = grid.RowCount;
            int columna = grid.ColumnCount;
            
        }

        private void dataGridAgregar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                addToDataGridAgregar(e.RowIndex,e.ColumnIndex,b);
            }
        }

        private void dataGridRemover_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                addToDataGridRemover(e.RowIndex, e.ColumnIndex,b);
            }
        }

        private void dataGridAgregar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addToDataGridAgregar(e.RowIndex,e.ColumnIndex,b);
        }
       
        private void dataGridRemover_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addToDataGridRemover(e.RowIndex,e.ColumnIndex,b);
        }


        public void addToDataGridAgregar(int row, int column, bool b)
        {
            this.row = row;
            if (row != -1)
            {
                int columnas = Convert.ToInt32(this.dataGridAgregar.Columns.Count);//obtengo el total de columnas que tiene esa fila
                string[] seleccionado = new string[columnas - 1];//En mi caso pongo el -1 porque tengo un boton y cuenta como otra celda mas
                string query;
                if (b)
                {
                    query = "insert into organizersTmp (name,institution) values (";
                    for (int i = 1; i < columnas; i++)
                    {
                        seleccionado[i - 1] = this.dataGridAgregar.Rows[row].Cells[i].Value.ToString();
                        if (i == columnas - 1)
                            query = query + "'" + seleccionado[i - 1] + "')";
                        else
                            query = query + "'" + seleccionado[i - 1] + "',";
                    }
                }
                else
                {

                    query = "insert into usersTmp ([id],[name],[lastname],[username],[password],[birthDate],[address],[phone],[cellphone],[emailEspol],[emailPersonal],[registrationNumber],[careerId],[userStateId],[userTreatmentId],[created])" +
                            "(select * from users where id = '" + this.dataGridAgregar.Rows[row].Cells[2].Value.ToString() + "')";
                }
                SqlManager.executeQuery(query, conn);
                fillDatagridAgregar();
                fillDatagridRemover();
            }
        }

        public void addToDataGridRemover(int row, int column, bool b)
        {
            this.row = row;
            if (row != -1)
            {
                string query;
                if (b)
                    query = "delete from organizersTmp where name = '" + this.dataGridRemover.Rows[row].Cells[1].Value.ToString() + "'";
                else
                    query = "delete from usersTmp where id = '" + this.dataGridRemover.Rows[row].Cells[2].Value.ToString() + "'";

                SqlManager.executeQuery(query, conn);
                fillDatagridAgregar();
                fillDatagridRemover();
                
            }
        }

        private void Form_genericAddRemove_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.formMain.Enabled = true;

            int columnas = Convert.ToInt32(this.dataGridRemover.Rows.Count);//obtengo el total de columnas que tiene esa fila

            if (columnas>0)
            {
                this.comboBox.Items.Clear();
                if (b)
                    for (int i = 0; i < columnas; i++)
                        this.comboBox.Items.Add(this.dataGridRemover.Rows[i].Cells[1].Value.ToString());
                else
                    for (int i = 0; i < columnas; i++)
                    {
                        this.comboBox.Items.Add(this.dataGridRemover.Rows[i].Cells[1].Value.ToString());
                        this.idParticipants.Items.Add(this.dataGridRemover.Rows[i].Cells[2].Value.ToString());
                    }
                    
                
            }
           // if(form)
            if (formModify.eventoBase != null && formModify.eventoForm != null)
            {
                formModify.actualizarDataGrids();
                formModify.Enabled = true;
            }
        }
       
    }
}
