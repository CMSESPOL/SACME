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
    public partial class Reportes_General : Form
    {
        private Connector conexion;
        private SqlDataAdapter adaptador;
        private string sql;

        public Reportes_General()
        {
            InitializeComponent();
        }

        private void Reportes_General_Load(object sender, EventArgs e)
        {
            conexion = new ConnectorSingle();
            adaptador = new SqlDataAdapter();

            List<string> lista_columna = new List<string>();
            lista_columna.Add("MIEMBROS");
            lista_columna.Add("POSTULANTES");
            lista_columna.Add("TODOS");
            cmb_columna.DataSource = lista_columna;
            cmb_columna.SelectedIndex = 2;

            string sql1 = "Select u.id, (u.name+' '+lastname) as 'Nombres_Apellidos', username, phone, cellphone, address, emailEspol, emailPersonal, birthDate "
                        + "From Users as u inner join Usertreatment as t on u.UserTreatmentId=t.Id ";
            adaptador.SelectCommand = new SqlCommand(sql1, conexion.getConnection());

            DataTable table2 = new DataTable();
            DataSet set = new DataSet();

            adaptador.Fill(table2);
            set.Tables.Add(table2);

            List<string> atributo = new List<string>(new string[] { "Cédula", "Nombres y Apellidos","User","Teléfono","Celular",
            "Dirección","Email Espol","Email Personal","Fecha de Nacimiento"});

            Reportes Report = new Reportes(set, atributo, "Nomina General");
            ShowReport(set, Report.GetMemoryStream());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cmb_columna.Text.Equals("MIEMBROS"))
                sql = "Select u.id, (u.name+' '+lastname) as 'Nombres_Apellidos', username, phone, cellphone, address, emailEspol, emailPersonal, birthDate "
                     + "From Users as u inner join Usertreatment as t on u.UserTreatmentId=t.Id where isMember='true'";
            else if (cmb_columna.Text.Equals("POSTULANTES"))
                sql = "Select u.id, (u.name+' '+lastname) as 'Nombres_Apellidos', username, phone, cellphone, address, emailEspol, emailPersonal, birthDate "
                     + "From Users as u inner join Usertreatment as t on u.UserTreatmentId=t.Id where isCandidate='true'";
            else if (cmb_columna.Text.Equals("TODOS"))
                sql = "Select u.id, (u.name+' '+lastname) as 'Nombres_Apellidos', username, phone, cellphone, address, emailEspol, emailPersonal, birthDate "
                     + "From Users as u inner join Usertreatment as t on u.UserTreatmentId=t.Id ";
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

            Reportes Report = new Reportes(set, atributo, "Nomina General");
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

        private void cmb_columna_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
