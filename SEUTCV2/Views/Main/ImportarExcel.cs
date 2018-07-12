using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEUTCV2.Frames;
using SEUTCV2.Controllers;
 
namespace SEUTCV2.Views
{
    public partial class ImportarExcel : Form
    {
        ProfesorController Cprofe = new ProfesorController();
        CarreraController Carrera = new CarreraController();
        GrupoController oGrupo = new GrupoController();
        Ponderaciones oPonder = new Ponderaciones();
        
        public ImportarExcel()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            ExcelImport oExcel = new ExcelImport();
            oExcel.Abrir(@"c:\criterios","UA1",dgvCalif,label1);


            
        }

        private void ImportarExcel_Load(object sender, EventArgs e)
        {
            
            CmbCarreras.DataSource = Carrera.GetCarreras();
            CmbCarreras.ValueMember = "idcarrera";
            CmbCarreras.DisplayMember = "Nombre";
            TxtPeriodo.Text = SEUTCV2.Properties.Settings.Default.periodo;
        }

        private void CmbCarreras_SelectionChangeCommitted(object sender, EventArgs e)
        {
            oGrupo.GetGrupos(CmbGrupos, Convert.ToString(CmbCarreras.SelectedValue));
            //CmbGrupos.SelectedIndex = 0;


        }

        private void CmbGrupos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            oGrupo.ObtenerMaterias(TxtPeriodo.Text, CmbGrupos.SelectedValue.ToString(), cmbAsignaturas);
           // FoliarActa();
            cmbAsignaturas.SelectedIndex = 0;


        }

        private void CmbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void cmbUnidades_SelectionChangeCommitted(object sender, EventArgs e)
        {
           string [] datos= oPonder.GetDatosUnidad(cmbAsignaturas.SelectedValue.ToString(), TxtPeriodo.Text, cmbUnidades.SelectedValue.ToString());
           txtPor.Text = datos[0];
           txtUnidad.Text = datos[1];
           //txtFechaPlan.Text = datos[2];
           txtEntregado.Text = datos[4];
           

          
        }

        private void cmbUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click_1(object sender, EventArgs e)
        {
            if (txtArchivo.Text != "")
            {
                ExcelImport oExcel = new ExcelImport();
                string uni = cmbUnidades.SelectedValue.ToString();
                switch (uni)
                {
                    case "1":
                        uni = "UA1";
                        break;
                    case "2":
                        uni = "UA2";
                        break;
                    case "3":
                        uni = "UA3";
                        break;
                    case "4":
                        uni = "UA4";
                        break;
                    case "5":
                        uni = "UA5";
                        break;
                    case "6":
                        uni = "UA6";
                        break;




                }

                FoliarActa();

                oExcel.Abrir(txtArchivo.Text, uni, dgvCalif, label1);
            }
            else
                MessageBox.Show("No se ha especficado archivo a cargar", "Atención");

        }

        private void btnLocaliza_Click(object sender, EventArgs e)
        {
            if (opfCalif.ShowDialog()==DialogResult.OK)
            txtArchivo.Text = opfCalif.FileName;

        }

        private void cmbAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAsignaturas_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            oPonder.getUnidades(cmbAsignaturas.SelectedValue.ToString(), TxtPeriodo.Text, cmbUnidades);
            cmbUnidades.SelectedIndex = 0;
            

        }
        private void cmbAsignaturas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            oPonder.getUnidades(cmbAsignaturas.SelectedValue.ToString(), TxtPeriodo.Text, cmbUnidades);
           

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Está seguro de importar las calificaciones","Precaución",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
            ActasEntregaController oActa = new ActasEntregaController();
            oActa.acta = txtActa.Text;
            oActa.clavePeriodo = TxtPeriodo.Text;
            oActa.claveAsig = cmbAsignaturas.SelectedValue.ToString();
            oActa.fecha_entrega = dtpFechaEntrega.Value.ToString("yyyy-MM-dd");
            oActa.fecha_planeada = dtpFechaPlan.Value.ToString("yyyy-MM-dd");
            oActa.fecha_subida = dtpFechaSubida.Value.ToString("yyyy-MM-dd");
            oActa.ponderacion = Convert.ToDouble(txtPor.Text);
            oActa.tipo_unidad = txtUnidad.Text;
            oActa.unidad = Convert.ToUInt32(cmbUnidades.SelectedValue.ToString());
            oActa.claveGrupo = CmbGrupos.SelectedValue.ToString();
          
            
            oActa.Store();

            oActa.Store_DetalleActas(dgvCalif);
            dgvCalif.Columns.Clear();
            txtArchivo.Clear();
            cmbAsignaturas.SelectedIndex = -1;
            cmbUnidades.SelectedIndex = -1;


            }


        }

        public void FoliarActa() 
        {

           
            string grup = CmbGrupos.SelectedValue.ToString();
            string asig = cmbAsignaturas.SelectedValue.ToString();
            string uni = cmbUnidades.SelectedValue.ToString();
            //string folio = DateTime.Now.TimeOfDay.ToString() ;//grup + "-"  + asig + "-" + uni;
            
            //dt.IsDBNull(i) ? String.Empty : dt.GetString(i);
            //txtActa.Text = folio;

        }

        private void CmbCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ExportExcel oExcel = new ExportExcel();
           // oExcel.ExportarExcel();
        }

      
        


    }
}
