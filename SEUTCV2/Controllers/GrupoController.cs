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
         
        // ModelGrupo Grupo = new ModelGrupo();


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
            cmb.SelectedIndex = 0;
            //MessageBox.Show(cmb.SelectedValue.ToString());


        }

        public void GetGrupos(ComboBox cmb,string idcarrera)
        {
            string sql = "";

            sql = "SELECT ClaveGrupo,idTutor" +
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

       

        public void StoreGrupos(string clavegrupo, string periodo,string idcarrera,string grado,string grupo,string cupo,string claveplan,string fechacreacion)
        {
            //Type m_tipo = null;
            //PropertyInfo[] m_propiedades = null;

            //m_tipo = grup.GetType();
            
            //m_propiedades = m_tipo.GetProperties();

            //foreach (PropertyInfo propiedad in m_propiedades)
            //{
                
            //}



            String ComandoSQL = string.Format("INSERT INTO Grupos (clavegrupo,periodo,idcarrera,grado,grupo,cupo,claveplan,fechacreacion)" +
                                              " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                                              clavegrupo,periodo, idcarrera, grado, grupo, cupo, claveplan, fechacreacion);


            FrameBD.SQLIDU(ComandoSQL);




            string[] asignaturas;
            asignaturas = FrameBD.ObtieneCampo("asignaturas", "idcarrera='" + idcarrera + "' AND cuatrimestre=" + grado, "ClaveAsig");


            if (asignaturas.Length > 1)
            {
                string sqlasigs = "INSERT INTO docentesporgrupo(periodo,claveasig,cedula,clavegrupo) VALUES";
                for (int i = 0; i < asignaturas.Length; i++)
                {
                    if (i < (asignaturas.Length - 1))
                    {
                        sqlasigs = sqlasigs +
                        " ('" + SEUTCV2.Properties.Settings.Default.periodo + "','" +
                        asignaturas[i] + "','01','" + clavegrupo + "'),";

                    }
                    else
                    {
                        sqlasigs = sqlasigs +
                        " ('" + SEUTCV2.Properties.Settings.Default.periodo + "','" +
                        asignaturas[i] + "','01','" + clavegrupo + "');";


                    }
                    


                }

                FrameBD.SQLIDU(sqlasigs);
            }
            else
                MessageBox.Show("No hay asignaturas para carrera y grado seleccionado");
                
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

        public void ObtenerMateriasXGrupo(string grupo, DataGridView dtg)

        {
            string idcarrera = grupo.Substring(0, 3);
            string idgrado = grupo.Substring(4, 1);

            
            string sqldatos = "Select ClaveAsig as Clave,Nombre as Asignatura,GetUnidadesEntregadasPorMateria('2018B','" + grupo + "',ClaveAsig) as Entregadas," + 
                              " GetUnidadesAcumuladaEntregadasPorMateria('2018B','" + grupo + "',ClaveAsig) as 'Avance'" +
                              " FROM Asignaturas" +
                             " WHERE idCarrera='" + idcarrera + "' AND Cuatrimestre=" + idgrado;
            dtg.DataSource = FrameBD.SQLSEL(sqldatos);
            dtg.DataMember = "datos";

            dtg.Columns["Asignatura"].Width = 290;

        }

        public void ObtenerMaterias(string periodo, string grupo, ComboBox dtg)
        {
            string sqldatos = "Select Asig.ClaveAsig as Clave,Asig.Nombre as Asignatura" +
                              " FROM Asignaturas as Asig  INNER JOIN docentesporgrupo as Doc ON Asig.ClaveAsig=Doc.ClaveAsig" +
                              " WHERE Doc.periodo='" + periodo + "' AND Doc.ClaveGrupo='" + grupo + "'";
            dtg.DataSource = FrameBD.SQLCOMBO(sqldatos);
            dtg.DisplayMember = "Asignatura";
            dtg.ValueMember = "Clave";

        }


        public void GetMateriasYProfes(ComboBox cmb, DataGridView dtg)
        {

            dtg.Columns.Clear();
            if (cmb.Items.Count > 0)
            {
                string sqldatos = "Select Asig.ClaveAsig as Clave,Asig.Nombre as Asignatura,Doc.Cedula" +
                                  " FROM Asignaturas as Asig INNER JOIN docentesporgrupo as Doc ON Asig.ClaveAsig=Doc.ClaveAsig" +
                                 " WHERE Doc.clavegrupo='" + cmb.SelectedValue.ToString() + "'";
                //dtg.DataSource = FrameBD.SQLSEL(sqldatos);
                //dtg.DataMember = "datos";



                DataGridViewComboBoxColumn cmbdgv = new DataGridViewComboBoxColumn();
                //List<String> itemCodeList = new List<String>();
                //Cprofe.GetProfesores(cmbdgv);
                SEUTCV2.Controllers.ProfesorController oProfe = new SEUTCV2.Controllers.ProfesorController();
                cmbdgv.DataSource = oProfe.GetProfesores();
                cmbdgv.ValueMember = "cedula";
                cmbdgv.DisplayMember = "Docente";
                cmbdgv.HeaderText = "Profesores";
                cmbdgv.Name = "Profesores";
                cmbdgv.Width = 300;
                cmbdgv.DataPropertyName = "Cedula";
                //cmbdgv.Items.Add("Gilberto");
                //cmbdgv.Items.Add("Ivan");
                dtg.Columns.Add(cmbdgv);

                // dtg.Columns["Cedula"].Visible = true;

                dtg.DataSource = FrameBD.SQLSEL(sqldatos);
                dtg.DataMember = "datos";
                dtg.Columns["Profesores"].DisplayIndex = 2;
                dtg.Columns["Asignatura"].Width = 300;
                
            }
           






        }

        public void AsignarTutor(string cedula, string grupo) 
        {
            FrameBD.SQLIDU("UPDATE grupos SET idTutor='" + cedula + "'" + "WHERE clavegrupo='" + grupo + "'");

        }

        public string ObtenerTutor(string grupo) 
        {
            string[] res = FrameBD.ObtieneCampo("grupos", "clavegrupo='" + grupo + "'", "idtutor");
            if (res.Length > 0)
                return res[0];
            else
                return "";
        }

        public void GuardarProfesMat(string[] materias, string[] profesores, string periodo, string clavegrupo) 
        {
            String ComandoSQL="";
            for (int i=0; i < materias.Length; i++)
            {

                ComandoSQL = ComandoSQL + "UPDATE docentesporgrupo SET cedula='" + profesores[i] + "' WHERE ClaveAsig='" + materias[i] + "' AND Periodo='" +
                            periodo + "' AND clavegrupo='" + clavegrupo + "';";
                
                                              
            }

            FrameBD.SQLIDU(ComandoSQL);


        }



        public void resumen(string claveasig,string asig,string periodo, string grupo,string unidad, DataGridView dgv) 
        {
            dgv.Columns.Clear();
            string unidades="";
            //string pond ="SUM(";
            for (int i = 0; i < Convert.ToInt32(unidad); i++)
            {


                if ((i + 1) < Convert.ToInt32(unidad))
                {
                    unidades = unidades + String.Format("getTotalUnidadxAsig(alumnos.Matricula,{4},'{2}','{3}','{0}') as '{1}" + " U" + (i + 1) + "',", claveasig, asig, periodo, grupo, i + 1);
                    //pond = pond + String.Format("ROUND(getTotalUnidadxAsig(alumnos.Matricula,{4},'{2}','{3}','{0}'),1)", claveasig, asig, periodo, grupo, i + 1) + "+";
                }
                else
                {
                    unidades = unidades + String.Format("getTotalUnidadxAsig(alumnos.Matricula,{4},'{2}','{3}','{0}') as '{1}" + " U" + (i + 1) + "'", claveasig, asig, periodo, grupo, i + 1);
                    //pond = pond + String.Format("ROUND(getTotalUnidadxAsig(alumnos.Matricula,{4},'{2}','{3}','{0}'),1)", claveasig, asig, periodo, grupo, i + 1) + ") as Acumulado";
                }

            }

            string acumulado = "";
            acumulado = String.Format(",Round(getAcumuladoPorAlumno('{0}','{1}','{2}',alumnos.Matricula),2) as Acumulado," +
                                    " Round(getPromedioPorAlumno('{0}','{1}','{2}',alumnos.Matricula),1) as Promedio", periodo, grupo, claveasig);

            string sql = "SET NAMES 'utf8';";
                
                sql = sql + string.Format("SELECT alumnos.Matricula,Concat(alumnos.ApellidoP,' ',alumnos.ApellidoM,' ',alumnos.Nombre)as Alumno," +
            unidades + 
            acumulado +
 
            " FROM alumnos" + 
            " WHERE alumnos.GrupoActual='{3}'",claveasig,asig,periodo,grupo,unidad);

            
            
            dgv.DataSource = FrameBD.SQLSEL(sql);
            dgv.DataMember = "datos";

            dgv.Columns["Alumno"].Width = 250;
            dgv.ColumnHeadersHeight = 100;
            //dgv.Columns["Acumulado"].DisplayIndex = dgv.Columns.Count-1;
            
            //dgv.Columns.Add("Promedio","Promedio");

            
            



        
        }

      
       

      
    }

}
