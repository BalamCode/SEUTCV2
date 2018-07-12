using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Windows.Forms;

namespace SEUTCV2.Controllers
{
    class AlumnosController
    {
        public void FiltroAlumnos(DataGridView dgv,string carrera,string grupo, string periodo,string partial) 
        {
            // Este método depende de los alumnos relacionados en el periodo. aun está pendiente generar esa relacion. 
            // por ahora se filtrará solop or grupo y por carrera. Es ncesario agregar en el WHERE el periodo
            // Si no se hiciera nos aparecerías los alumnos que alguna vex pertenecieron al mismo grupo a traves del tiempo 10/07/18
            string sql = "SELECT Matricula,Concat(apellidop,' ',apellidom,' ',nombre) as Alumno" +
                        " FROM alumnos" +
                        " WHERE grupoactual='" + grupo + "' AND idCarrera='" + carrera + "'" + 
                        " AND apellidop LIKE'" + partial + "%'";
            dgv.DataSource = FrameBD.SQLSEL(sql);
            dgv.DataMember = "datos";
            dgv.Columns[1].Width = 250;



        }
    }
}
