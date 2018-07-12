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
using AccesoADatos;
using SEUTCV2.Models;

namespace SEUTCV2.Views.Grupos
{
    public partial class FrmProfesoresPorGrupo : Form
    {
        GrupoController CGrup = new GrupoController();
        ProfesorController Cprofe = new ProfesorController();
        CarreraController Carrera = new CarreraController();
        Ponderaciones oPond = new Ponderaciones();
       

        public FrmProfesoresPorGrupo()
        {
            InitializeComponent();
        }

        private void FrmProfesoresPorGrupo_Load(object sender, EventArgs e)
        {
            //Obtengo los grupos disponibles del periodo
            Carrera.GetCarreras(CmbCarreras);
            CmbCarreras.SelectedIndex = 0;

            CGrup.GetGrupos(CmbGrupos,CmbCarreras.SelectedValue.ToString());
            //CmbGrupos.SelectedIndex = 0;

            Cprofe.GetProfesores(CmbTutor);


            
            
            TxtPeriodo.Text = ModelPeriodo.periodo;

            if (FrameBD.rol == "Tutor Académico")
            {
                CmbCarreras.SelectedValue = ModelGrupo.idcarrera;

                CmbCarreras.Enabled = false;
                CGrup.GetGrupos(CmbGrupos, CmbCarreras.SelectedValue.ToString());
                CmbGrupos.SelectedValue = ModelGrupo.clavegrupo;
                CmbGrupos.Enabled = false;
                CmbTutor.SelectedValue = FrameBD.clavetutor;
                LlenaGrupos();

                

            }
            else
            { 

            }
            

           SumarPonderacion();


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
            cmbdgv.Width = 300;

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

        }

        private void CmbCarreras_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                
                //LlenaGrupos();
                dataGridView1.Columns.Clear();
                CGrup.GetGrupos(CmbGrupos, Convert.ToString(CmbCarreras.SelectedValue));
                CmbGrupos.SelectedIndex = 0;
                
            }
            catch { }
            
        }

        void Llenagrid() 
        {
            //dataGridView1.Columns.Clear();
            
            //listarasigs();
        }

       
        private void CmbGrupos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenaGrupos();
            
            CGrup.GetMateriasYProfes(CmbGrupos, dataGridView1);
            //CmbTutor.SelectedValue = ModelGrupo.tutor;
            //LlenaGrupos();
            //listarasigs();
        }

        private void CmbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listarasigs();
        }


        // Metodo que obtiene todos los grupos del periodo actual 
        private void LlenaGrupos() 
        {

            dataGridView1.Columns.Clear();
            
            //CGrup.GetGrupos(CmbGrupos, Convert.ToString(CmbCarreras.SelectedValue));
            if (CmbGrupos.SelectedValue != null)
            CmbTutor.SelectedValue= CGrup.ObtenerTutor(CmbGrupos.SelectedValue.ToString());
            
            listarasigs();
            //CmbGrupos.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lblAsignatura.Text = dataGridView1["Asignatura", dataGridView1.CurrentCellAddress.Y].Value.ToString();
            //lblAsignatura.Tag = dataGridView1["Clave", dataGridView1.CurrentCellAddress.Y].Value.ToString();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 1 && dataGridView1.ColumnCount >1)
            {
                lblAsignatura.Text = dataGridView1[1, dataGridView1.CurrentCellAddress.Y].Value.ToString();
                lblAsignatura.Tag = dataGridView1["Clave", dataGridView1.CurrentCellAddress.Y].Value.ToString();
                oPond.GetPonderaciones(TxtPeriodo.Text, lblAsignatura.Tag.ToString(), dgvPondera);
                SumarPonderacion();
            }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region "Ponderacion";

        // ese metodo creaba unidades en forma dinamica
        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //ValidarPonderacion();
            //if (Convert.ToDouble(txtTotalPondera.Text) <= 100)
            //{
            //    dgvPondera["unidad", dgvPondera.CurrentCellAddress.Y].Value = dgvPondera.RowCount - 1;
            //    dgvPondera["tipo", dgvPondera.CurrentCellAddress.Y].Value = "C";

            //}

        }
        void InicioPonderacion() 
        {
            oPond.InicioPonderacion(dgvPondera);

        }

        void SumarPonderacion() 
        {
            double sum = 0;
            for (int i=0;i<dgvPondera.RowCount;i++)
            {
                sum = sum + Convert.ToDouble(dgvPondera[1, i].Value.ToString());

            }
            txtTotalPondera.Text = sum.ToString("0.0");

        }

        #endregion

        // Recalcula la suma cada que cambia el valor de la ponderacion
        private void dgvPondera_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
                SumarPonderacion();
        }

        private void dgvPondera_KeyPress(object sender, KeyPressEventArgs e)
        {
           // if (e.KeyChar == (char)Keys.Delete)
            //{
              //  MessageBox.Show("liminando");
            //}

        }

        private void dgvPondera_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //MessageBox.Show("liminando");
                dgvPondera.Rows.RemoveAt(dgvPondera.CurrentCellAddress.Y); 
            }

            if (e.KeyCode == Keys.Insert)
            {
               if (dgvPondera.DataSource ==null)
                    dgvPondera.Rows.Add("", "0", "C"); 
            }
            IndexarGrid();
        }

        void IndexarGrid()
        {
            if (dgvPondera.RowCount > 1)
            {
                for (int i = 0; i < dgvPondera.RowCount; i++)
                {
                    dgvPondera[0, i].Value = Convert.ToString(i + 1);
                }
            }
        }

        private void btnPonderacion_Click(object sender, EventArgs e)
        {
            
            oPond.idperiodo = TxtPeriodo.Text;
            oPond.idasignatura = lblAsignatura.Tag.ToString();
            oPond.Store(TxtPeriodo.Text, lblAsignatura.Tag.ToString(), dgvPondera);     

        }

        private void btnPonderar_Click(object sender, EventArgs e)
        {
            //listarasigs();
        }

       

        public void listarasigs() 
        {
            CGrup.GetMateriasYProfes(CmbGrupos, dataGridView1);
            //CmbTutor.SelectedValue = 
        }

        private void CmbGrupos_SelectedValueChanged(object sender, EventArgs e)
        {
            LlenaGrupos();

            CGrup.GetMateriasYProfes(CmbGrupos, dataGridView1);
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                string[] mat = new string[dataGridView1.RowCount];
                string[] prof = new string[dataGridView1.RowCount];
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    mat[i] = dataGridView1[0, i].Value.ToString();
                    prof[i] = dataGridView1[2, i].Value.ToString();
                }

                // Guardamos los profesores asignados a cada asignatura de la lista
                CGrup.GuardarProfesMat(mat, prof, ModelPeriodo.periodo, CmbGrupos.SelectedValue.ToString());

                // Guardamos al tutor seleccionado
                CGrup.AsignarTutor(CmbTutor.SelectedValue.ToString(), CmbGrupos.SelectedValue.ToString());
            }
        }

       

       

       

        
        

      

        
    }
}
