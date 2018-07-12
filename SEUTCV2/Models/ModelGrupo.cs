using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Windows.Forms;
using System.Data;
using SEUTCV2.Properties;


namespace SEUTCV2.Models
{
    public class ModelGrupo
    {

        public static string clavegrupo;
        public static string periodo;
        public static string idcarrera;
        public static string grado;
        public static string grupo;
        public static string cupo; 
        public static string claveplan;
        public static string  inscritos; 
        public static string bajas; 
        public static string fechacreacion; 
        public static string creador;
        public static string tutor;


        public static void getDatosGrupoTutorado() 
        {
            string[] datos = FrameBD.ObtieneCampos("grupos",
                 "idtutor='" + FrameBD.clavetutor + "' AND periodo='" + ModelPeriodo.periodo + "'",
                 "clavegrupo,idcarrera,grado,grupo,periodo,inscritos,bajas,fechacreacion,idtutor");

            clavegrupo = datos[0];
            idcarrera = datos[1];
            grado = datos[2];
            periodo = datos[4];
            inscritos = datos[5];
            bajas = datos[6];
            fechacreacion = datos[7];
            tutor = FrameBD.usuarioAcede;

            

        }
    }
}
