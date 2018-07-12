using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Herramientas;


namespace SEUTCV2.Views.Alumnos
{
    public partial class PruebaValida : Form
    {
        

        public PruebaValida()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.KeyChar = Validaciones.valida("T", e.KeyChar);
            //e.KeyChar = Validaciones.validaReal(textBox1, e.KeyChar);
            e.KeyChar = Validaciones.validaCorreo(textBox1, e.KeyChar);

            //e.KeyChar = Validaciones.validaReal(textBox1, e.KeyChar);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PruebaValida_Load(object sender, EventArgs e)
        {

        }
    }
}
