using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoADatos;
using SEUTCV2.Models;
using SEUTCV2.Controllers;

namespace SEUTCV2.Views.Alumnos
{
    public partial class frmJustificaciones : Form
    {
        JustificacionesController oJust = new JustificacionesController();
        MotivosController oMotivos = new MotivosController();
        public frmJustificaciones()
        {
            InitializeComponent();
        }

        private void frmJustificaciones_Load(object sender, EventArgs e)
        {

            oMotivos.getMotivos(cmbMotivos);
            dgvFechas.Columns[0].Width = 200;

            
            
        }

        public void SetDatos(string grupo,string id_carrera,string carrera,string mat,string alumno) 
        {
            txtPeriodo.Text = ModelPeriodo.periodo;
            txtPeriodo.Enabled = false;

            txtCarrera.Text = carrera;
            txtCarrera.Tag = id_carrera;
            txtCarrera.Enabled = false;

            txtMatricula.Text = mat;
            txtMatricula.Enabled = false;

            txtAlumno.Text = alumno;
            txtAlumno.Enabled = false;

            txtGrupo.Text = grupo;
            txtGrupo.Enabled = false;

            txtTutor.Text = FrameBD.usuarioAcede;
            txtDias.Enabled = false;

            txtTutor.Enabled = false;
            txtFolio.Text = txtPeriodo.Text + "-" + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second;
            txtFolio.Enabled = false;

            
        }

        private void cmbAddFecha_Click(object sender, EventArgs e)
        {
            dgvFechas.Rows.Add(dtpJustificadas.Value.ToString("yyyy-MM-dd"));
            txtDias.Text = dgvFechas.RowCount.ToString();
        }

        private void cmbGuardar_Click(object sender, EventArgs e)
        {
            oJust.folio = txtFolio.Text;
            oJust.periodo = txtPeriodo.Text;
            oJust.grupo = txtGrupo.Text;
            oJust.id_carrera = txtCarrera.Tag.ToString();
            oJust.matricula = txtMatricula.Text;
            oJust.id_motivo = cmbMotivos.SelectedValue.ToString();
            oJust.fecha_solicitud = dtpSolicitud.Value.ToString("yyyy-MM-dd");
            oJust.num_dias = Convert.ToInt32(txtDias.Text);
            oJust.modulos = cmbModulos.Text;
            oJust.id_tutor = FrameBD.clavetutor;
            oJust.comentario = txtComentario.Text;
            oJust.alumno = txtAlumno.Text;

            string[] dias = new string[oJust.num_dias];

            for (int i = 0; i < oJust.num_dias;i++ )
            {
                dias[i] = dgvFechas[0, i].Value.ToString();
            }
            oJust.fechas_falta = dias;


            oJust.Store();
            this.Focus();
            this.Close();
            


        }
    }
}
