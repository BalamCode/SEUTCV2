using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEUTCV2.Views;
using AccesoADatos;
namespace SEUTCV2.Views.Main
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MnuPanelGrupos_Click(object sender, EventArgs e)
        {
            FrmGrupos PanelGrupo = new FrmGrupos();
            PanelGrupo.MdiParent = this;
            PanelGrupo.Show();
        }

        private void MnuAsignarProfes_Click(object sender, EventArgs e)
        {
            Grupos.FrmProfesoresPorGrupo Asignar = new Grupos.FrmProfesoresPorGrupo();
            Asignar.MdiParent = this;
            Asignar.listarasigs();
            Asignar.Show();
            
        }

      

        private void mnuImport_Click(object sender, EventArgs e)
        {
            Views.ImportarExcel oImport = new Views.ImportarExcel();
            oImport.MdiParent = this;
            oImport.Show();

        }

        private void mnuPanelAlumnos_Click(object sender, EventArgs e)
        {
            FrmPanelAlumnos oAlumno = new FrmPanelAlumnos();
            oAlumno.MdiParent = this;
            oAlumno.Show();

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblPerfil.Text = "ROL : " + FrameBD.rol;
            lblUsuario.Text = "USUARIO: " + FrameBD.usuarioAcede;
        }

        private void mnuInfoPeriodo_Click(object sender, EventArgs e)
        {
            Main.frmDatosPeriodo oPeriodo = new Main.frmDatosPeriodo();
            oPeriodo.MdiParent = this;
            oPeriodo.Show();
        }

        private void mnuDatosGrupo_Click(object sender, EventArgs e)
        {
            Grupos.frmDatosGrupo oGrupo = new Grupos.frmDatosGrupo();
            oGrupo.MdiParent = this;
            oGrupo.Show();
        }

        private void mnuConcentrado_Click(object sender, EventArgs e)
        {
            frmConcentrado oCon = new frmConcentrado();
            oCon.MdiParent = this;
            oCon.Show();
        }

       
    }
}
