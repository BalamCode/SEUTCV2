using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Windows.Forms;

namespace SEUTCV2.Controllers
{
    class MotivosController
    {


        public void getMotivos(ComboBox cmb)
        {
            String con = "SELECT id_motivo,motivo FROM motivos";
            cmb.DataSource = FrameBD.SQLCOMBO(con);
            cmb.DisplayMember = "motivo";
            cmb.ValueMember = "id_motivo";
            
        }
    }

   
}
