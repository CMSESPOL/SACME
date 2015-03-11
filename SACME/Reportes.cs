using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACME
{
    class Reportes
    {
        private MemoryStream m_rdl;

        public Reportes(DataSet set, List<string> atributo, String cabecera)
        {
            try
            {
                List<string> allFields = GetAvailableFields(set);
                m_rdl = new MemoryStream();

                RdlGenerator gen = new RdlGenerator();
                //AllFields nombre del campo
                //SelectedFiels atributo del campo
                //Titulo encabezado del reporte
                gen.AllFields = allFields;
                gen.SelectedFiels = atributo;
                gen.Titulo = cabecera;
                gen.WriteXml(m_rdl);
                m_rdl.Position = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private List<string> GetAvailableFields(DataSet set)
        {
            DataTable dataTable = set.Tables[0];
            List<string> availableFields = new List<string>();
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                availableFields.Add(dataTable.Columns[i].ColumnName);
            }
            return availableFields;
        }

        public MemoryStream GetMemoryStream()
        {
            return m_rdl;
        }
    }
}
