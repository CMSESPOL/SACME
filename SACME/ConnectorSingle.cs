using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACME
{
    class ConnectorSingle : Connector
    {
        SqlConnection conn;
        String connstring;

        public ConnectorSingle()
        {
            this.connstring = Properties.Settings.Default.SACMEConnection;
        }


        public SqlConnection getConnection()
        {
            if (conn == null)
            {
                try
                {
                    this.conn = new SqlConnection();
                    this.conn.ConnectionString = connstring;
                    this.conn.Open();
                    //Console.WriteLine("CONECTADO A DB");
                    //MessageBox.Show("Conexion Establecida");
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("CONEXION A DB NO ESTABLECIDA");
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return conn;
        }

        public void reconnect()
        {
            if (conn != null)
            {
                try
                {
                    if (!(conn.State == System.Data.ConnectionState.Open))
                    {
                        conn.Close();
                    }
                }
                catch (SqlException sqlex)
                {
                    Console.WriteLine(sqlex);
                }
                conn = null;
            }
            getConnection();
        }

        public void EjecutarQuery(String query) {
            try
            {
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(query, conn);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    //MessageBox.Show( myReader[0].ToString(),"Si");
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                
            }
        }
    }
}
