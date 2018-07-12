using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Windows.Forms;

namespace SEUTCV2.Controllers
{
    class TutorController
    {

        public void ComboTutor(ComboBox cmb) 
        {
            cmb.DataSource = FrameBD.SQLCOMBO("SELECT * from profesores");


        }
    }
}
