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
using SEUTCV2.Views.Main;
using SEUTCV2.Models;

namespace SEUTCV2.Views.Alumnos
{
    public partial class frmLogin : Form
    {
        AccesoController oAcceso = new AccesoController();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string[] datos =oAcceso.validar(txtUser.Text, txtPass.Text);

            if (datos[0] =="true")
            {
                FrameBD.rol = datos[3];
                FrameBD.usuarioAcede= datos[2];
                ModelPeriodo.getDatos();

                if (FrameBD.rol == "Tutor Académico")
                {
                    ModelGrupo.getDatosGrupoTutorado();
                }
                FrmPrincipal oPrincipal = new FrmPrincipal();
                this.Hide();
                oPrincipal.ShowDialog();
                this.Close();
                
                
            }
            else
                MessageBox.Show("Usuario o contraseña incorrecta");

        }
    }
}
