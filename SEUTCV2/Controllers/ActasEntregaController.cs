using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;

using System.Windows.Forms;

namespace SEUTCV2.Controllers
{
    class ActasEntregaController
    {
        public string acta { get; set; }
        public string fecha_entrega { get; set; }
        public string fecha_planeada { get; set; }
        public string fecha_subida { get; set; }
        public string claveAsig { get; set; }
        public string clavePeriodo { get; set; }
        public uint unidad { get; set; }
        public double ponderacion { get; set; }
        public string tipo_unidad { get; set; }
        public string claveGrupo { get; set; }
        
        //propiedades de detalle
        
        
        public void Store()
        {
            // Se almacenan los datos de la entrega de las calificaciones
            string sql;
            sql =  string.Format("INSERT INTO actas_entrega(acta,fecha_planeada,fecha_entrega,fecha_subida,claveAsig,clavePeriodo,unidad,ponderacion,tipo_unidad,claveGrupo)" +
                                     " VALUES('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7},'{8}','{9}');", acta, fecha_planeada, fecha_entrega, fecha_subida, claveAsig, clavePeriodo, unidad, ponderacion, tipo_unidad,claveGrupo);

            // Se marca la unidad como entregada
            sql = sql + "UPDATE ponderaciones set entregado=1" + 
                        " WHERE idasignatura='" + claveAsig + "' AND idperiodo='" +  clavePeriodo + "' AND unidad=" + unidad + ";" ;

            FrameBD.SQLIDU(sql);
            
        }

        public void Store_DetalleActas(DataGridView dgv)
        {
            // Se guardan los detalles de las calificaciones
            string detalle = "";
            for (int i = 0; i < dgv.RowCount; i++)
            {
                string mat = dgv[0,i].Value.ToString();
                string cal = dgv[2,i].Value.ToString();
                string falta = dgv[4,i].Value.ToString();
                string niv = dgv[3,i].Value.ToString();
                double tot = Convert.ToDouble(cal) * (ponderacion/100);

                detalle = detalle + String.Format("INSERT INTO detalles_entrega(acta,clavePeriodo,claveGrupo,claveAsig,unidad,matricula,calificacion,ponderacion,nivel,total_unidad)" +
                                   " VALUES('{0}','{1}','{2}','{3}',{4},'{5}',{6},{7},'{8}',{9});", acta, clavePeriodo, claveGrupo, claveAsig, unidad, mat, cal, ponderacion, niv, tot.ToString("0.0"));

            }
            FrameBD.SQLIDU(detalle);

        }




    }

}
