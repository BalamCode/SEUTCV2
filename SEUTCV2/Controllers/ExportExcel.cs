using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;
using System.IO;
using AccesoADatos;

namespace SEUTCV2.Controllers
{

    class ExportExcel
    {
        string archivo = @"C:\justificaciones.xlsx";
        string nomhoja = "Hoja1";
        //string[] datos;
        public void ExportarExcel(string periodo, string carrera,string grupo,string matricula,string alumno, string fecha_sol,string fecha_falta,string modulos) 
        {
            Microsoft.Office.Interop.Excel._Application AppExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = AppExcel.Workbooks.Open(archivo);
            Microsoft.Office.Interop.Excel._Worksheet Hoja = workbook.Sheets[nomhoja];

            AppExcel.Visible = false;

            string anio = periodo.Substring(0, 4);
            string per = periodo.Substring(4,1);
            string nomcuatri = "";

            switch (per)
            {
                case "A": 
                    nomcuatri = "ENERO-ABRIL DE " + anio;
                    break;
                case "B":
                    nomcuatri = "MAYO-AGOSTO DE " + anio;
                    break;
                case "C":
                    nomcuatri = "SEPTIEMBRE-DICIEMBRE DE " + anio;
                    break;




            }

            switch (carrera)
            { 
                case "TTS":
                    carrera = "TECNOLOGÍAS DE LA INFORMACIÓN Y COMUNICACIÓN";
                    break;
                case "TMI":
                    carrera = "MANTENIMIENTO AREA INDUSTRIAL";
                    break;
                case "TGA":
                    carrera = "GASTRONOMÍA";
                    break;
                case "TTH":
                    carrera = "TURISMO AREA HOTELERÍA";
                    break;
                case "TAF":
                    carrera = "ADMINISTRACIÓN AREA EVALUACIÓN DE PROYECTOS";
                    break;

 
            }


            Hoja.Range["C5"].Value = nomcuatri;   // Periodo escolar
            Hoja.Range["C6"].Value = alumno;   // Nombre del alumno
            Hoja.Range["C7"].Value = matricula;   // Matricula
            Hoja.Range["C8"].Value = carrera;   // Carrera
            Hoja.Range["C9"].Value = grupo;   // Grupo
            Hoja.Range["D10"].Value = fecha_sol; // Fecha solicitud
            Hoja.Range["D11"].Value = fecha_falta;   // Fecha Falta
            Hoja.Range["G11"].Value = modulos;   // Modulos
            Hoja.Range["A17"].Value = FrameBD.usuarioAcede;   // Fecha Falta
            Hoja.Range["E17"].Value = "MTRO. JOSÉ EDUARDO PUGA SOSA";   // Fecha Falta

            AppExcel.DisplayAlerts = false;
            workbook.ActiveSheet.ExportAsFixedFormat(0, @"D:\sample.pdf");

            AppExcel.Quit();
            AppExcel = null;
            //string pdfPath = Path.Combine(Application.StartupPath, "T12.PDF");

            System.Diagnostics.Process P = new System.Diagnostics.Process();
            P.StartInfo.FileName = @"D:\sample.pdf";
            //P.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            P.Start();
            //Espera el proceso para que lo termine y continuar
            P.WaitForExit();
            //Liberar
            P.Close();
        }
           
    }
}
