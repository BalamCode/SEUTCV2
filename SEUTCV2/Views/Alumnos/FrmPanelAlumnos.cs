using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEUTCV2.Models;
 
namespace SEUTCV2
{
    public partial class FrmPanelAlumnos : Form
    {
        Alumno x = new Alumno();
        public FrmPanelAlumnos()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          
        }

        private void FrmPanelAlumnos_Load(object sender, EventArgs e)
        {
            x.ListaAlumnos(dataGridView1,TxtAlumno.Text); 
        }

        private void TxtAlumno_TextChanged(object sender, EventArgs e)
        {
            x.ListaAlumnos(dataGridView1, TxtAlumno.Text); 
        }
    }
}
