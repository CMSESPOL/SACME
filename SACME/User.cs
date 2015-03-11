using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACME
{
    public class User
    {
        private String name;
        private String lastname;
        private String username;
        private String id;
        private int directorship;
        private String directorshipName;
        private bool[] userstate= new bool [5];
        private bool[] usertreatment = new bool [2];
      
        public User(Connector conn, String username)
        {
           
            SqlDataReader myReader = null;
            String q = "SELECT id,name,lastname,username FROM dbo.users WHERE username='"+username+"';";
            myReader=SqlManager.getQuery(q, conn);

            if (myReader.HasRows) { 
                myReader.Read();


            id = myReader[0].ToString();
            name = myReader[1].ToString();
            lastname = myReader[2].ToString();
            username = myReader[3].ToString();


            myReader.Close();
            }
            q = "SELECT directorshipId FROM dbo.directorshipHistorial WHERE chargeTakenDate=("+ 
                "SELECT MAX(chargeTakenDate) FROM dbo.directorshipHistorial WHERE usersId='"+id+"')";

            myReader = SqlManager.getQuery(q, conn);
            myReader.Read();

            if (myReader.HasRows)
            {
                directorship = Int32.Parse(myReader[0].ToString());
                myReader.Close();

                  q = "SELECT name FROM dbo.directorship WHERE id='" + directorship + "';";

                    myReader = SqlManager.getQuery(q, conn);
                    myReader.Read();

                    this.directorshipName = myReader[0].ToString();

                    myReader.Close();
           }
            else
                this.directorshipName = "NINGUNO";

            myReader.Close();
            
        }

        public String getDirectorshipName()
        {
            return directorshipName;
        }

        public void setDirectorshipName(String directorshipName)
        {
            this.directorshipName = directorshipName;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getLastname()
        {
            return lastname;
        }

        public void setLastname(String lastname)
        {
            this.lastname = lastname;
        }

        public String getUsername()
        {
            return username;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        public String getId()
        {
            return id;
        }

        public void setId(String id)
        {
            this.id = id;
        }

        public int getDirectorship()
        {
            return directorship;
        }

        public void setDirectorship(int directorship)
        {
            this.directorship = directorship;
        }

        public bool[] getUserstate()
        {
            return userstate;
        }

        public void setUserstate(bool[] userstate)
        {
            this.userstate = userstate;
        }

        public bool[] getUsertreatment()
        {
            return usertreatment;
        }

        public void setUsertreatment(bool[] usertreatment)
        {
            this.usertreatment = usertreatment;
        }



    }
}
