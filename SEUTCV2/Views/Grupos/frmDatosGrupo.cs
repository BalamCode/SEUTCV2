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

namespace SEUTCV2.Views.Grupos
{
    public partial class frmDatosGrupo : Form
    {
        public frmDatosGrupo()
        {
            InitializeComponent();
        }

        private void frmDatosGrupo_Load(object sender, EventArgs e)
        {
            txtPeriodo.Text = ModelGrupo.periodo;
            txtCarrera.Text = ModelGrupo.idcarrera;
            txtGrupo.Text = ModelGrupo.clavegrupo;
            txtGrado.Text = ModelGrupo.grado;
            txtInscritos.Text = ModelGrupo.inscritos;
            txtBajas.Text = ModelGrupo.bajas;
        }
    }
}
