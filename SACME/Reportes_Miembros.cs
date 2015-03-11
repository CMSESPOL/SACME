using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SACME
{
    public partial class Reportes_Miembros : Form
    {
        public String campo { get; set; }
        private Connector conexion;
        private SqlDataAdapter adaptador;
        private string sql;

        public Reportes_Miembros()
        {
            InitializeComponent();
        }

        private void Reportes_Miembros_Load(object sender, EventArgs e)
        {
            conexion = new ConnectorSingle();
            adaptador = new SqlDataAdapter();

            List<string> lista_columna = new List<string>();
            lista_columna.Add("ID");
            lista_columna.Add("NOMBRE Y APELLIDO");
            lista_columna.Add("TODOS");
            cmb_columna.DataSource = lista_columna;
            cmb_columna.SelectedIndex = 2;

            string sql1 = "Select u.id, (u.name+' '+lastname) as 'Nombres_Apellidos', username, phone, cellphone, address, emailEspol, emailPersonal, birthDate "
                + "From Users as u inner join Usertreatment as t on u.UserTreatmentId=t.Id where isMember='true'";
            adaptador.SelectCommand = new SqlCommand(sql1, conexion.getConnection());

            DataTable table2 = new DataTable();
            DataSet set = new DataSet();
            adaptador.Fill(table2);
            set.Tables.Add(table2);

            List<string> atributo = new List<string>(new string[] { "Cédula", "Nombres y Apellidos","User","Teléfono","Celular",
            "Dirección","Email Espol","Email Personal","Fecha de Nacimiento"});

            Reportes Report = new Reportes(set, atributo, "Nomina de Miembros");
            ShowReport(set, Report.GetMemoryStream());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ' ' };
            string[] name;
            //Valida si es nulo o vacio
            if (!String.IsNullOrEmpty(text_campo.Text))
            {
                campo = text_campo.Text;
                name = campo.Split(delimiterChars);
            }
            else
            {
                campo = "0";
                name = campo.Split(delimiterChars);
            }

            if (cmb_columna.Text.Equals("ID"))
                sql = "Select u.id, (u.name+' '+lastname) as 'Nombres_Apellidos', username, phone, cellphone, address, emailEspol, emailPersonal, birthDate "
                     + "From Users as u inner join Usertreatment as t on u.UserTreatmentId=t.Id where isMember='true' AND  u.Id='" + campo + "'";
            else if (cmb_columna.Text.Equals("NOMBRE Y APELLIDO") && name.Length > 1)
            {
                sql = "Select u.id, (u.name+' '+lastname) as 'Nombres_Apellidos', username, phone, cellphone, address, emailEspol, emailPersonal, birthDate "
                     + "From Users as u inner join Usertreatment as t on u.UserTreatmentId=t.Id where isMember='true' AND  u.name like '" + name[0] + "%' AND u.lastname like '" + name[1] + "%'";
            }
            else if (cmb_columna.Text.Equals("NOMBRE Y APELLIDO") && name.Length < 2)
            {
                sql = "Select u.id, (u.name+' '+lastname) as 'Nombres_Apellidos', username, phone, cellphone, address, emailEspol, emailPersonal, birthDate "
                    + "From Users as u inner join Usertreatment as t on u.UserTreatmentId=t.Id where isMember='true' AND  u.name like '" + name[0] + "%'";
            }
            else if (cmb_columna.Text.Equals("TODOS"))
                sql = "Select u.id, (u.name+' '+lastname) as 'Nombres_Apellidos', username, phone, cellphone, address, emailEspol, emailPersonal, birthDate "
                     + "From Users as u inner join Usertreatment as t on u.UserTreatmentId=t.Id where isMember='true'";
            else
                sql = "Select u.id, (u.name+' '+lastname) as 'Nombres_Apellidos', username, phone, cellphone, address, emailEspol, emailPersonal, birthDate "
                     + "From Users as u inner join Usertreatment as t on u.UserTreatmentId=t.Id where u.Id='NULL'";

            adaptador.SelectCommand = new SqlCommand(sql, conexion.getConnection());

            DataTable table2 = new DataTable();
            DataSet set = new DataSet();
            adaptador.Fill(table2);
            set.Tables.Add(table2);

            List<string> atributo = new List<string>(new string[] { "Cédula", "Nombres y Apellidos","User","Teléfono","Celular",
            "Dirección","Email Espol","Email Personal","Fecha de Nacimiento"});

            Reportes Report = new Reportes(set, atributo, "Nomina de Miembros");
            ShowReport(set, Report.GetMemoryStream());
        }

        private void ShowReport(DataSet set1, MemoryStream ms_rdl)
        {
            this.reportViewer1.Reset();
            this.reportViewer1.LocalReport.LoadReportDefinition(ms_rdl);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("MyData", set1.Tables[0]));
            this.reportViewer1.RefreshReport();

            System.Drawing.Printing.PageSettings configuracion = new System.Drawing.Printing.PageSettings();
            configuracion.Landscape = true;
            Margins margins = new Margins(20, 20, 50, 20);
            configuracion.Margins = margins;
            reportViewer1.SetPageSettings(configuracion);

        }

    }
}
