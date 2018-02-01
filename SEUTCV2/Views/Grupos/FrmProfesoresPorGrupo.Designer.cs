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
            this.button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.CmbGrupos = new System.Windows.Forms.ComboBox();
            this.CmbCarreras = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPeriodo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbTutor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jOSÉGILBERTOBALAMBALAMToolStripMenuItem,
            this.iSCIVANVEGAUCToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(240, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseClick);
            // 
            // jOSÉGILBERTOBALAMBALAMToolStripMenuItem
            // 
            this.jOSÉGILBERTOBALAMBALAMToolStripMenuItem.Name = "jOSÉGILBERTOBALAMBALAMToolStripMenuItem";
            this.jOSÉGILBERTOBALAMBALAMToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.jOSÉGILBERTOBALAMBALAMToolStripMenuItem.Text = "JOSÉ GILBERTO BALAM BALAM";
            this.jOSÉGILBERTOBALAMBALAMToolStripMenuItem.Click += new System.EventHandler(this.jOSÉGILBERTOBALAMBALAMToolStripMenuItem_Click);
            // 
            // iSCIVANVEGAUCToolStripMenuItem
            // 
            this.iSCIVANVEGAUCToolStripMenuItem.Name = "iSCIVANVEGAUCToolStripMenuItem";
            this.iSCIVANVEGAUCToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.iSCIVANVEGAUCToolStripMenuItem.Text = "I.S.C IVAN VEGA UC";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guardar configuración";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.CmbGrupos.SelectedIndexChanged += new System.EventHandler(this.CmbGrupos_SelectedIndexChanged);
            this.CmbGrupos.SelectionChangeCommitted += new System.EventHandler(this.CmbGrupos_SelectionChangeCommitted);
            // 
            // CmbCarreras
            // 
            this.CmbCarreras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCarreras.FormattingEnabled = true;
            this.CmbCarreras.Location = new System.Drawing.Point(299, 31);
            this.CmbCarreras.Name = "CmbCarreras";
            this.CmbCarreras.Size = new System.Drawing.Size(285, 21);
            this.CmbCarreras.TabIndex = 4;
            this.CmbCarreras.SelectedIndexChanged += new System.EventHandler(this.CmbCarreras_SelectedIndexChanged);
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
            // FrmProfesoresPorGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 374);
            this.Controls.Add(this.CmbTutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPeriodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbCarreras);
            this.Controls.Add(this.CmbGrupos);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmProfesoresPorGrupo";
            this.Text = "Asignación de profesores y tutor de grupo";
            this.Load += new System.EventHandler(this.FrmProfesoresPorGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jOSÉGILBERTOBALAMBALAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSCIVANVEGAUCToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox CmbGrupos;
        private System.Windows.Forms.ComboBox CmbCarreras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPeriodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbTutor;
    }
}