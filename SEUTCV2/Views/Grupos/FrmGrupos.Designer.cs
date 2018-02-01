namespace SEUTCV2.Views
{
    partial class FrmGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrupos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DgvCarreras = new System.Windows.Forms.DataGridView();
            this.CmbCarreras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CmbGrup = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbGrado = new System.Windows.Forms.ComboBox();
            this.CmbCarrera = new System.Windows.Forms.ComboBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.TxtPeriodo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNuevo2 = new System.Windows.Forms.ToolStripButton();
            this.BtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtnTodos = new System.Windows.Forms.ToolStripButton();
            this.BtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarreras)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(395, 268);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.DgvCarreras);
            this.tabPage1.Controls.Add(this.CmbCarreras);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(387, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de grupos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(322, 205);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(0, 20);
            this.LblTotal.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Total :";
            // 
            // DgvCarreras
            // 
            this.DgvCarreras.AllowUserToAddRows = false;
            this.DgvCarreras.AllowUserToDeleteRows = false;
            this.DgvCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCarreras.Location = new System.Drawing.Point(10, 40);
            this.DgvCarreras.Name = "DgvCarreras";
            this.DgvCarreras.ReadOnly = true;
            this.DgvCarreras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCarreras.Size = new System.Drawing.Size(374, 154);
            this.DgvCarreras.TabIndex = 2;
            // 
            // CmbCarreras
            // 
            this.CmbCarreras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCarreras.FormattingEnabled = true;
            this.CmbCarreras.Location = new System.Drawing.Point(54, 13);
            this.CmbCarreras.Name = "CmbCarreras";
            this.CmbCarreras.Size = new System.Drawing.Size(287, 21);
            this.CmbCarreras.TabIndex = 1;
            this.CmbCarreras.SelectionChangeCommitted += new System.EventHandler(this.CmbCarreras_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrera";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CmbGrup);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.CmbGrado);
            this.tabPage2.Controls.Add(this.CmbCarrera);
            this.tabPage2.Controls.Add(this.TxtClave);
            this.tabPage2.Controls.Add(this.TxtPeriodo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(387, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CmbGrup
            // 
            this.CmbGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGrup.FormattingEnabled = true;
            this.CmbGrup.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.CmbGrup.Location = new System.Drawing.Point(232, 89);
            this.CmbGrup.Name = "CmbGrup";
            this.CmbGrup.Size = new System.Drawing.Size(149, 21);
            this.CmbGrup.TabIndex = 14;
            this.CmbGrup.SelectionChangeCommitted += new System.EventHandler(this.CmbGrup_SelectionChangeCommitted);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.DropDownStyleChanged += new System.EventHandler(this.CmbGrado_DropDownStyleChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Plan";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(55, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cupo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Grupo";
            // 
            // CmbGrado
            // 
            this.CmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGrado.FormattingEnabled = true;
            this.CmbGrado.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CmbGrado.Location = new System.Drawing.Point(55, 89);
            this.CmbGrado.Name = "CmbGrado";
            this.CmbGrado.Size = new System.Drawing.Size(122, 21);
            this.CmbGrado.TabIndex = 7;
            this.CmbGrado.SelectedIndexChanged += new System.EventHandler(this.CmbGrado_SelectedIndexChanged);
            this.CmbGrado.SelectionChangeCommitted += new System.EventHandler(this.CmbGrado_SelectionChangeCommitted);
            this.CmbGrado.DropDownStyleChanged += new System.EventHandler(this.CmbGrado_DropDownStyleChanged);
            // 
            // CmbCarrera
            // 
            this.CmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCarrera.FormattingEnabled = true;
            this.CmbCarrera.Location = new System.Drawing.Point(55, 49);
            this.CmbCarrera.Name = "CmbCarrera";
            this.CmbCarrera.Size = new System.Drawing.Size(326, 21);
            this.CmbCarrera.TabIndex = 6;
            this.CmbCarrera.SelectionChangeCommitted += new System.EventHandler(this.CmbCarrera_SelectionChangeCommitted);
            this.CmbCarrera.DropDownStyleChanged += new System.EventHandler(this.CmbGrado_DropDownStyleChanged);
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(232, 12);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.ReadOnly = true;
            this.TxtClave.Size = new System.Drawing.Size(149, 20);
            this.TxtClave.TabIndex = 5;
            this.TxtClave.TabStop = false;
            // 
            // TxtPeriodo
            // 
            this.TxtPeriodo.Location = new System.Drawing.Point(55, 12);
            this.TxtPeriodo.Name = "TxtPeriodo";
            this.TxtPeriodo.ReadOnly = true;
            this.TxtPeriodo.Size = new System.Drawing.Size(109, 20);
            this.TxtPeriodo.TabIndex = 4;
            this.TxtPeriodo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Grado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clave";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Periodo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNuevo2,
            this.BtnEliminar,
            this.BtnGuardar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(408, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnNuevo2
            // 
            this.BtnNuevo2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNuevo2.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo2.Image")));
            this.BtnNuevo2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNuevo2.Name = "BtnNuevo2";
            this.BtnNuevo2.Size = new System.Drawing.Size(23, 22);
            this.BtnNuevo2.Text = "Crear nuevo grupo";
            this.BtnNuevo2.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(23, 22);
            this.BtnEliminar.Text = "Eliminar Grupo";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnTodos});
            this.toolStrip2.Location = new System.Drawing.Point(344, 12);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(35, 25);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BtnTodos
            // 
            this.BtnTodos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnTodos.Image = ((System.Drawing.Image)(resources.GetObject("BtnTodos.Image")));
            this.BtnTodos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnTodos.Name = "BtnTodos";
            this.BtnTodos.Size = new System.Drawing.Size(23, 22);
            this.BtnTodos.Text = "Todos los grupos";
            this.BtnTodos.Click += new System.EventHandler(this.BtnTodos_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(23, 22);
            this.BtnGuardar.Text = "Guardar grupo";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 292);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmGrupos";
            this.Text = "Panel de grupos";
            this.Load += new System.EventHandler(this.FrmGrupos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarreras)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox CmbCarreras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DgvCarreras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbGrado;
        private System.Windows.Forms.ComboBox CmbCarrera;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtPeriodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbGrup;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnNuevo2;
        private System.Windows.Forms.ToolStripButton BtnEliminar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtnTodos;
        private System.Windows.Forms.ToolStripButton BtnGuardar;
    }
}