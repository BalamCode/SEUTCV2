using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEUTCV2.Models; 
using SEUTCV2.Controllers;

namespace SEUTCV2.Views

{
    public partial class FrmGrupos : Form
    {

        
        GrupoController ConGrupo = new GrupoController();
        ModelGrupo MGrupo = new ModelGrupo();
        CarreraController Carrera = new CarreraController();
        //ModelProfesor Profe = new ModelProfesor();
        public FrmGrupos()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        private void FrmGrupos_Load(object sender, EventArgs e)
            
        {
           //IPAddress ip = Dns.GetHostAddresses(Dns.GetHostName()).Where(address => address.AddressFamily == AddressFamily.InterNetwork).First();
            //System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();
            this.Top = 0;
            this.Left = 0;
        
            CmbCarreras.SelectedIndex = -1;
            CmbCarreras.DataSource= Carrera.GetCarreras();
            CmbCarreras.ValueMember="idcarrera";
            CmbCarreras.DisplayMember="Nombre";

            CmbCarreras.SelectedIndex = -1;
            
            CmbCarrera.DataSource = Carrera.GetCarreras();
            CmbCarrera.ValueMember = "idcarrera";
            CmbCarrera.DisplayMember = "Nombre";

            CmbCarreras.SelectedIndex = -1;
                
            TxtPeriodo.Text = SEUTCV2.Properties.Settings.Default.periodo;
            FiltroGrupos();






        }

        private void FiltroGrupos() 

        {
            
            if (CmbCarreras.SelectedIndex ==-1)

                DgvCarreras.DataSource = ConGrupo.GetGrupos();
            else
                DgvCarreras.DataSource = ConGrupo.GetGrupos(Convert.ToString (CmbCarreras.SelectedValue));

            DgvCarreras.DataMember = "datos";
            DgvCarreras.Columns["Clave"].Width = 100;
            DgvCarreras.Columns["Grado"].Width = 50;
            DgvCarreras.Columns["Grupo"].Width = 50;
            DgvCarreras.Columns["Creado"].Width = 100;
            LblTotal.Text= TotalGrupos();

        }

        private void CmbCarreras_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DgvCarreras.DataSource = ConGrupo.GetGrupos(Convert.ToString(CmbCarreras.SelectedValue));
            LblTotal.Text = TotalGrupos();
        }

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            CmbCarreras.SelectedIndex = -1;
            DgvCarreras.DataSource = ConGrupo.GetGrupos();
            LblTotal.Text = TotalGrupos();
        }


        public string  GenClave()
        {
            string auxclave = "";
            auxclave = CmbCarrera.SelectedValue  + "-" + CmbGrado.Text + CmbGrup.Text;
            return auxclave;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CmbCarrera_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TxtClave.Text =  GenClave();
            //LblTotal.Text = TotalGrupos();
            
        }

        private void CmbGrado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TxtClave.Text = GenClave();
        }

        private void CmbGrado_DropDownStyleChanged(object sender, EventArgs e)
        {

        }

        private void TxtGrupo_TextChanged(object sender, EventArgs e)
        {
            //TxtClave.Text = GenClave();
        }

        private void CmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbGrup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TxtClave.Text = GenClave();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            BtnGuardar.Enabled = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //   Profe.cedula="BABG";
            //   Profe.nombre = "GILBERTO";
            //   Profe.apellidop="BALAM";
            //   Profe.apellidom="BALAM";
               
            //  Controllers.ProfesorController Profesor = new Controllers.ProfesorController();

            //Profesor.Store(Profe);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (TxtClave.Text != "")
                {
                     
                    //MGrupo.periodo = SEUTCV2.Properties.Settings.Default.periodo;
                    //MGrupo.idcarrera = Convert.ToString(CmbCarrera.SelectedValue);
                    //MGrupo.grado = Convert.ToUInt32(CmbGrado.SelectedItem);
                    //MGrupo.grupo = Convert.ToString(CmbGrup.SelectedItem);
                    //MGrupo.cupo = 0;
                    //MGrupo.fechacreacion = DateTime.Now.Date.ToString("yyyy-MM-dd");

                    ConGrupo.StoreGrupos(TxtClave.Text, ModelPeriodo.periodo, Convert.ToString(CmbCarrera.SelectedValue), Convert.ToString(CmbGrado.SelectedItem), Convert.ToString(CmbGrup.SelectedItem),"0","2015",DateTime.Now.Date.ToString("yyyy-MM-dd"));
                    this.FiltroGrupos();
                    tabControl1.SelectedIndex = 0;
                    BtnGuardar.Enabled = false;
                }
            }
            catch { }
        }


        private string TotalGrupos()
        {
            string tot = Convert.ToString(DgvCarreras.RowCount);
            return tot;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ConGrupo.Destroy(Convert.ToString(DgvCarreras[0, DgvCarreras.CurrentCellAddress.Y].Value));
                FiltroGrupos();
            }
        }

    }
}
