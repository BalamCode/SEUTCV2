using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoADatos;
using System.Windows.Forms;

namespace SEUTCV2.Controllers
{
    class CarreraController
    {

        


        public DataTable GetCarreras()
        {

            string sql = "SELECT idCarrera,Nombre FROM Carreras";
            return FrameBD.SQLCOMBO(sql);


        }


        public void GetCarreras(ComboBox cmb)
        {

            string sql = "SELECT idCarrera,Nombre FROM Carreras";


            cmb.DataSource = FrameBD.SQLCOMBO(sql);
            cmb.DisplayMember = "Nombre";
            cmb.ValueMember = "idCarrera";

            
        }
    }
}
