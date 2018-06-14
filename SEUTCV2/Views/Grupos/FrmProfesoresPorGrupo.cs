using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEUTCV2.Controllers;

namespace SEUTCV2.Views.Grupos
{
    public partial class FrmProfesoresPorGrupo : Form
    {
        GrupoController CGrup = new GrupoController();
        ProfesorController Cprofe = new ProfesorController();
        CarreraController Carrera = new CarreraController();


        public FrmProfesoresPorGrupo()
        {
            InitializeComponent();
        }

        private void FrmProfesoresPorGrupo_Load(object sender, EventArgs e)
        {
            //Obtengo los grupos disponibles del periodo
            //CGrup.GetGrupos(CmbGrupos);
           
            CmbTutor.DataSource = Cprofe.GetProfesores();
            CmbTutor.ValueMember = "cedula";
            CmbTutor.DisplayMember = "Docente";

            CmbCarreras.DataSource = Carrera.GetCarreras();
            CmbCarreras.ValueMember = "idcarrera";
            CmbCarreras.DisplayMember = "Nombre";

            
            TxtPeriodo.Text = SEUTCV2.Properties.Settings.Default.periodo;
            

            

            //dataGridView1.Columns.Add("Profesor", "Profesor");


        }

        private void jOSÉGILBERTOBALAMBALAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1["Profesor", dataGridView1.CurrentCellAddress.Y].Value = jOSÉGILBERTOBALAMBALAMToolStripMenuItem.Text;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void AddCombo()
        {
            DataGridViewComboBoxColumn cmbdgv = new DataGridViewComboBoxColumn();
            //List<String> itemCodeList = new List<String>();
            //Cprofe.GetProfesores(cmbdgv);
            cmbdgv.DataSource = Cprofe.GetProfesores();
            cmbdgv.ValueMember = "cedula";
            cmbdgv.DisplayMember = "Docente";
            cmbdgv.HeaderText = "Profesores";
            cmbdgv.Name = "Profesores";
            cmbdgv.Width = 200;

            //cmbdgv.Items.Add("Gilberto");
            //cmbdgv.Items.Add("Ivan");
            dataGridView1.Columns.Add(cmbdgv);
            dataGridView1.Columns["Profesores"].DisplayIndex = 3;


            for (int i = 0; i < dataGridView1.RowCount; i++) 
            {
                dataGridView1["Profesores", i].Value = dataGridView1["Cedula", i].Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCombo();
        }

        private void CmbCarreras_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                LlenaGrupos();
            }
            catch { }
            
        }

        private void CmbCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbGrupos_SelectionChangeCommitted(object sender, EventArgs e)
        {

            LlenaGrupos();
        }

        private void listarasigs()
        {
            string auxgrado = Convert.ToString(CmbGrupos.SelectedValue);
            string grado = auxgrado.Substring(4, 1);
            dataGridView1.Columns.Clear();
            CGrup.GetMateriasYProfes(Convert.ToString(CmbCarreras.SelectedValue), grado, dataGridView1);
        }

        private void CmbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listarasigs();
        }

        private void LlenaGrupos() 
        {

            //dataGridView1.Columns.Clear();
            
            CGrup.GetGrupos(CmbGrupos, Convert.ToString(CmbCarreras.SelectedValue));
            listarasigs();
            AddCombo();
            dataGridView1.Columns["Asignatura"].Width = 300;
            dataGridView1.Columns["Cedula"].Visible = false;
        }
    }
}
