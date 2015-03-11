using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACME
{
    public partial class Form_academicControlRegistry : Form
    {
        Connector conn;
        String ced = null, typeAC = null, referenceId=null;
        User userSession;
        int gainedPointsLast = 0;
        

        public Form_academicControlRegistry()
        {
            InitializeComponent();
        }

        public Form_academicControlRegistry(Connector conn, User userSession)
        {
            this.conn = conn;
            InitializeComponent();
            this.userSession = userSession;
        }

        public Form_academicControlRegistry(Connector conn, User userSession, String id, String typeAC)
        {
            String sql;
            this.conn = conn;
            InitializeComponent();
            this.userSession = userSession;
            this.referenceId = id;
            SqlDataReader DR;

            
           
            if (typeAC == "course")
            {
                this.typeAC = typeAC;
                ultraTabControl1.SelectedTab = ultraTabPageControl2.Tab;
                ultraTabPageControl1.Enabled = false;

                sql= "SELECT id,name,gainedPoints,academicTerm,institution,duration,userId  FROM " +
                    "dbo.course WHERE id=" + id;
               
                try
                {
                    DR = SqlManager.getQuery(sql, conn);
                    if (DR != null)
                    {
                        DR.Read();
                        ultraTextEditor_nameofcourse.Value = DR["name"].ToString();
                        ultraTextEditor_institutioncourse.Value = DR["institution"].ToString();
                        ultraTextEditor_pointgetcourse.Value = DR["gainedPoints"].ToString();
                        String acTerm = DR["academicTerm"].ToString();
                        String duration = DR["duration"].ToString();

                        String[] academicT = acTerm.Split(' ', '-');

                        ultraTextEditor_anio1course.Value = academicT[1];
                        ultraTextEditor_anio2course.Value = academicT[2];
                        ultraComboEditor_termcurso.SelectedText = academicT[0];

                        String[] timeDuration = duration.Split(' ');

                        ultraComboEditor_typedurationcourse.Value = timeDuration[1];
                        numericUpDown_durationcountcourse.Value = Int32.Parse(timeDuration[0]);

                        ultraTextEditor_searchcourse.Value = DR["userId"].ToString();
                        radioButton_cedcourse.Checked = true;
                    }
                    DR.Close();
                }
                catch (DbException ex)
                {
                    MessageBox.Show("No se pudo Obtener el Id del Evento:\n " + ex);
                }
                ultraButton_savecourse.Text = "ACTUALIZAR";
                ultraButton_savecourse.Size = new Size(92, 24);
            } 
            else if (typeAC == "espol")
            {
                this.typeAC = typeAC;
                ultraTabControl1.SelectedTab = ultraTabPageControl1.Tab;
                ultraTabPageControl2.Enabled = false;

                sql="SELECT id,userId,gainedPoints,totalPoints,academicTerm,espolAverage,observation " +
                        "FROM dbo.academicPerformance WHERE id=" + id;
                
                try
                {
                    DR = SqlManager.getQuery(sql, conn);
                    if (DR != null)
                    {
                        DR.Read();
                        radioButton_ced.Checked=true;
                        ultraTextEditor_search.Text=DR["userId"].ToString();
                        String acTerm = DR["academicTerm"].ToString();

                        String[] academicT = acTerm.Split(' ', '-');

                        ultraTextEditor_anio1.Value=academicT[1];
                        ultraTextEditor_anio2.Value = academicT[2];
                        ultraComboEditor_term.SelectedText=academicT[0];

                        ultraTextEditor_gainedPoints.Text=DR["gainedPoints"].ToString();
                        bool parse = Int32.TryParse(ultraTextEditor_gainedPoints.Text, out gainedPointsLast);
                        ultraTextEditor_espolAvg.Text=DR["espolAverage"].ToString();
                        ultraTextEditor_observation.Text=DR["observation"].ToString();
                    }
                    DR.Close();
                }
                catch (DbException ex)
                {
                    MessageBox.Show("No se pudo Obtener el Id del Evento:\n " + ex);
                }


                ultraButton_saveEspol.Text = "ACTUALIZAR";
                ultraButton_saveEspol.Size = new Size(92, 24);
            }
        }
        private void ultraButton_search_Click(object sender, EventArgs e)
        {
            String q = "SELECT (us.name + us.lastname) AS 'Nombres', c.name AS 'Carrera' FROM dbo.users us JOIN dbo.career c ON us.careerId=c.id;";
            String val;
            int b = 0;

            if (radioButton_ced.Checked)
            {
                val = ultraTextEditor_search.Value.ToString();
                ced = val;
                q = "SELECT (us.name + us.lastname) AS 'Nombres', c.name AS 'Carrera' FROM dbo.users us JOIN dbo.career c ON us.careerId=c.id AND us.id='"+val+"';";
            }
            else if (radioButton_mat.Checked)
            {
                val = ultraTextEditor_search.Value.ToString();
                q = "SELECT (us.name + us.lastname) AS 'Nombres', c.name AS 'Carrera', us.id as 'Cédula' FROM dbo.users us JOIN dbo.career c ON us.careerId=c.id AND us.registrationNumber='"+val+"';";
            }
            else
            {
                b = 1;
            }

            if (b == 0)
            {
                SqlDataReader myReader = SqlManager.getQuery(q, conn);
                if (myReader.HasRows)
                {
                    myReader.Read();
                    ultraLabel_name.Text ="Nombre: "+myReader[0].ToString();
                    ultraLabel_career.Text ="Carrera: "+myReader[1].ToString();
                    if (radioButton_mat.Checked)
                        ced = myReader[2].ToString();
                }
                else
                    MessageBox.Show("No se ha encontrado estudiante.");
                myReader.Close();
            }
            else
            {
                MessageBox.Show("Debe elegir un parámetro de búsqueda.");
            }
        }

        private void ultraButton2_Click(object sender, EventArgs e)
        {
            String academicTerm=null, observation=null, espolAvg=null,ced=null;
            int gainedPoints = 0, totalPoints = 0, totalPoints_update=0;
            float espolAvg_float;

            academicTerm = ultraComboEditor_term.Text + " " + ultraTextEditor_anio1.Text + "-" + ultraTextEditor_anio2.Text;
            ced = ultraTextEditor_search.Text;
            observation = ultraTextEditor_observation.Text;
            espolAvg = ultraTextEditor_espolAvg.Text;
         
                bool parse = Int32.TryParse(ultraTextEditor_gainedPoints.Text, out gainedPoints);
                if (false == parse)
                {
                    MessageBox.Show("Formato puntos ganados incorrecto.\nDebe ser un entero.");
                }
                else
                {
                    String qTotalP = "SELECT acper.totalPoints FROM dbo.academicPerformance acper WHERE acper.userId='" + ced + "'" +
                                    "AND acper.inserted = (SELECT MAX(ap.inserted) FROM dbo.academicPerformance ap WHERE ap.userId='" + ced + "');";
                    SqlDataReader myReader = SqlManager.getQuery(qTotalP, conn);
                    if (myReader.HasRows)
                    {                        
                         myReader.Read();
                         totalPoints=Int32.Parse(myReader[0].ToString());
                         totalPoints_update = totalPoints - gainedPointsLast + gainedPoints;
                         totalPoints = totalPoints + gainedPoints;                      
                    }
                    else
                        totalPoints = gainedPoints;
                    myReader.Close();
                }

                parse = float.TryParse(espolAvg, NumberStyles.Any, CultureInfo.InvariantCulture, out espolAvg_float);
                if (parse == true)
                {
                    String insertedBy = null;
                    
                    if (ultraButton_saveEspol.Text == "GUARDAR")
                    {
                        
                        String burnAPquery = "INSERT INTO dbo.academicPerformance (userId,academicTerm,gainedPoints,totalPoints,espolAverage,observation,insertedBy)" +
                            "VALUES ('" + ced + "','" + academicTerm + "'," + gainedPoints + "," + totalPoints + "," + espolAvg_float + ",'" + observation + "','" + insertedBy + "');";

                        bool burn = SqlManager.executeQuery(burnAPquery, conn);
                        if (burn)
                        {
                            MessageBox.Show("Registro se ha guardado exitosamente.");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Su registro no ha podido ser guardado.");
                    }
                    else if (ultraButton_saveEspol.Text == "ACTUALIZAR")
                    {
                        
                        String updateAPquery = "UPDATE dbo.academicPerformance SET userId='" + ced + "',academicTerm='" + academicTerm + "',gainedPoints=" + gainedPoints + ",totalPoints=" + totalPoints_update + ",espolAverage=" + espolAvg_float + ",observation='"+observation+"' " +
                           "WHERE id="+referenceId;

                        MessageBox.Show(updateAPquery);
                        bool update = SqlManager.executeQuery(updateAPquery, conn);
                        if (update)
                        {
                            MessageBox.Show("Registro ha sido actualizado exitosamente.");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Su registro no ha podido ser actualizado.");
                    }
                }
                else
                {
                    MessageBox.Show("El formato ingresado de promedio ESPOL es incorrecto.");
                }
        }

        private void ultraButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            String q = "SELECT (us.name + us.lastname) AS 'Nombres', c.name AS 'Carrera' FROM dbo.users us JOIN dbo.career c ON us.careerId=c.id;";
            String val;
            int b = 0;
            
            if (radioButton_cedcourse.Checked)
            {
                val = ultraTextEditor_searchcourse.Value.ToString();
                ced = val;
                q = "SELECT (us.name + us.lastname) AS 'Nombres', c.name AS 'Carrera' FROM dbo.users us JOIN dbo.career c ON us.careerId=c.id AND us.id='" + val + "';";
            }
            else if (radioButton_matcourse.Checked)
            {
                val = ultraTextEditor_searchcourse.Value.ToString();

                q = "SELECT (us.name + us.lastname) AS 'Nombres', c.name AS 'Carrera', us.id as 'Cédula' FROM dbo.users us JOIN dbo.career c ON us.careerId=c.id AND us.registrationNumber='" + val + "';";

            }
            else
            {
                b = 1;
            }

            if (b == 0)
            {
                SqlDataReader myReader = SqlManager.getQuery(q, conn);
                if (myReader.HasRows)
                { 
                    myReader.Read();
                    ultraLabel_namecourse.Text = "Nombre: " + myReader[0].ToString();
                    ultraLabel_careercourse.Text = "Carrera: " + myReader[1].ToString();
                    if (radioButton_matcourse.Checked)
                        ced = myReader[2].ToString();
                }
                else
                    MessageBox.Show("No se ha encontrado estudiante.");

                myReader.Close();
            }
            else
            {
                MessageBox.Show("Debe elegir un parámetro de búsqueda.");
            }                        
        }

        private void ultraButton_savecourse_Click(object sender, EventArgs e)
        {
            String academicTerm = null, name = null, institution = null, duration = null, insertedBy = null, gainedCoursePoints = null, ced = null;

            academicTerm = ultraComboEditor_termcurso.Text + " " + ultraTextEditor_anio1course.Text + "-" + ultraTextEditor_anio2course.Text;
            name = ultraTextEditor_nameofcourse.Text;
            institution = ultraTextEditor_institutioncourse.Text;
            duration = numericUpDown_durationcountcourse.Value.ToString() + " " + ultraComboEditor_typedurationcourse.Text;
            insertedBy = userSession.getId();
            ced = ultraTextEditor_searchcourse.Value.ToString();
            gainedCoursePoints = ultraTextEditor_pointgetcourse.Text;
            


            if (ultraButton_savecourse.Text == "GUARDAR")
            {
                String burnCquery = "INSERT INTO dbo.course (name,gainedPoints,academicTerm,institution,duration,insertedBy,userId) VALUES ('" + name + "'," + gainedCoursePoints + ",'" + academicTerm + "','" + institution + "','" + duration + "','" + insertedBy + "','" + ced + "');";

                bool burn = SqlManager.executeQuery(burnCquery, conn);
                if (burn)
                {
                    MessageBox.Show("Registro guardado exitosamente.");
                    this.Close();
                }
                else
                    MessageBox.Show("Su registro no ha podido ser guardado.");
            }
            else if (ultraButton_savecourse.Text == "ACTUALIZAR")
            {
                String updateCquery = "UPDATE dbo.course SET name='" + name + "', gainedPoints='" + gainedCoursePoints + "', academicTerm='" + academicTerm + "', institution='" + institution + "',duration='" + duration + "',userId='" + ced + "' WHERE id="+referenceId;
                MessageBox.Show(updateCquery);


                bool burn = SqlManager.executeQuery(updateCquery, conn);
                if (burn)
                {
                    MessageBox.Show("Registro actualizado exitosamente.");
                    this.Close();
                }
                else
                    MessageBox.Show("Su registro no ha podido ser actualizado.");
            }
        }

        private void ultraButton_cancelcourse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
