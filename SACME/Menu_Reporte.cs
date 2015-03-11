using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACME
{
    public partial class Menu_Reporte : Form
    {
        public Menu_Reporte(String directorshipName)
        {
            InitializeComponent();

            if (directorshipName.Equals("LIDER") || directorshipName.Equals("VICELIDER") || directorshipName.Equals("CONSEJERO"))
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
            }
            else if (directorshipName.Equals("LIDER DE RAMA"))
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button6.Visible = false;
            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes_Miembros consulta = new Reportes_Miembros();
            consulta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reportes_Postulantes consulta1 = new Reportes_Postulantes();
            consulta1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes_General consulta2 = new Reportes_General();
            consulta2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reporte_Actividades_Rama_Mensual consulta3 = new Reporte_Actividades_Rama_Mensual();
            consulta3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reporte_Actividad_Rama_Anual consulta4 = new Reporte_Actividad_Rama_Anual();
            consulta4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reporte_Actividades consulta5 = new Reporte_Actividades();
            consulta5.Show();
        }

        private void Menu_Reporte_Load(object sender, EventArgs e)
        {

        }
    }
}
