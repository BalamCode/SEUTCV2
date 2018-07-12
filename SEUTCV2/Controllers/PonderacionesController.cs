using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Windows.Forms;

namespace SEUTCV2.Controllers
{
    class PonderacionesController
    {

        public void InicioPonderacion(DataGridView dgvPondera) 
        {
            dgvPondera.Columns.Add("unidad", "Unidad");
            dgvPondera.Columns.Add("ponderacion", "Ponderación");
            dgvPondera.Columns.Add("tipo", "Tipo");

            dgvPondera.Rows.Add("1", "0", "C");
            dgvPondera.Rows.Add("2", "0", "C");
            dgvPondera.Rows.Add("3", "0", "C");
            dgvPondera.Rows.Add("4", "0", "C");
            dgvPondera.Rows.Add("5", "0", "C");
            dgvPondera.Rows.Add("6", "0", "C");
            dgvPondera.Rows.Add("7", "0", "C");

            dgvPondera.Columns["unidad"].Width = 75;

        }
    }
}
