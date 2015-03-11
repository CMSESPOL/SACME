using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACME
{
    static class SqlManager
    {
        public static SqlDataReader getQuery(String query, Connector conn)
        {
            try
            {
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(query, conn.getConnection());
                myReader = myCommand.ExecuteReader();
                return myReader;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }


        public static bool executeQuery(String query, Connector conn)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, conn.getConnection());
                myCommand.ExecuteNonQuery();
                //MessageBox.Show("Sus Datos han sido guardados");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public static void loadDataGridView(DataGridView dataGridView, String sql, Connector conn)
        {

            SqlCommand myCommand = new SqlCommand();
            SqlDataReader myReader;
            System.Data.DataTable myDataTable = new System.Data.DataTable();

            try
            {
                myCommand = new SqlCommand(sql, conn.getConnection());
                myReader = myCommand.ExecuteReader();
                myDataTable.Load(myReader);
                dataGridView.DataSource = myDataTable;

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                throw (e);
            }

        }
    }
}
