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

namespace SEUTCV2.Views.Main
{
    public partial class frmDatosPeriodo : Form
    {
        public frmDatosPeriodo()
        {
            InitializeComponent();
        }

        private void frmDatosPeriodo_Load(object sender, EventArgs e)
        {
            txtPeriodo.Text = ModelPeriodo.periodo;
            txtInicio.Text = ModelPeriodo.inicio;
            txtFin.Text = ModelPeriodo.fin;
            txtNombre.Text = ModelPeriodo.nombreperiodo;
        }
    }
}
