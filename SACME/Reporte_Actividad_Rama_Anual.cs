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
    public partial class Reporte_Actividad_Rama_Anual : Form
    {
        public String anio { get; set; }
        private Connector conexion;
        private SqlDataAdapter adaptador;
        private string sql;

        public Reporte_Actividad_Rama_Anual()
        {
            InitializeComponent();
        }

        private void Reporte_Actividad_Rama_Anual_Load(object sender, EventArgs e)
        {
            conexion = new ConnectorSingle();
            adaptador = new SqlDataAdapter();

            List<string> lista_columna = new List<string>();
            lista_columna.Add("ACTIVA");
            lista_columna.Add("INACTIVA");
            lista_columna.Add("TODOS");
            cmb_columna.DataSource = lista_columna;
            cmb_columna.SelectedIndex = 2;


            string sql1 = "Select e.id, e.name, description, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, e.start, b.name, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                + "From event as e inner join branch as b on b.Id=e.branchId inner join Users as u on u.Id=e.responsible";
            adaptador.SelectCommand = new SqlCommand(sql1, conexion.getConnection());

            DataTable table2 = new DataTable();
            DataSet set = new DataSet();

            adaptador.Fill(table2);
            set.Tables.Add(table2);

            List<string> atributo = new List<string>(new string[] { "ID Actividad", "Nombre de Actividad", "Descripción",
                "Actividad Creada", "Fecha de Inicio", "Nombre de Rama", "Cédula", "Responsable de la Actividad", "User"});

            Reportes Report = new Reportes(set, atributo, "Actividad de la Rama Anual");
            ShowReport(set, Report.GetMemoryStream());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Valida si es nulo o vacio
            if (!String.IsNullOrEmpty(text_campo.Text))
                anio = text_campo.Text;
            else
                anio = "";

            if (cmb_columna.Text.Equals("ACTIVA") && !String.IsNullOrEmpty(text_campo.Text))
                sql = "Select e.id, e.name, description, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, e.start, b.name, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                     + "From event as e inner join branch as b on b.Id=e.branchId inner join Users as u on u.Id=e.responsible where year(e.start)='" + anio + "' and b.isEnable='true'";
            else if (cmb_columna.Text.Equals("ACTIVA") && String.IsNullOrEmpty(text_campo.Text))
                sql = "Select e.id, e.name, description, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, e.start, b.name, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                     + "From event as e inner join branch as b on b.Id=e.branchId inner join Users as u on u.Id=e.responsible where b.isEnable='true'";
            else if (cmb_columna.Text.Equals("INACTIVA") && !String.IsNullOrEmpty(text_campo.Text))
                sql = "Select e.id, e.name, description, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, e.start, b.name, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                     + "From event as e inner join branch as b on b.Id=e.branchId inner join Users as u on u.Id=e.responsible where year(e.start)='" + anio + "' and b.isEnable='false'";
            else if (cmb_columna.Text.Equals("INACTIVA") && String.IsNullOrEmpty(text_campo.Text))
                sql = "Select e.id, e.name, description, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, e.start, b.name, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                     + "From event as e inner join branch as b on b.Id=e.branchId inner join Users as u on u.Id=e.responsible where b.isEnable='false'";
            else if (cmb_columna.Text.Equals("TODOS") && !String.IsNullOrEmpty(text_campo.Text))
                sql = "Select e.id, e.name, description, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, e.start, b.name, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                     + "From event as e inner join branch as b on b.Id=e.branchId inner join Users as u on u.Id=e.responsible where year(e.start)='" + anio + "'";
            else if (cmb_columna.Text.Equals("TODOS") && String.IsNullOrEmpty(text_campo.Text))
                sql = "Select e.id, e.name, description, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, e.start, b.name, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                     + "From event as e inner join branch as b on b.Id=e.branchId inner join Users as u on u.Id=e.responsible";
            else
                sql = "Select e.id, e.name, description, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, e.start, b.name, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                     + "From event as e inner join branch as b on b.Id=e.branchId inner join Users as u on u.Id=e.responsible where u.Id='NULL'";

            adaptador.SelectCommand = new SqlCommand(sql, conexion.getConnection());

            DataTable table2 = new DataTable();
            DataSet set = new DataSet();

            adaptador.Fill(table2);
            set.Tables.Add(table2);

            List<string> atributo = new List<string>(new string[] { "ID Actividad", "Nombre de Actividad", "Descripción",
                "Actividad Creada", "Fecha de Inicio", "Nombre de Rama", "Cédula", "Responsable de la Actividad", "User"});

            Reportes Report = new Reportes(set, atributo, "Actividad de la Rama Anual");
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
            Margins margins = new Margins(10, 20, 50, 20);
            configuracion.Margins = margins;
            reportViewer1.SetPageSettings(configuracion);
        }
    }
}
