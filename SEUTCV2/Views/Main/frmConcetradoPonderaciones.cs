using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEUTCV2.Controllers;

namespace SEUTCV2.Views.Main
{
    public partial class frmConcentrado : Form
    {
        GrupoController oGrup = new GrupoController();
        public frmConcentrado()
        {
            InitializeComponent();
        }

        private void frmConcetradoPonderaciones_Load(object sender, EventArgs e)
        {
            oGrup.ObtenerMateriasXGrupo(Models.ModelGrupo.clavegrupo, dataGridView1);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string clave = dataGridView1[0, dataGridView1.CurrentCellAddress.Y].Value.ToString();
            string asig = dataGridView1[1, dataGridView1.CurrentCellAddress.Y].Value.ToString();
            string unidades = dataGridView1[2, dataGridView1.CurrentCellAddress.Y].Value.ToString();

            if (unidades !="0")
            oGrup.resumen(clave, asig, Models.ModelPeriodo.periodo, Models.ModelGrupo.clavegrupo, unidades, dataGridView2);


            //dataGridView2.Columns.Add("Acumulado", "Acumulado");

            //int fincolumna = dataGridView2.Columns.Count - 1;
            //for (int i = 0; i < dataGridView2.RowCount; i++)
            //{
            //    Single sum = 0;
            //    for (int j = 2; j < fincolumna; j++)
            //    {
            //        if (dataGridView2[j, i].Value.ToString() != "")
            //            sum = sum + Convert.ToSingle(dataGridView2[j, i].Value.ToString());
            //    }
            //}
        }
    }
}
