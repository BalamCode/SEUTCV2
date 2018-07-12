using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
namespace SEUTCV2.Controllers
{
    class JustificacionesController
    {

        public string folio { get; set; }
        public string periodo { get; set; }
        public string grupo { get; set; }
        public string id_carrera { get; set; }
        public string matricula { get; set; }
        public string alumno { get; set; }
        public string id_motivo { get; set; }
        public string fecha_solicitud { get; set; }
        public int num_dias { get; set; }
        public string modulos { get; set; }
        public string id_tutor { get; set; }
        public string comentario { get; set; }
        public string[] fechas_falta { get; set; }

        ExportExcel oExcel = new ExportExcel();


        public void Store() 
        {
            string comando = String.Format("INSERT INTO justificaciones VALUES('{0}','{1}','{2}','{3}','{4}',{5},'{6}',{7},'{8}','{9}','{10}');",
                folio, periodo, grupo, id_carrera, matricula, id_motivo, fecha_solicitud, num_dias, modulos, id_tutor, comentario);
            string faltas = "";
            for (int i = 0; i < num_dias; i++)
            {
                comando = comando + String.Format("INSERT INTO detalle_justificaciones VALUES('{0}','{1}');", folio, fechas_falta[i]);
                DateTime auxdate;
                string fech="";
                auxdate = Convert.ToDateTime(fechas_falta[i]);
                fech = auxdate.ToString("dd/MM/yyyy");

                if (i==(num_dias-1))
                    faltas = faltas + fech;
                else
                    faltas = faltas + fech + ",";
            }


            FrameBD.SQLIDU(comando);

            oExcel.ExportarExcel(periodo, id_carrera, grupo, matricula, alumno, fecha_solicitud, faltas, modulos);
            

            
        }
    }
}
