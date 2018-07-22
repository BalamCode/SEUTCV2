using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Windows.Forms;

namespace SEUTCV2.Controllers
{
    

    class Ponderaciones
    {
        public string idasignatura { get; set; }
        public string idperiodo { get; set; }
        public int unidad { get; set; }
        public int porcentaje { get; set; }
        public char tipounidad { get; set; }




        public void Store(string id_pondera,string periodo,string materia,DataGridView dgv)
        {
            string sql = "DELETE FROM ponderaciones WHERE idperiodo='" + periodo + "' AND idasignatura='" + materia + "';" ;
            for (int i = 0; i < dgv.RowCount;i++ )
            {
                sql = sql +  string.Format("INSERT INTO ponderaciones(idasignatura,idperiodo,unidad,porcentaje,tipounidad,id_ponderacion)" +
                                     " VALUES('{0}','{1}',{2},{3},'{4}','{5}');", idasignatura, idperiodo, dgv[0, i].Value.ToString(), dgv[1, i].Value.ToString(), dgv["Tipo", i].Value.ToString(),id_pondera);
            }

            FrameBD.SQLIDU(sql); 



        }

        public void getUnidades(string claveAsig,string periodo,string grupo,ComboBox cmb)
        {
            // Obtenemos las unidades que aun no se entregan
            string sql2 = string.Format("SELECT unidad" +
" FROM ponderaciones as p" +
" WHERE idasignatura='{0}' and idperiodo='{1}' And unidad" +
" NOT IN(SELECT unidad" +
" FROM actas_entrega as ac" +
" WHERE clavePeriodo='{1}' and claveAsig='{0}' AND claveGrupo='{2}')", claveAsig, periodo, grupo);

            ////string sql = "SELECT unidad" +
            //             " FROM ponderaciones" +
            //             " WHERE idasignatura='" + claveAsig + "' AND idperiodo='" + periodo  +  "' AND entregado=0";

            cmb.DataSource = FrameBD.SQLCOMBO(sql2);
            cmb.DisplayMember = "unidad";
            cmb.ValueMember = "unidad";

        }


        public string[] GetDatosUnidad (string claveAsig, string periodo,string unidad) 
        {
            string cond= "idasignatura='" + claveAsig + "' AND idperiodo='" + periodo + "' AND unidad=" + unidad;
            string campos="porcentaje,tipounidad,fecha_planificada,fecha_entrega,entregado";
            string[] aux = FrameBD.ObtieneCampos("ponderaciones", cond, campos);

            return aux;
        }

        public void GetPonderaciones(string periodo,string materia,DataGridView dgv) 
        {
            string sql = "SELECT Unidad,porcentaje as Ponderacion,tipounidad as 'TipoAux' FROM ponderaciones" +
                       " WHERE idperiodo='" + periodo + "' AND idasignatura='" + materia + "';";
            dgv.Columns.Clear(); 
            dgv.DataSource = FrameBD.SQLSEL(sql);
            dgv.DataMember = "datos";

            if (dgv.RowCount > 0)
            {
                DataGridViewComboBoxColumn cmbdgv = new DataGridViewComboBoxColumn();
                
                cmbdgv.Items.Add("C");
                cmbdgv.Items.Add("I");
                cmbdgv.HeaderText = "Tipo";
                cmbdgv.Name = "tipo";
                
                cmbdgv.Width = 75;
                dgv.Columns[0].Width = 75;
                dgv.Columns[1].Width = 75;
                dgv.Columns[2].Width = 75;
                dgv.Columns[0].ReadOnly = true;

                dgv.Columns[2].Name = "tipoAux";
                dgv.Columns[2].Visible = false;
                dgv.Columns.Add(cmbdgv);

                for (int i = 0; i < dgv.RowCount; i++)
                {
                    dgv[3, i].Value = dgv[2, i].Value;
                }
            }
            else
            {
                dgv.DataSource = null;

                dgv.Columns.Add("unidad", "Unidad");
                dgv.Columns.Add("ponderacion", "Ponderación");
                DataGridViewComboBoxColumn cmbdgv = new DataGridViewComboBoxColumn();
                cmbdgv.Items.Add("C");
                cmbdgv.Items.Add("I");
                
                dgv.Columns.Add(cmbdgv);
                dgv.Columns[0].Width = 75;
                dgv.Columns[1].Width = 75;
                dgv.Columns[2].Width = 75;
                dgv.Columns[2].HeaderText= "Tipo";

                dgv.Rows.Add("1", "0", "C");
                dgv.Rows.Add("2", "0", "C");
                dgv.Rows.Add("3", "0", "C");
                dgv.Rows.Add("4", "0", "C");
                dgv.Rows.Add("5", "0", "C");
                dgv.Rows.Add("6", "0", "C");
                dgv.Rows.Add("7", "0", "C");

                dgv.Columns["unidad"].Width = 75;
            }
 
                
        }




        public void InicioPonderacion(DataGridView dgvPondera)
        {
            dgvPondera.Columns.Add("unidad", "Unidad");
            dgvPondera.Columns.Add("ponderacion", "Ponderación");
            dgvPondera.Columns.Add("tipo", "Tipo");

            dgvPondera.Rows.Add("1", "0", "C");
            dgvPondera.Rows.Add("2", "0", "C");
            dgvPondera.Rows.Add("3", "0", "C");
            dgvPondera.Rows.Add("4", "0", "C");
            dgvPondera.Rows.Add("5", "0", "C");
            dgvPondera.Rows.Add("6", "0", "C");
            dgvPondera.Rows.Add("7", "0", "C");

            dgvPondera.Columns["unidad"].Width = 75;

        }


    }



   
}
