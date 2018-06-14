using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoADatos;

namespace SEUTCV2.Controllers
{
    class CarreraController
    {

        


        public DataTable GetCarreras()
        {

            string sql = "SELECT idCarrera,Nombre FROM Carreras";
            return FrameBD.SQLCOMBO(sql);


        }
    }
}
