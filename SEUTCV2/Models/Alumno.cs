using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace SEUTCV2.Models
{
    class Alumno
    {
        FrameBD Alumnos = new FrameBD();

        public void ListaAlumnos (DataGridView dgv,string filtro)
        {
            dgv.DataSource = Alumnos.SQLSEL("SELECT Matricula,concat(ApellidoP,' ',ApellidoM,' ',Nombre)as Alumno from Alumnos WHERE ApellidoP LIKE '" + filtro + "%' OR NOMBRE Like '" + filtro + "%'");
            dgv.DataMember = "datos";
        }

    }
}
