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
using SEUTCV2.Controllers;
using SEUTCV2.Views;
using AccesoADatos;
 
namespace SEUTCV2
{
    public partial class FrmPanelAlumnos : Form
    {
        //Alumno x = new Alumno();
        AlumnosController oAlumno = new AlumnosController();
        GrupoController oGrup = new GrupoController();
        ProfesorController oProfe = new ProfesorController();
        CarreraController oCarrera = new CarreraController();

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
            //x.ListaAlumnos(dataGridView1,TxtAlumno.Text); 

            if (FrameBD.rol == "Tutor Académico")
            {
                    oCarrera.GetCarreras(CmbCarreras);
                    
                    //CmbGrupos.SelectedIndex = 0;
            
                    CmbCarreras.SelectedValue = ModelGrupo.idcarrera;

                CmbCarreras.Enabled = false;

                //oGrup.GetGrupos(CmbGrupos);
                oGrup.GetGrupos(CmbGrupos, CmbCarreras.SelectedValue.ToString());
                CmbGrupos.SelectedValue = ModelGrupo.clavegrupo;
                CmbGrupos.Enabled = false;

                oProfe.GetProfesores(CmbTutor);               
                
                CmbTutor.SelectedValue = FrameBD.clavetutor;
                CmbTutor.Enabled = false;
                



            }
            else
            {

            }
            


            //oCarrera.GetCarreras(CmbCarreras);
            //oGrup.GetGrupos(CmbGrupos);
            //CmbGrupos.SelectedIndex = 0;
            
            
            //oProfe.GetProfesores(CmbTutor);
            //CmbTutor.SelectedValue = oGrup.ObtenerTutor(CmbGrupos.SelectedValue.ToString());
            filtroAlumnos();
        }

        private void TxtAlumno_TextChanged(object sender, EventArgs e)
        {
            //x.ListaAlumnos(dataGridView1, TxtAlumno.Text); 
            filtroAlumnos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ExportExcel oExcel = new ExportExcel();
            string mat = dataGridView1[0, dataGridView1.CurrentCellAddress.Y].Value.ToString();
            string alumno = dataGridView1[1, dataGridView1.CurrentCellAddress.Y].Value.ToString();

            Views.Alumnos.frmJustificaciones oJust = new Views.Alumnos.frmJustificaciones();
            oJust.Owner = this;
            oJust.SetDatos(CmbGrupos.SelectedValue.ToString(), CmbCarreras.SelectedValue.ToString(), CmbCarreras.Text, mat, alumno);
            oJust.Show();
            //ExportExcel oExcel = new ExportExcel();
            //oExcel.ExportarExcel(mat,alumno);
        }

        void filtroAlumnos() 
        {
            oAlumno.FiltroAlumnos(dataGridView1,CmbCarreras.SelectedValue.ToString(),CmbGrupos.SelectedValue.ToString(),"",TxtAlumno.Text);

        }

        private void CmbGrupos_SelectedValueChanged(object sender, EventArgs e)
        {
           

        }

        private void CmbGrupos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CmbTutor.SelectedValue = oGrup.ObtenerTutor(CmbGrupos.SelectedValue.ToString());
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
