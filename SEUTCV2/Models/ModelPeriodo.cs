using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;

namespace SEUTCV2.Models
{
    public class ModelPeriodo
    {
        public static string periodo;
        public static string inicio;
        public static string fin;
        public static string nombreperiodo;





         public static void getDatos() 
        {
            string[] datos = FrameBD.ObtieneCampos("periodos","activo=1","claveperiodo,inicio,fin,nombregenerico");
 
            periodo = datos[0];
            inicio = datos[1];
            fin = datos [2];
            nombreperiodo = datos[3];
              
        }
    }

    
}
