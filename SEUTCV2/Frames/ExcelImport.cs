using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
namespace SEUTCV2.Frames
{
    class ExcelImport
    {
        string celda = "";



        double calif = 0;
        public string matricula = "";
        string alumno = "";
        string faltas = "";
        string desempeno = "";

        public void Abrir(string archivo,string unidad, DataGridView dgv,System.Windows.Forms.Label men) 
        {
            //abrimos el dialogo para poder obtener el nombre la ubicacion del archivo
            //ofdAbrirArchivo.ShowDialog();
            //string sArchivo = ofdAbrirArchivo.FileName;
            dgv.Columns.Clear();

            //declaramos las variables que necesitamos para poder abrir un archivo excel
            //_Application exlApp;
            men.Text = "CARGANDO CALIFICACIONES, ESPERE UN MOMENTO...............";
            dgv.Columns.Clear();
            Microsoft.Office.Interop.Excel._Application AppExcel = new Microsoft.Office.Interop.Excel.Application();

             Microsoft.Office.Interop.Excel._Workbook workbook= AppExcel.Workbooks.Open(archivo);
             Microsoft.Office.Interop.Excel._Worksheet Hoja = workbook.Sheets[unidad];
           
           
            
           

           
        
           
        dgv.Columns.Add("Matricula", "Matricula");
        dgv.Columns.Add("Alumno", "Alumno");
        dgv.Columns.Add("Calificacion", "Calificacion");
        
        dgv.Columns.Add("Desempeno", "Desempeño");
        dgv.Columns.Add("Faltas", "Faltas");
        dgv.Columns["Alumno"].Width = 250;
        dgv.RowHeadersVisible = false;

        
        int numFilas = -1;
        for( int i=14;i<47;i++)
        {
            
            numFilas++;
            matricula=Convert.ToString(Hoja.Range["B" + i].Value);

            if (matricula != "")
            {
                alumno = Hoja.Range["C" + i].Value;
                faltas = Convert.ToString(Hoja.Range["AC" + i].Value);
                calif = Math.Round(Hoja.Range["AL" + i].Value, 1);
                desempeno = Convert.ToString(Hoja.Range["AM" + i].Value);

                dgv.Rows.Add(matricula,alumno, calif,desempeno,faltas);
                if (calif < 7)
                    
                    dgv.Rows[numFilas].Cells[2].Style.ForeColor = System.Drawing.Color.Red;
            }
            else
                i = 47;
            

        }

        men.Text = "PROCESO FINALIZADO";

        //Evita el mensaje de DESEA GUARDAR CAMBIOS
        AppExcel.DisplayAlerts = false;
        //AppExcel.Workbooks(1).Saved = True
        //AppExcel.Workbooks.Close()
        //AppExcel.DisplayAlerts = True

        //'CIERRA EXCEL DE LA VENTANA DE PROCESOS
        AppExcel.Quit();
            AppExcel = null;
            
        


            
        }
    }
}
