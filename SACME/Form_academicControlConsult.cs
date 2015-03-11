using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACME
{
    public partial class Form_academicControlConsult : Form
    {
        public Connector conn;
        private bool SelectedItems;
        private int rowCount;
        private User userSession;


        private List<string> _sideList = new List<string>();


        public Form_academicControlConsult()
        {
            InitializeComponent();
        }

        public Form_academicControlConsult(Connector conn, User userSession)
        {
            this.conn = conn;
            InitializeComponent();

            DataGridViewColumn newCol = new DataGridViewColumn(); // add a column to the grid
            DataGridViewCell cell = new DataGridViewTextBoxCell(); //Specify which type of cell in this column
            newCol.CellTemplate = cell;

            newCol.HeaderText = "Tipo";
            newCol.Name = "ColumnType";
            newCol.Visible = false;
            newCol.Width = 50;
            dataGridView_AC.Columns.Add(newCol);
            this.userSession = userSession;
        }


        private void ultraButton_courses_Click(object sender, EventArgs e)
        {
            String q="",val;
            int b = 0;

            if (radioButton_ced.Checked)
            {
                val = ultraTextEditor_search.Value.ToString();
                q = "SELECT c.academicTerm as 'Término',(u.name+' '+u.lastname) as 'Nombres y Apellidos',ca.name AS 'Carrera',u.registrationNumber AS 'Matrícula', c.name AS 'Curso',c.institution AS 'Institución'," +
                " c.gainedPoints AS 'Puntos obtenidos', c.duration AS 'Carga horaria', c.id  FROM dbo.course c, dbo.users u, dbo.career ca WHERE u.id=c.userId AND u.id='"+val+"'" +
                " AND ca.id=u.careerId ORDER BY c.academicTerm DESC;";
            }
            else if (radioButton_mat.Checked)
            {
                val = ultraTextEditor_search.Value.ToString();
                q = "SELECT c.academicTerm as 'Término',(u.name+' '+u.lastname) as 'Nombres y Apellidos',ca.name AS 'Carrera',u.registrationNumber AS 'Matrícula', c.name AS 'Curso',c.institution AS 'Institución'," +
                 " c.gainedPoints AS 'Puntos obtenidos', c.duration AS 'Carga horaria', c.id FROM dbo.course c, dbo.users u, dbo.career ca WHERE u.id=c.userId AND u.registrationNumber='" + val + "'" +
                 " AND ca.id=u.careerId ORDER BY c.academicTerm DESC;";
            }
            else if (radioButton_name.Checked)
            {
                val = ultraTextEditor_search.Value.ToString();
                q = "SELECT c.academicTerm as 'Término',(u.name+' '+u.lastname) as 'Nombres y Apellidos',ca.name AS 'Carrera',u.registrationNumber AS 'Matrícula', c.name AS 'Curso',c.institution AS 'Institución'," +
                 " c.gainedPoints AS 'Puntos obtenidos', c.duration AS 'Carga horaria', c.id FROM dbo.course c, dbo.users u, dbo.career ca WHERE (u.name+' '+u.lastname) like '%" + val +
                 "%' AND u.id=c.userId AND ca.id=u.careerId ORDER BY c.academicTerm DESC;";
            }
            else
            {
                b = 1;
            }

            if (b == 0)
            {
                SqlManager.loadDataGridView(dataGridView_AC, q, conn);
                dataGridView_AC.Enabled = true;
                dataGridView_AC.Columns[8].Visible = true;
                dataGridView_AC.Columns[9].Visible = false;
                
                rowCount = 0;
                while (rowCount < dataGridView_AC.Rows.Count)
                {
                    dataGridView_AC.Rows[rowCount].Cells[0].Value="course";
                    rowCount++;
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un parámetro de búsqueda.");
            }
        }

        private void ultraButton_espol_Click(object sender, EventArgs e)
        {
            String val,q="";
            int b = 0;

            if (radioButton_ced.Checked)
            {
                val = ultraTextEditor_search.Value.ToString();
                q = "SELECT ap.academicTerm as Término,(u.name+' '+u.lastname) as 'Nombres y Apellidos', ca.name AS Carrera ,u.registrationNumber AS Matrícula, ap.gainedPoints as 'Puntos obtenidos',ap.totalPoints as 'Puntos totales'," +
                "ap.espolAverage as 'Promedio ESPOL', ap.observation AS 'Observación',ap.id FROM dbo.academicPerformance ap, dbo.users u, dbo.career ca WHERE ap.userId='" + val
                + "' AND u.id=ap.userId AND ca.id=u.careerId ORDER BY ap.academicTerm DESC;";
            }
            else if (radioButton_mat.Checked)
            {
                val = ultraTextEditor_search.Value.ToString();
                q = "SELECT ap.academicTerm as Término,(u.name+' '+u.lastname) as 'Nombres y Apellidos', ca.name AS Carrera ,u.registrationNumber AS Matrícula, ap.gainedPoints as 'Puntos obtenidos',ap.totalPoints as 'Puntos totales'," +
               "ap.espolAverage as 'Promedio ESPOL', ap.observation AS 'Observación',ap.id FROM dbo.academicPerformance ap, dbo.users u, dbo.career ca WHERE u.registrationNumber='" + val + "' AND u.id=ap.userId AND ca.id=u.careerId ORDER BY ap.academicTerm DESC;";
            }
            else if (radioButton_name.Checked)
            {
                val = ultraTextEditor_search.Value.ToString();
                q = "SELECT ap.academicTerm as Término,(u.name+' '+u.lastname) as 'Nombres y Apellidos', ca.name AS Carrera ,u.registrationNumber AS Matrícula, ap.gainedPoints as 'Puntos obtenidos',ap.totalPoints as 'Puntos totales'," +
              "ap.espolAverage as 'Promedio ESPOL', ap.observation AS 'Observación',ap.id FROM dbo.academicPerformance ap, dbo.users u,dbo.career ca WHERE (u.name+' '+u.lastname) like '%" + val
              + "%' AND u.id=ap.userId AND ca.id=u.careerId ORDER BY ap.academicTerm DESC;";
            }
            else
            {
                b = 1;
            }

            if (b == 0)
            {
                SqlManager.loadDataGridView(dataGridView_AC, q, conn);
                dataGridView_AC.Enabled = true;
                dataGridView_AC.Columns[8].Visible = true;
                dataGridView_AC.Columns[9].Visible = false;

                rowCount = 0;
                while (rowCount < dataGridView_AC.Rows.Count)
                {
                    dataGridView_AC.Rows[rowCount].Cells[0].Value = "espol";
                    rowCount++;
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un parámetro de búsqueda.");
            }
        }

        private void ultraButton_accept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void columnGrid_doubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ArrayList ap = getSelectedItem(this.dataGridView_AC);
           // MessageBox.Show(ap[0].ToString());
            
            if (SelectedItems && ap[0]!=null)
            {
                if (ap[0].ToString() == "course")
                {
                    Form_academicControlRegistry form = new Form_academicControlRegistry(conn,userSession, ap[9].ToString(),ap[0].ToString());
                    form.Show();
                }
                else if (ap[0].ToString() == "espol")
                {
                    Form_academicControlRegistry form = new Form_academicControlRegistry(conn, userSession, ap[9].ToString(), ap[0].ToString());
                    form.Show();                    
                }
                else
                    MessageBox.Show("Se ha detecatado problemas con los datos de la fila seleccionada.\nConsulte con el administrador del sistema.");
            }
        }

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
                SelectedItems = false;
            }
            return selectedItem;
        }

    }
}
