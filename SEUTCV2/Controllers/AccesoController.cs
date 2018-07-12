using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;

namespace SEUTCV2.Controllers
{
    class AccesoController
    {
        public string[] validar(string user,string pass) 
        {
            string[] getpass= FrameBD.ObtieneCampos("users", "login='" + user + "'", "pass,proviene,clave,idrol");
            string[] datos= new string[4];
            //string res="";
            if (getpass.Length == 0 || getpass[0] !=pass)
                datos[0]="false";

            else if (getpass.Length >= 1)
            {
                // paso al vector que si se encontró el usuario
                datos[0] = "true";
                // Paso el password obtenido
                datos[1] = getpass[0];
                // claveTutor
                FrameBD.clavetutor = getpass[2];

                string[] getDatosUser;
                getDatosUser = FrameBD.ObtieneCampos("(" + getpass[1] + " INNER JOIN users ON users.clave="
                                        + getpass[1] + ".cedula) INNER JOIN roles On roles.idrol=users.idrol", getpass[1] + ".cedula='" + getpass[2] + "' AND  users.pass='" + getpass[0] + "'"
                                        , "Concat(profesores.tratamiento,' '," + getpass[1] + ".nombre,' '," + getpass[1] + ".ApellidoP,' '," + getpass[1] + ".ApellidoM) as Profesor,roles.rol");
                // nombre del usuario
                datos[2] = getDatosUser[0];
               
                // rol del usuario
                datos[3] = getDatosUser[1];

            }
            return datos;





 
        }
    }
}
