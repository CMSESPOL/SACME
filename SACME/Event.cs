using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACME
{
    public class Event
    {
        //insert into event(name,description,responsible,duration,start,type,branchId,createdBy) 
        //VALUES ('luis', 'descripcion', '1', '2 horas', '2013-jan-01', 'tipo', 2, '1')";
        private int id;
        private string name;
        private string description;
        private string responsible; //Cadena numerica, debe coincidir con un id en la tabla user
        private string duration;
        private DateTime start;
        private int eventTypeId;
        private int branchId;
        private DateTime created;
        private string createdBy;
        public Event()
        {
            this.id = 0;
            this.name = null;
            this.description = null;
            this.responsible = null;
            this.duration = null;
            this.start = new DateTime();
            this.eventTypeId = 0;
            this.branchId = 0;
            this.created = new DateTime();
            this.createdBy = null;
        }
        public Event(int id, string name, string description, string responsible, string duration, DateTime start, int eventTypeId, int branchId, DateTime created, string createdBy)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.responsible = responsible;
            this.duration = duration;
            this.start = start;
            this.eventTypeId = eventTypeId;
            this.branchId = branchId;
            this.created = created;
            this.createdBy = createdBy;
        }

        public Event(string name, string description, string responsible, string duration, DateTime start, int eventTypeId, int branchId, string createdBy)
        {

            this.name = name;
            this.description = description;
            this.responsible = responsible;
            this.duration = duration;
            this.start = start;
            this.eventTypeId = eventTypeId;
            this.branchId = branchId;
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
         * @return the description
         */
        public string getDescription()
        {
            return description;
        }

        /**
         * @param description the description to set
         */
        public void setDescription(string description)
        {
            this.description = description;
        }



        /**
         * @return the responsible
         */
        public string getResponsible()
        {
            return responsible;
        }

        /**
         * @param responsible the responsible to set
         */
        public void setResponsible(string responsible)
        {
            this.responsible = responsible;
        }



        /**
         * @return the duration
         */
        public string getDuration()
        {
            return duration;
        }

        /**
         * @param duration the duration to set
         */
        public void setDuration(string duration)
        {
            this.duration = duration;
        }



        /**
         * @return the start
         */
        public DateTime getStart()
        {
            return start;
        }

        /**
         * @param start the start to set
         */
        public void setStart(DateTime start)
        {
            this.start = start;
        }



        /**
         * @return the eventTypeId
         */
        public int getEventTypeId()
        {
            return eventTypeId;
        }

        /**
         * @param eventTypeId the eventTypeId to set
         */
        public void setEventTypeId(int eventTypeId)
        {
            this.eventTypeId = eventTypeId;
        }



        /**
         * @return the branchId
         */
        public int getBranchId()
        {
            return branchId;
        }

        /**
         * @param branchId the branchId to set
         */
        public void setBranchId(int branchId)
        {
            this.branchId = branchId;
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

    }
}
