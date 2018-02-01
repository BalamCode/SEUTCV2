using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEUTCV2.Models;
using AccesoADatos;
using SEUTCV2.Properties;
using System.Windows.Forms;
using System.Data;

namespace SEUTCV2.Controllers
{
    class ProfesorController

    {
        FrameBD FrameSQL = new FrameBD();
        ModelProfesor ClaseProfesor = new ModelProfesor();

       
        public void Store(ModelProfesor OProfe)
        {
            
            
            String ComandoSQL = string.Format("INSERT INTO profesores (cedula,nombre,apellidop,apellidom,nivelestudio)VALUES ('{0}','{1}','{2}','{3}','{4}');",
                     OProfe.cedula, OProfe.nombre, OProfe.apellidop, OProfe.nombre, OProfe.nivel);


            FrameSQL.SQLIDU(ComandoSQL);

        }

        public DataTable GetProfesores() 
        {
            DataTable x = new DataTable();
            string sqlprofes = "SELECT cedula,concat(ApellidoP,' ',ApellidoM,' ',Nombre) as Docente" +
                               " FROM Profesores " +
                               " WHERE Activo=1" + 
                               " ORDER By ApellidoP ASC";
            x = FrameSQL.SQLCOMBO(sqlprofes);
            return x;

        }


    }
}
