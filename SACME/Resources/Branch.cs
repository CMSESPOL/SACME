using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACME
{
   public class Branch
    {
        private int id;
        private string name;
        private bool isEnable;
        private DateTime created;
        private string createdBy;

        public Branch()
        {
            this.id = 0;
            this.name = null;
            this.isEnable = new bool();
            this.created = new DateTime();
            this.createdBy = null;
        }
        public Branch(int id, string name, bool isEnable, DateTime created, string createdBy) 
        {
            this.id = id;
            this.name = name;
            this.isEnable = isEnable;
            this.created = created;
            this.createdBy = createdBy;
        }

        /**
        * @return the id
        */
        public int getId()
        {
            return id;
        }

        /**
         * @param id the id to set
         */
        public void setId(int id)
        {
            this.id = id;
        }




        /**
        * @return the name
        */
        public string getName()
        {
            return name;
        }

        /**
         * @param name the name to set
         */
        public void setName(string name)
        {
            this.name = name;
        }




        /**
        * @return the isEnable
        */
        public bool getIsEnable()
        {
            return isEnable;
        }

        /**
         * @param isEnable the isEnable to set
         */
        public void setIsEnable(bool isEnable)
        {
            this.isEnable = isEnable;
        }





        /**
        * @return the created
        */
        public DateTime getCreated()
        {
            return created;
        }

        /**
         * @param created the created to set
         */
        public void setCreated(DateTime created)
        {
            this.created = created;
        }





        /**
        * @return the createdBy
        */
        public string getCreatedBy()
        {
            return createdBy;
        }

        /**
         * @param createdBy the createdBy to set
         */
        public void setCreatedBy(string createdBy)
        {
            this.createdBy = createdBy;
        }

        public String toString()
        {
            return "Branch{" + "id=" + id + "name=" + name + "state=" + isEnable + "created=" + created + "createdBy=" + createdBy + '}';
        }

    }
}
