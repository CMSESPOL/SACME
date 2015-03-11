using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACME
{
    public interface Connector
    {
        SqlConnection getConnection();
        
        void reconnect();

        //void EjecutarQuery(String query);
    }
}
