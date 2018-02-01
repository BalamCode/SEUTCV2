using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using SEUTCV2.Properties;
using System.Windows.Forms;

namespace AccesoADatos
{
   
  class FrameBD
    {
        //string ser;
        //string por;
        //string pas;
        //string use;
        //string db;
        MySqlConnection conex = new MySqlConnection();
       
        private string servidor;
        private uint puerto;
        private string usuario;
        private string password;
        private string bd;


      //public FrameBD(string servidor, uint puerto, string usuario, string password, string bd)
        public FrameBD()
        {
            // TODO: Complete member initialization
            this.servidor = Settings.Default.servidor;
            this.puerto = Settings.Default.puerto;
            this.usuario = Settings.Default.usuario;
            this.password = Settings.Default.pass;
            this.bd = Settings.Default.bd;


            conex.Close();
            MySqlConnectionStringBuilder conexs = new MySqlConnectionStringBuilder();
            conexs.Server = servidor;
            conexs.Port = puerto;//Convert.ToUInt32(por);
            conexs.Password = password; //pas;
            conexs.UserID = usuario; //use;
            conexs.Database = bd;

            //MySqlConnection conex = new MySqlConnection(conexs.ToString() );
            conex.ConnectionString = conexs.ConnectionString;
            //MySqlConnection conn = new MySqlConnection(builder.ToString());


            conex.Open(); 
            
        }
         
      public void conectar() 
        {
            conex.Close(); 
            conex.Open(); 
              
        }


      public  DataSet SQLSEL(string sql)
      {
          conectar();

          MySqlDataAdapter Adaptador = new MySqlDataAdapter(sql, conex);
          DataSet RsDatos = new DataSet();
          Adaptador.Fill(RsDatos, "datos");
          //SQLSEL = RsDatos;
          return (RsDatos);
          //conex.Close(); 
      }

      //TRABAJA CON COMBOBOX

      public DataTable SQLCOMBO(string sql) 
      {
          conectar();
          MySqlDataAdapter Adap = new MySqlDataAdapter(sql,conex);
          DataTable DT = new DataTable();
          Adap.Fill(DT);
          return DT;
 
      }

      //Permite ejecutar comandos INSERT, DELETE Y UPDATE
      // De ahi deriva el IDU
      public void SQLIDU(string sql) 
      {
           
          try
          {
              
              conectar();
              MySqlCommand comando = new MySqlCommand(sql, conex);
              comando.ExecuteNonQuery();
              //conex.Close();
              


          }
          catch (MySqlException ex) 
          {
           
              
              MessageBox.Show(ex.Message + " " + ex.Number); 
              
              
              //throw;
          }
          
      }

      public MySqlDataReader SQLReader(string sql) 
      {
          conectar();
          MySqlCommand comando = new MySqlCommand(sql, conex);
          
         MySqlDataReader Dr = comando.ExecuteReader();
          return Dr;


      }

      public string[] ObtieneCampo(string tabla,string condicion,string campo) 
      {
          
          string sqlaux = "SELECT " + campo +
                         " FROM " + tabla +
                         " WHERE " + condicion;

          MySqlDataReader dt =  SQLReader(sqlaux);
          int cont = 0;

          string[] respaux= new string[0];
          if (dt.HasRows)
          {
             
              while (dt.Read())
              {
                  Array.Resize(ref respaux, respaux.Length + 1);
                  respaux[cont] = dt.GetString(0);
                  cont++;
                  
              }
          }
          return respaux;

      }

      


      
      /*
       *Public Function SQLREADER(ByVal sql) As MySqlDataReader
        Try
            conectar()
            Dim comando As New MySqlCommand(sql, conex)
            Dim Dr As MySqlDataReader
            Dr = comando.ExecuteReader()
            Return Dr
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
       */

      


    }





}
