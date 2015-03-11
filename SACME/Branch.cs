using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACME
{
   /** <summary>Clase Branch maneja los datos de las ramas de la celula</summary> */ 
   public class Branch
    {
        private int id;
        private string name;
        private string shortName;
        private bool isEnable;
        private DateTime created;
        

        /** <summary>Constructor de la clase Branch.Inicializa los valores de los atributos de la clase Branch</summary> */ 
        /**<return> No devuelve nada </return> */
        public Branch()
        {
            this.id = 0;
            this.name = null;
            this.shortName = null;
            this.isEnable = new bool();
            this.created = new DateTime();
        }


        /**<summary>Constructor de la clase Branch. Setea valores de los atributos con los valores enviados como parametros de la clase Branch </summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="id">Id de la rama </param>*/
        /**<param name="name">Nombre de la rama </param>*/
        /**<param name="shortName">Alias de la rama </param>*/
        /**<param name="isEnable">Estado de la rama </param>*/
        /**<param name="created">Fecha de creacion de la rama </param>*/
        /**<param name="createdBy">Quien creo la rama </param>*/
        public Branch(int id, string name, string shortName, bool isEnable, DateTime created, string createdBy)
        {
            this.id = id;
            this.name = name;
            this.isEnable = isEnable;
            this.created = created;
            this.shortName = shortName;
        }

        /**<summary>Obtiene el ID de la rama</summary> */
        /**<return>Devuelve el Id de la rama </return>*/
        public int getId()
        {
            return id;
        }

        /**<summary>Setea el id de la rama </summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="id">Id a setear </param>*/
        public void setId(int id)
        {
            this.id = id;
        }

        /**<summary>Obtiene el nombre de la rama </summary> */
        /**<return> Devuelve el nombre de la rama </return>*/
        public string getName()
        {
            return name;
        }

        /**<summary>Setea el nombre de la rama </summary> */
        /**<return> No devuelve nada </return>*/
        /**<param name="name">Nombre a setear </param>*/
        public void setName(string name)
        {
            this.name = name;
        }

         /**<summary>Obtiene el alias de la rama </summary> */
         /**<return> Devuelve el alias con el que se identifica a la rama </return>*/
         public string getShortName()
         {
            return shortName;
         }

         /**<summary>Setea el alias de la rama </summary> */
         /**<return> No devuelve nada </return>*/
         /**<param name="shortName">alias a setear </param>*/
         public void setShortName(string shortName)
         {
            this.shortName = shortName;
         }

         /**<summary>Obtiene el estado de la rama </summary> */
         /**<return> Devuelve el estado de la rama </return>*/
         public bool getIsEnable()
         {
            return isEnable;
         }

         /**<summary>Setea el estado de la rama </summary> */
         /**<return> No devuelve nada </return>*/
         /**<param name="isEnable">estado a setear </param>*/
         public void setIsEnable(bool isEnable)
         {
            this.isEnable = isEnable;
         }

         /**<summary>Obtiene la fecha de creacion de la rama </summary> */
         /**<return> Devuelve la fecha de creacion de la ram </return>*/
         public DateTime getCreated()
         {
            return created;
         }

         /**<summary>Setea la fecha de creacion de la rama </summary> */
         /**<return> No devuelve nada </return>*/
         /**<param name="created">Fecha de creacion a setear </param>*/ 
        public void setCreated(DateTime created)
        {
            this.created = created;
        }

        /**<summary>Imprime el contenida de la rama </summary> */
        /**<return> Devuelve la cadena de caracteres que muestra los valores de los atributos</return>*/
        public String toString()
        {
            return "Branch{" + "id=" + id + "name=" + name + "state=" + isEnable + "created=" + created + "shortName=" + shortName + '}';
        }

    }
}
