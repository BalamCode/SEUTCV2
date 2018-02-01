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
            Asignar.Show();
        }
    }
}
