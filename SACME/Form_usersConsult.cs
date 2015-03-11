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
    public partial class Form_usersConsult : Form
    {
        public Connector conn;
        private String directorShip = null;

        public Form_usersConsult()
        {
            InitializeComponent();
        }
        public Form_usersConsult(Connector conn, String directorshipName)
        {
            InitializeComponent();
            this.conn = conn;
            this.directorShip = directorshipName;

            if (this.directorShip == "CONSEJERO")
            {
                ultraButton_Guardar.Visible = false;
                ultraButton_Cancelar.Visible = false;
            
            }

        }

        private void ultraButton_Buscar_Click(object sender, EventArgs e)
        {
            int rowCount;

            String query = "SELECT  Cargo= " +
                                            "(SELECT dd.name " +
                                            "FROM directorship dd, directorshipHistorial ddhh " +
                                            "WHERE ddhh.usersId=u.id AND ddhh.directorshipId=dd.id AND ddhh.chargeTakenDate=(" +
                                                                                                                            "SELECT MAX(chargeTakenDate) " +
                                                                                                                            "FROM dbo.directorshipHistorial " +
                                                                                                                            "WHERE usersId=u.id ))," +
                                    "Estado=" +
                                            "(SELECT us.id " +
                                            "FROM userState us " +
                                            "WHERE us.id=u.userStateId), " +

                                    "Miembro=" +
                                            "(SELECT isMember " +
                                            "FROM userTreatment ut " +
                                            "WHERE ut.id=u.userTreatmentId AND ut.isMember=1), " +

                                    "u.name as Nombres,u.lastname as Apellidos, u.id as Cédula, u.birthDate as 'Fecha de Nacimiento'," +
                                    "u.address as Dirección, u.phone as Teléfono,  u.cellphone as Celular," +
                                    "u.registrationNumber as Matrícula,c.name as Carrera, u.emailESPOL as 'Correo de ESPOL'," +
                                    "u.username as Usuario,u.emailPersonal as 'Correo Alterno' " +
                                    "FROM users u,career c " +
                                    "WHERE (c.id=u.careerId AND ";
            String cont = " ;";
            String q = "";
            String search = ultraTextEditor_Buscar.Text;
            int flag = 0;

            if (search == "")
                MessageBox.Show("Escriba algún dato en la caja de texto");
            else
            {
                if (radioButton_Cedula.Checked)
                {
                    search = ultraTextEditor_Buscar.Text;
                    q = query + "u.id='" + search + "')" + cont;
                    flag = 1;
                }
                else if (radioButton_Matricula.Checked)
                {
                    search = ultraTextEditor_Buscar.Text;
                    q = query + "u.registrationNumber='" + search + "')" + cont;
                    flag = 1;
                }
                else if (radioButton_Nombre.Checked)
                {
                    search = ultraTextEditor_Buscar.Text;
                    q = query + "u.name like '%" + search + "%')" + cont;
                    flag = 1;
                }
                else if (radioButton_Apellido.Checked)
                {
                    search = ultraTextEditor_Buscar.Text;
                    q = query + "u.lastname like '%" + search + "%')" + cont;
                    flag = 1;
                }
                else
                    MessageBox.Show("Seleccione una opción para continuar");

                if (flag == 1)
                {

                    SqlManager.loadDataGridView(dataGridView_Users, q, conn);

                    dataGridView_Users.Columns[1].Visible = false;
                    dataGridView_Users.Columns[0].Width = 60;
                    dataGridView_Users.Columns[0].Visible = true;
                    dataGridView_Users.Columns[0].DisplayIndex = 14;

                    if (dataGridView_Users.Columns.Count == 16)
                        dataGridView_Users.Columns.Remove("ColumnEstado");

                    DataGridViewColumn newCol = new DataGridViewColumn(); // add a column to the grid
                    DataGridViewCell cell = new DataGridViewTextBoxCell(); //Specify which type of cell in this column
                    newCol.CellTemplate = cell;

                    newCol.HeaderText = "Estado";
                    newCol.Name = "ColumnEstado";
                    newCol.Visible = true;
                    newCol.Width = 50;
                    dataGridView_Users.Columns.Add(newCol);

                    dataGridView_Users.Columns[0].Visible = true;
                    dataGridView_Users.Columns[0].Width = 100;

                    rowCount = 0;
                    String a;

                    while (rowCount < dataGridView_Users.Rows.Count-1)
                    {                       
                        a = dataGridView_Users.Rows[rowCount].Cells[1].Value.ToString();

                        String qry = "SELECT us.isActive,us.isInactive,us.isPassive,us.isRemoved,us.isTesting FROM dbo.userState us WHERE us.id=" + a + ";";

                        SqlDataReader mr = SqlManager.getQuery(qry, conn);
                        if (mr.HasRows)
                        {
                            mr.Read();
                            if (mr[0].ToString() == "True")
                            {
                                dataGridView_Users.Rows[rowCount].Cells[15].Value = "Activo";
                            }
                            else if (mr[1].ToString() == "True")
                            {
                                dataGridView_Users.Rows[rowCount].Cells[15].Value = "Inactivo";
                            }
                            else if (mr[2].ToString() == "True")
                            {
                                dataGridView_Users.Rows[rowCount].Cells[15].Value = "Pasivo";
                            }
                            else if (mr[3].ToString() == "True")
                            {
                                dataGridView_Users.Rows[rowCount].Cells[15].Value = "Removido";
                            }
                            else if (mr[4].ToString() == "True")
                            {
                                dataGridView_Users.Rows[rowCount].Cells[15].Value = "A prueba";
                            }
                            else
                                dataGridView_Users.Rows[rowCount].Cells[15].Value = "Sin información";

                        }
                        mr.Close();
                        rowCount++;
                    }
                }
            }

        }


    }
}
