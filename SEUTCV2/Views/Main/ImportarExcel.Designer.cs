namespace SEUTCV2.Views
{
    partial class ImportarExcel
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
            this.dgvCalif = new System.Windows.Forms.DataGridView();
            this.CmbCarreras = new System.Windows.Forms.ComboBox();
            this.CmbGrupos = new System.Windows.Forms.ComboBox();
            this.gpbUnidad = new System.Windows.Forms.GroupBox();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnLocaliza = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtEntregado = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.opfCalif = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaPlan = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtPeriodo = new System.Windows.Forms.TextBox();
            this.dtpFechaSubida = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtActa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbUnidades = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbAsignaturas = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSubir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalif)).BeginInit();
            this.gpbUnidad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCalif
            // 
            this.dgvCalif.AllowUserToAddRows = false;
            this.dgvCalif.AllowUserToDeleteRows = false;
            this.dgvCalif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalif.Location = new System.Drawing.Point(12, 307);
            this.dgvCalif.Name = "dgvCalif";
            this.dgvCalif.ReadOnly = true;
            this.dgvCalif.Size = new System.Drawing.Size(712, 272);
            this.dgvCalif.TabIndex = 2;
            // 
            // CmbCarreras
            // 
            this.CmbCarreras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCarreras.FormattingEnabled = true;
            this.CmbCarreras.Location = new System.Drawing.Point(73, 29);
            this.CmbCarreras.Name = "CmbCarreras";
            this.CmbCarreras.Size = new System.Drawing.Size(298, 21);
            this.CmbCarreras.TabIndex = 9;
            this.CmbCarreras.SelectedValueChanged += new System.EventHandler(this.CmbCarreras_SelectedValueChanged);
            // 
            // CmbGrupos
            // 
            this.CmbGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGrupos.FormattingEnabled = true;
            this.CmbGrupos.Location = new System.Drawing.Point(467, 29);
            this.CmbGrupos.Name = "CmbGrupos";
            this.CmbGrupos.Size = new System.Drawing.Size(159, 21);
            this.CmbGrupos.TabIndex = 8;
            this.CmbGrupos.SelectedValueChanged += new System.EventHandler(this.CmbGrupos_SelectedValueChanged);
            // 
            // gpbUnidad
            // 
            this.gpbUnidad.Controls.Add(this.txtArchivo);
            this.gpbUnidad.Controls.Add(this.btnLocaliza);
            this.gpbUnidad.Controls.Add(this.label6);
            this.gpbUnidad.Controls.Add(this.btnAbrir);
            this.gpbUnidad.Controls.Add(this.txtEntregado);
            this.gpbUnidad.Controls.Add(this.txtUnidad);
            this.gpbUnidad.Controls.Add(this.label3);
            this.gpbUnidad.Controls.Add(this.txtPor);
            this.gpbUnidad.Controls.Add(this.label2);
            this.gpbUnidad.Location = new System.Drawing.Point(12, 189);
            this.gpbUnidad.Name = "gpbUnidad";
            this.gpbUnidad.Size = new System.Drawing.Size(712, 93);
            this.gpbUnidad.TabIndex = 13;
            this.gpbUnidad.TabStop = false;
            this.gpbUnidad.Text = "Datos académicos";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(137, 19);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(551, 20);
            this.txtArchivo.TabIndex = 16;
            // 
            // btnLocaliza
            // 
            this.btnLocaliza.Location = new System.Drawing.Point(24, 19);
            this.btnLocaliza.Name = "btnLocaliza";
            this.btnLocaliza.Size = new System.Drawing.Size(99, 23);
            this.btnLocaliza.TabIndex = 15;
            this.btnLocaliza.Text = "Localizar . . . ";
            this.btnLocaliza.UseVisualStyleBackColor = true;
            this.btnLocaliza.Click += new System.EventHandler(this.btnLocaliza_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Entregada";
            this.label6.Visible = false;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(24, 48);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(161, 25);
            this.btnAbrir.TabIndex = 10;
            this.btnAbrir.Text = "Importar";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click_1);
            // 
            // txtEntregado
            // 
            this.txtEntregado.Location = new System.Drawing.Point(648, 47);
            this.txtEntregado.Name = "txtEntregado";
            this.txtEntregado.Size = new System.Drawing.Size(40, 20);
            this.txtEntregado.TabIndex = 9;
            this.txtEntregado.Visible = false;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(324, 50);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(97, 20);
            this.txtUnidad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de unidad";
            // 
            // txtPor
            // 
            this.txtPor.Location = new System.Drawing.Point(500, 48);
            this.txtPor.Name = "txtPor";
            this.txtPor.Size = new System.Drawing.Size(79, 20);
            this.txtPor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Porcentaje";
            // 
            // opfCalif
            // 
            this.opfCalif.Title = "Importar calificaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaPlan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtPeriodo);
            this.groupBox1.Controls.Add(this.dtpFechaSubida);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpFechaEntrega);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtActa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 71);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del acta";
            // 
            // dtpFechaPlan
            // 
            this.dtpFechaPlan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPlan.Location = new System.Drawing.Point(280, 42);
            this.dtpFechaPlan.Name = "dtpFechaPlan";
            this.dtpFechaPlan.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaPlan.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Periodo";
            // 
            // TxtPeriodo
            // 
            this.TxtPeriodo.Location = new System.Drawing.Point(6, 42);
            this.TxtPeriodo.Name = "TxtPeriodo";
            this.TxtPeriodo.Size = new System.Drawing.Size(109, 20);
            this.TxtPeriodo.TabIndex = 12;
            // 
            // dtpFechaSubida
            // 
            this.dtpFechaSubida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSubida.Location = new System.Drawing.Point(567, 42);
            this.dtpFechaSubida.Name = "dtpFechaSubida";
            this.dtpFechaSubida.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaSubida.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(564, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha de subida";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(422, 42);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaEntrega.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de entrega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha planificada";
            // 
            // txtActa
            // 
            this.txtActa.Enabled = false;
            this.txtActa.Location = new System.Drawing.Point(137, 42);
            this.txtActa.Name = "txtActa";
            this.txtActa.Size = new System.Drawing.Size(125, 20);
            this.txtActa.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Clave del acta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbUnidades);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbAsignaturas);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CmbCarreras);
            this.groupBox2.Controls.Add(this.CmbGrupos);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 94);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parámetros de importación";
            // 
            // cmbUnidades
            // 
            this.cmbUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidades.FormattingEnabled = true;
            this.cmbUnidades.Location = new System.Drawing.Point(467, 62);
            this.cmbUnidades.Name = "cmbUnidades";
            this.cmbUnidades.Size = new System.Drawing.Size(159, 21);
            this.cmbUnidades.TabIndex = 15;
            this.cmbUnidades.SelectionChangeCommitted += new System.EventHandler(this.cmbUnidades_SelectionChangeCommitted);
            this.cmbUnidades.SelectedValueChanged += new System.EventHandler(this.cmbUnidades_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(385, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Unidad";
            // 
            // cmbAsignaturas
            // 
            this.cmbAsignaturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsignaturas.FormattingEnabled = true;
            this.cmbAsignaturas.Location = new System.Drawing.Point(73, 54);
            this.cmbAsignaturas.Name = "cmbAsignaturas";
            this.cmbAsignaturas.Size = new System.Drawing.Size(298, 21);
            this.cmbAsignaturas.TabIndex = 13;
            this.cmbAsignaturas.SelectedValueChanged += new System.EventHandler(this.cmbAsignaturas_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Asignatura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(385, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Grupo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Carrera";
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(12, 585);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(99, 25);
            this.btnSubir.TabIndex = 18;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 25);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 613);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(747, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            // 
            // ImportarExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 635);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbUnidad);
            this.Controls.Add(this.dgvCalif);
            this.Name = "ImportarExcel";
            this.Text = "ImportarExcel";
            this.Load += new System.EventHandler(this.ImportarExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalif)).EndInit();
            this.gpbUnidad.ResumeLayout(false);
            this.gpbUnidad.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvCalif;
        private System.Windows.Forms.ComboBox CmbCarreras;
        private System.Windows.Forms.ComboBox CmbGrupos;
        private System.Windows.Forms.GroupBox gpbUnidad;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtEntregado;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog opfCalif;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button btnLocaliza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtPeriodo;
        private System.Windows.Forms.DateTimePicker dtpFechaSubida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtActa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbUnidades;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbAsignaturas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.DateTimePicker dtpFechaPlan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label1;
    }
}