namespace SEUTCV2.Views.Alumnos
{
    partial class frmJustificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJustificaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTutor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMotivos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpSolicitud = new System.Windows.Forms.DateTimePicker();
            this.cmbModulos = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvFechas = new System.Windows.Forms.DataGridView();
            this.Fechas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpJustificadas = new System.Windows.Forms.DateTimePicker();
            this.cmbAddFecha = new System.Windows.Forms.Button();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.Folio = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.cmbGuardar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodo";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPeriodo.Location = new System.Drawing.Point(135, 40);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(269, 20);
            this.txtPeriodo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carrera";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtGrupo.Location = new System.Drawing.Point(135, 95);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(269, 20);
            this.txtGrupo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grupo";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtMatricula.Location = new System.Drawing.Point(135, 121);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(269, 20);
            this.txtMatricula.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Matricula";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlumno.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtAlumno.Location = new System.Drawing.Point(135, 147);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(269, 20);
            this.txtAlumno.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alumno";
            // 
            // txtTutor
            // 
            this.txtTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTutor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtTutor.Location = new System.Drawing.Point(135, 173);
            this.txtTutor.Name = "txtTutor";
            this.txtTutor.Size = new System.Drawing.Size(269, 20);
            this.txtTutor.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tutor";
            // 
            // cmbMotivos
            // 
            this.cmbMotivos.FormattingEnabled = true;
            this.cmbMotivos.Location = new System.Drawing.Point(135, 199);
            this.cmbMotivos.Name = "cmbMotivos";
            this.cmbMotivos.Size = new System.Drawing.Size(269, 21);
            this.cmbMotivos.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Motivo";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(135, 226);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(269, 20);
            this.txtDias.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dias";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha solicitud";
            // 
            // dtpSolicitud
            // 
            this.dtpSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSolicitud.Location = new System.Drawing.Point(135, 258);
            this.dtpSolicitud.Name = "dtpSolicitud";
            this.dtpSolicitud.Size = new System.Drawing.Size(269, 20);
            this.dtpSolicitud.TabIndex = 17;
            // 
            // cmbModulos
            // 
            this.cmbModulos.FormattingEnabled = true;
            this.cmbModulos.Items.AddRange(new object[] {
            "Todos",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbModulos.Location = new System.Drawing.Point(135, 284);
            this.cmbModulos.Name = "cmbModulos";
            this.cmbModulos.Size = new System.Drawing.Size(269, 21);
            this.cmbModulos.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Módulos";
            // 
            // dgvFechas
            // 
            this.dgvFechas.AllowUserToAddRows = false;
            this.dgvFechas.AllowUserToDeleteRows = false;
            this.dgvFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFechas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fechas});
            this.dgvFechas.Location = new System.Drawing.Point(135, 418);
            this.dgvFechas.Name = "dgvFechas";
            this.dgvFechas.ReadOnly = true;
            this.dgvFechas.RowHeadersVisible = false;
            this.dgvFechas.Size = new System.Drawing.Size(269, 68);
            this.dgvFechas.TabIndex = 20;
            // 
            // Fechas
            // 
            this.Fechas.HeaderText = "Fechas";
            this.Fechas.Name = "Fechas";
            this.Fechas.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fecha(s) justificadas";
            // 
            // dtpJustificadas
            // 
            this.dtpJustificadas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJustificadas.Location = new System.Drawing.Point(135, 311);
            this.dtpJustificadas.Name = "dtpJustificadas";
            this.dtpJustificadas.Size = new System.Drawing.Size(192, 20);
            this.dtpJustificadas.TabIndex = 22;
            // 
            // cmbAddFecha
            // 
            this.cmbAddFecha.BackgroundImage = global::SEUTCV2.Properties.Resources.add;
            this.cmbAddFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmbAddFecha.Location = new System.Drawing.Point(334, 311);
            this.cmbAddFecha.Name = "cmbAddFecha";
            this.cmbAddFecha.Size = new System.Drawing.Size(70, 20);
            this.cmbAddFecha.TabIndex = 23;
            this.cmbAddFecha.UseVisualStyleBackColor = true;
            this.cmbAddFecha.Visible = false;
            this.cmbAddFecha.Click += new System.EventHandler(this.cmbAddFecha_Click);
            // 
            // txtCarrera
            // 
            this.txtCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrera.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtCarrera.Location = new System.Drawing.Point(135, 66);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(269, 20);
            this.txtCarrera.TabIndex = 24;
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtComentario.Location = new System.Drawing.Point(135, 337);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(269, 66);
            this.txtComentario.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Comentarios";
            // 
            // txtFolio
            // 
            this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtFolio.Location = new System.Drawing.Point(135, 14);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(269, 20);
            this.txtFolio.TabIndex = 28;
            // 
            // Folio
            // 
            this.Folio.AutoSize = true;
            this.Folio.Location = new System.Drawing.Point(25, 17);
            this.Folio.Name = "Folio";
            this.Folio.Size = new System.Drawing.Size(43, 13);
            this.Folio.TabIndex = 27;
            this.Folio.Text = "Periodo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAdd});
            this.toolStrip1.Location = new System.Drawing.Point(327, 309);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(35, 25);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnAdd
            // 
            this.BtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(23, 22);
            this.BtnAdd.Text = "Agregar fecha";
            this.BtnAdd.Click += new System.EventHandler(this.cmbAddFecha_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbGuardar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 507);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(416, 25);
            this.toolStrip2.TabIndex = 30;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // cmbGuardar
            // 
            this.cmbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmbGuardar.Image")));
            this.cmbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmbGuardar.Name = "cmbGuardar";
            this.cmbGuardar.Size = new System.Drawing.Size(23, 22);
            this.cmbGuardar.Text = "Guardar justificacion";
            this.cmbGuardar.Click += new System.EventHandler(this.cmbGuardar_Click);
            // 
            // frmJustificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 532);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.Folio);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.cmbAddFecha);
            this.Controls.Add(this.dtpJustificadas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvFechas);
            this.Controls.Add(this.cmbModulos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpSolicitud);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbMotivos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTutor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmJustificaciones";
            this.Text = "Solicitar Justificacion";
            this.Load += new System.EventHandler(this.frmJustificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMotivos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpSolicitud;
        private System.Windows.Forms.ComboBox cmbModulos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvFechas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpJustificadas;
        private System.Windows.Forms.Button cmbAddFecha;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label Folio;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnAdd;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton cmbGuardar;
    }
}