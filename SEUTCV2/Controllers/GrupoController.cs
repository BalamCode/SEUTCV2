using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Data;
using SEUTCV2.Models;
using System.Windows.Forms;
using SEUTCV2.Properties;

namespace SEUTCV2.Controllers

{
    class GrupoController
    {
         
         ModelGrupo Grupo = new ModelGrupo();


        //Obtiene todos los grupos
        public DataSet GetGrupos() 
        {
            string sql = "";
            
            sql = "SELECT ClaveGrupo as Clave,Grado,Grupo,FechaCreacion as Creado" +
                             " FROM Grupos WHERE periodo='" + Settings.Default.periodo + "'";
            
            return FrameBD.SQLSEL(sql); 
            
            
        }

        //Obtiene la lista de los grupos para presentar en un ComboBox
        public void GetGrupos(ComboBox cmb)
        {
            string sql = "";

            sql = "SELECT ClaveGrupo" +
           " FROM Grupos WHERE periodo='" + Settings.Default.periodo + "' ORDER By ClaveGrupo ASC";

            cmb.DataSource = FrameBD.SQLCOMBO(sql);
            cmb.ValueMember = "ClaveGrupo";
            cmb.DisplayMember = "ClaveGrupo";


        }

        public void GetGrupos(ComboBox cmb,string idcarrera)
        {
            string sql = "";

            sql = "SELECT ClaveGrupo" +
           " FROM Grupos WHERE periodo='" + Settings.Default.periodo + "' AND IdCarrera='" + idcarrera + "' ORDER By ClaveGrupo ASC";

            cmb.DataSource = FrameBD.SQLCOMBO(sql);
            cmb.ValueMember = "ClaveGrupo";
            cmb.DisplayMember = "ClaveGrupo";


        }



        //Obtiene los grupos de acuerdo a una CARRERA
        public DataSet GetGrupos(string idcarrera) 
        {
            
                string sql = "";

                sql = "SELECT ClaveGrupo as Clave,Grado,Grupo,FechaCreacion as Creado" +
                                 " FROM Grupos " +
                                 " WHERE idCarrera ='" + idcarrera + "' AND periodo='" + Settings.Default.periodo + "'";
                return FrameBD.SQLSEL(sql);
        

            
        }

       

        public void StoreGrupos(ModelGrupo grup)
        {
            //Type m_tipo = null;
            //PropertyInfo[] m_propiedades = null;

            //m_tipo = grup.GetType();
            
            //m_propiedades = m_tipo.GetProperties();

            //foreach (PropertyInfo propiedad in m_propiedades)
            //{
                
            //}



            String ComandoSQL = string.Format("INSERT INTO Grupos (clavegrupo,periodo,idcarrera,grado,grupo,cupo,claveplan,fechacreacion)" +
                                              " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", grup.clavegrupo, grup.periodo, grup.idcarrera, grup.grado, grup.grupo, grup.cupo, grup.claveplan, grup.fechacreacion);

            FrameBD.SQLIDU(ComandoSQL);




            string[] asignaturas;
            asignaturas = FrameBD.ObtieneCampo("asignaturas", "idcarrera='" + grup.idcarrera + "' AND cuatrimestre=" + grup.grado, "ClaveAsig");



            
            for (int i = 0; i < asignaturas.Length; i++)
            {
                string sqlasigs = "INSERT INTO docentesporgrupo(periodo,claveasig,cedula,clavegrupo)" +
                                 " VALUES('" + SEUTCV2.Properties.Settings.Default.periodo + "','" +
                                 asignaturas[i] + "','01','" + grup.clavegrupo + "')";
                FrameBD.SQLIDU(sqlasigs);
            }
                
        }

        public void Destroy(string id) 
        {
            string sqldes = "DELETE FROM Grupos WHERE clavegrupo='" + id + "'";
            FrameBD.SQLIDU(sqldes);


        }

        public void ObtenerMaterias(string idcarrera,string idgrado,DataGridView dtg)
        {
            string sqldatos = "Select ClaveAsig as Clave,Nombre as Asignatura FROM Asignaturas" +
                             " WHERE idCarrera='" + idcarrera + "' AND Cuatrimestre=" + idgrado;
            dtg.DataSource = FrameBD.SQLSEL(sqldatos);
            dtg.DataMember = "datos";
                    
        }


        public void GetMateriasYProfes(string idcarrera, string idgrado, DataGridView dtg)
        {
            string sqldatos = "Select Asig.ClaveAsig as Clave,Asig.Nombre as Asignatura,Doc.Cedula" +
                              " FROM Asignaturas as Asig INNER JOIN docentesporgrupo as Doc ON Asig.ClaveAsig=Doc.ClaveAsig" +
                             " WHERE Asig.idCarrera='" + idcarrera + "' AND Asig.Cuatrimestre=" + idgrado;
            dtg.DataSource = FrameBD.SQLSEL(sqldatos);
            dtg.DataMember = "datos";

        }



      
       

      
    }

}
