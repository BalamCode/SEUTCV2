namespace SEUTCV2.Views.Grupos
{
    partial class FrmProfesoresPorGrupo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jOSÉGILBERTOBALAMBALAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSCIVANVEGAUCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.CmbGrupos = new System.Windows.Forms.ComboBox();
            this.CmbCarreras = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPeriodo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbTutor = new System.Windows.Forms.ComboBox();
            this.dgvPondera = new System.Windows.Forms.DataGridView();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPondera = new System.Windows.Forms.TextBox();
            this.btnPonderacion = new System.Windows.Forms.Button();
            this.btnPonderar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPondera)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(31, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(781, 213);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jOSÉGILBERTOBALAMBALAMToolStripMenuItem,
            this.iSCIVANVEGAUCToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(240, 48);
            // 
            // jOSÉGILBERTOBALAMBALAMToolStripMenuItem
            // 
            this.jOSÉGILBERTOBALAMBALAMToolStripMenuItem.Name = "jOSÉGILBERTOBALAMBALAMToolStripMenuItem";
            this.jOSÉGILBERTOBALAMBALAMToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.jOSÉGILBERTOBALAMBALAMToolStripMenuItem.Text = "JOSÉ GILBERTO BALAM BALAM";
            // 
            // iSCIVANVEGAUCToolStripMenuItem
            // 
            this.iSCIVANVEGAUCToolStripMenuItem.Name = "iSCIVANVEGAUCToolStripMenuItem";
            this.iSCIVANVEGAUCToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.iSCIVANVEGAUCToolStripMenuItem.Text = "I.S.C IVAN VEGA UC";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(31, 325);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(178, 36);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar configuración";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(590, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(36, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Grupo";
            // 
            // CmbGrupos
            // 
            this.CmbGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGrupos.FormattingEnabled = true;
            this.CmbGrupos.Location = new System.Drawing.Point(643, 31);
            this.CmbGrupos.Name = "CmbGrupos";
            this.CmbGrupos.Size = new System.Drawing.Size(159, 21);
            this.CmbGrupos.TabIndex = 3;
            this.CmbGrupos.SelectionChangeCommitted += new System.EventHandler(this.CmbGrupos_SelectionChangeCommitted);
            this.CmbGrupos.SelectedValueChanged += new System.EventHandler(this.CmbGrupos_SelectedValueChanged);
            // 
            // CmbCarreras
            // 
            this.CmbCarreras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCarreras.FormattingEnabled = true;
            this.CmbCarreras.Location = new System.Drawing.Point(299, 31);
            this.CmbCarreras.Name = "CmbCarreras";
            this.CmbCarreras.Size = new System.Drawing.Size(285, 21);
            this.CmbCarreras.TabIndex = 4;
            this.CmbCarreras.SelectionChangeCommitted += new System.EventHandler(this.CmbCarreras_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Carreras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Periodo";
            // 
            // TxtPeriodo
            // 
            this.TxtPeriodo.Enabled = false;
            this.TxtPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPeriodo.Location = new System.Drawing.Point(77, 32);
            this.TxtPeriodo.Name = "TxtPeriodo";
            this.TxtPeriodo.Size = new System.Drawing.Size(149, 20);
            this.TxtPeriodo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tutor";
            // 
            // CmbTutor
            // 
            this.CmbTutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTutor.FormattingEnabled = true;
            this.CmbTutor.Location = new System.Drawing.Point(77, 65);
            this.CmbTutor.Name = "CmbTutor";
            this.CmbTutor.Size = new System.Drawing.Size(507, 21);
            this.CmbTutor.TabIndex = 9;
            // 
            // dgvPondera
            // 
            this.dgvPondera.AllowUserToAddRows = false;
            this.dgvPondera.AllowUserToDeleteRows = false;
            this.dgvPondera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPondera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unidad,
            this.porcentaje,
            this.tipo});
            this.dgvPondera.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPondera.Location = new System.Drawing.Point(847, 72);
            this.dgvPondera.Name = "dgvPondera";
            this.dgvPondera.Size = new System.Drawing.Size(344, 213);
            this.dgvPondera.StandardTab = true;
            this.dgvPondera.TabIndex = 10;
            this.dgvPondera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dgvPondera.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPondera_CellValueChanged);
            this.dgvPondera.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView2_RowsAdded);
            this.dgvPondera.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPondera_KeyDown);
            this.dgvPondera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvPondera_KeyPress);
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            // 
            // porcentaje
            // 
            this.porcentaje.HeaderText = "Porcentaje";
            this.porcentaje.Name = "porcentaje";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Items.AddRange(new object[] {
            "C",
            "I"});
            this.tipo.Name = "tipo";
            this.tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.BackColor = System.Drawing.Color.White;
            this.lblAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignatura.ForeColor = System.Drawing.Color.Gold;
            this.lblAsignatura.Location = new System.Drawing.Point(851, 52);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(0, 17);
            this.lblAsignatura.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(850, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Puntaje Total: ";
            // 
            // txtTotalPondera
            // 
            this.txtTotalPondera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPondera.ForeColor = System.Drawing.Color.Navy;
            this.txtTotalPondera.Location = new System.Drawing.Point(981, 291);
            this.txtTotalPondera.Name = "txtTotalPondera";
            this.txtTotalPondera.Size = new System.Drawing.Size(210, 26);
            this.txtTotalPondera.TabIndex = 13;
            // 
            // btnPonderacion
            // 
            this.btnPonderacion.Location = new System.Drawing.Point(847, 326);
            this.btnPonderacion.Name = "btnPonderacion";
            this.btnPonderacion.Size = new System.Drawing.Size(178, 36);
            this.btnPonderacion.TabIndex = 14;
            this.btnPonderacion.Text = "Guardar ponderacion";
            this.btnPonderacion.UseVisualStyleBackColor = true;
            this.btnPonderacion.Click += new System.EventHandler(this.btnPonderacion_Click);
            // 
            // btnPonderar
            // 
            this.btnPonderar.Location = new System.Drawing.Point(235, 325);
            this.btnPonderar.Name = "btnPonderar";
            this.btnPonderar.Size = new System.Drawing.Size(178, 36);
            this.btnPonderar.TabIndex = 15;
            this.btnPonderar.Text = "Ponderar";
            this.btnPonderar.UseVisualStyleBackColor = true;
            this.btnPonderar.Click += new System.EventHandler(this.btnPonderar_Click);
            // 
            // FrmProfesoresPorGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 374);
            this.Controls.Add(this.btnPonderar);
            this.Controls.Add(this.btnPonderacion);
            this.Controls.Add(this.txtTotalPondera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.dgvPondera);
            this.Controls.Add(this.CmbTutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPeriodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbCarreras);
            this.Controls.Add(this.CmbGrupos);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmProfesoresPorGrupo";
            this.Text = "Planificacion académica";
            this.Load += new System.EventHandler(this.FrmProfesoresPorGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPondera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jOSÉGILBERTOBALAMBALAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSCIVANVEGAUCToolStripMenuItem;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox CmbGrupos;
        private System.Windows.Forms.ComboBox CmbCarreras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPeriodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbTutor;
        private System.Windows.Forms.DataGridView dgvPondera;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPondera;
        private System.Windows.Forms.Button btnPonderacion;
        private System.Windows.Forms.Button btnPonderar;
    }
}