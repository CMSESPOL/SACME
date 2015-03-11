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
    public partial class Reporte_Actividades_Rama_Mensual : Form
    {
        public String rama { get; set; }
        public String mes { get; set; }
        private Connector conexion;
        private SqlDataAdapter adaptador;
        private string sql;

        public Reporte_Actividades_Rama_Mensual()
        {
            InitializeComponent();
        }

        private void Reporte_Actividades_Rama_Mensual_Load(object sender, EventArgs e)
        {
            conexion = new ConnectorSingle();
            adaptador = new SqlDataAdapter();

            List<string> lista_columna = new List<string>();
            lista_columna.Add("Enero");
            lista_columna.Add("Febrero");
            lista_columna.Add("Marzo");
            lista_columna.Add("Abril");
            lista_columna.Add("Mayo");
            lista_columna.Add("Junio");
            lista_columna.Add("Julio");
            lista_columna.Add("Agosto");
            lista_columna.Add("Septiembre");
            lista_columna.Add("Octubre");
            lista_columna.Add("Noviembre");
            lista_columna.Add("Diciembre");
            lista_columna.Add("TODOS");

            cmb_columna.DataSource = lista_columna;
            cmb_columna.SelectedIndex = 12;


            string sql1 = "Select e.id, e.name, description, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, e.start, b.name, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                + "From event as e inner join branch as b on b.Id=e.branchId inner join Users as u on u.Id=e.responsible where b.isEnable='true'";
            adaptador.SelectCommand = new SqlCommand(sql1, conexion.getConnection());

            DataTable table2 = new DataTable();
            DataSet set = new DataSet();

            adaptador.Fill(table2);
            set.Tables.Add(table2);

            List<string> atributo = new List<string>(new string[] { "ID Actividad", "Nombre de Actividad", "Descripción",
                "Actividad Creada", "Fecha de Inicio", "Nombre de Rama", "Cédula", "Responsable de la Actividad", "User"});

            Reportes Report = new Reportes(set, atributo, "Actividad Rama Activa Mensual");
            ShowReport(set, Report.GetMemoryStream());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Valida si es nulo o vacio
            if (!String.IsNullOrEmpty(text_campo.Text))
                rama = text_campo.Text;
            else
                rama = "MES";

            mes = Convert.ToString(Convert.ToInt32(cmb_columna.SelectedIndex.ToString()) + 1);

            if (cmb_columna.Text.Equals("TODOS"))
            {
                sql = "Select e.id, e.name, description, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, e.start, b.name, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                    + "From event as e inner join branch as b on b.Id=e.branchId inner join Users as u on u.Id=e.responsible where b.isEnable='true'";
            }
            else if (rama.Equals("MES"))
            {
                sql = "Select e.id, e.name, description, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, e.start, b.name, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                    + "From event as e inner join branch as b on b.Id=e.branchId inner join Users as u on u.Id=e.responsible where month(e.start)='" + mes + "' and b.isEnable='true'";
            }
            else
                sql = "Select e.id, e.name, description, (Select u.name+' '+u.lastname From users u where u.id = e.createdBy) as  createdBy, e.start, b.name, u.Id, (Select u.name+' '+u.lastname From users u where u.id = e.responsible) as 'responsible', username "
                     + "From event as e inner join branch as b on b.Id=e.branchId inner join Users as u on u.Id=e.responsible where month(e.start)='" + mes + "' and b.name='" + rama + "' and b.isEnable='true'";


            adaptador.SelectCommand = new SqlCommand(sql, conexion.getConnection());

            DataTable table2 = new DataTable();
            DataSet set = new DataSet();

            adaptador.Fill(table2);
            set.Tables.Add(table2);

            List<string> atributo = new List<string>(new string[] { "ID Actividad", "Nombre de Actividad", "Descripción",
                "Actividad Creada", "Fecha de Inicio", "Nombre de Rama", "Cédula", "Responsable de la Actividad", "User"});

            Reportes Report = new Reportes(set, atributo, "Actividad Rama Activa Mensual");
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

        private void ultraLabel2_Click(object sender, EventArgs e)
        {
        }
    }
}
