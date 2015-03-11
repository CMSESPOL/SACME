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
    public partial class Reporte_Actividades : Form
    {
        public String campo { get; set; }
        private Connector conexion;
        private SqlDataAdapter adaptador;
        private string sql;

        public Reporte_Actividades()
        {
            InitializeComponent();
        }

        private void Reporte_Actividades_Load(object sender, EventArgs e)
        {
            conexion = new ConnectorSingle();
            adaptador = new SqlDataAdapter();

            List<string> lista_columna = new List<string>();
            lista_columna.Add("MIEMBROS");
            lista_columna.Add("POSTULANTES");
            lista_columna.Add("TODOS");
            cmb_columna.DataSource = lista_columna;
            cmb_columna.SelectedIndex = 2;


            string sql1 = "Select e.id, e.name, description, duration, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, "
                     + "start, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                + "From event as e inner join Users as u on u.Id=e.responsible inner join Usertreatment as t on u.UsertreatmentId=t.Id";

            adaptador.SelectCommand = new SqlCommand(sql1, conexion.getConnection());
            DataTable table2 = new DataTable();
            DataSet set = new DataSet();

            adaptador.Fill(table2);
            set.Tables.Add(table2);

            List<string> atributo = new List<string>(new string[] { "ID Actividad", "Nombre de Actividad", "Descripción",
                "Duración", "Actividad Creada", "Fecha de Inicio", "Cédula", "Responsable de la Actividad", "User"});

            Reportes Report = new Reportes(set, atributo, "Actividades Realizadas");
            ShowReport(set, Report.GetMemoryStream());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_columna.Text.Equals("MIEMBROS"))
                sql = "Select e.id, e.name, description, duration, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, "
                     +"start, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                     + "From event as e inner join Users as u on u.Id=e.responsible inner join Usertreatment as t on u.UsertreatmentId=t.Id where isMember='true'";
            else if (cmb_columna.Text.Equals("POSTULANTES"))
                sql = "Select e.id, e.name, description, duration, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, "
                     + "start, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                     + "From event as e inner join Users as u on u.Id=e.responsible inner join Usertreatment as t on u.UsertreatmentId=t.Id where isCandidate='true'";
            else if (cmb_columna.Text.Equals("TODOS"))
                sql = "Select e.id, e.name, description, duration, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, "
                     + "start, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                     + "From event as e inner join Users as u on u.Id=e.responsible inner join Usertreatment as t on u.UsertreatmentId=t.Id";
            else
                sql = "Select e.id, e.name, description, duration, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, "
                     + "start, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                     + "From event as e inner join Users as u on u.Id=e.responsible inner join Usertreatment as t on u.UsertreatmentId=t.Id where u.Id='NULL'";

            adaptador.SelectCommand = new SqlCommand(sql, conexion.getConnection());

            DataTable table2 = new DataTable();
            DataSet set = new DataSet();

            adaptador.Fill(table2);
            set.Tables.Add(table2);

            List<string> atributo = new List<string>(new string[] { "ID Actividad", "Nombre de Actividad", "Descripción",
                "Duración", "Actividad Creada", "Fecha de Inicio", "Cédula", "Responsable de la Actividad", "User"});

            Reportes Report = new Reportes(set, atributo, "Actividades Realizadas");
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
