namespace SEUTCV2.Views.Main
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPanelGrupos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAsignarProfes = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDeProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gruposToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.alumnosToolStripMenuItem});
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuPanelGrupos,
            this.MnuAsignarProfes});
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gruposToolStripMenuItem.Text = "Grupos";
            // 
            // MnuPanelGrupos
            // 
            this.MnuPanelGrupos.Name = "MnuPanelGrupos";
            this.MnuPanelGrupos.Size = new System.Drawing.Size(172, 22);
            this.MnuPanelGrupos.Text = "Panel grupos";
            this.MnuPanelGrupos.Click += new System.EventHandler(this.MnuPanelGrupos_Click);
            // 
            // MnuAsignarProfes
            // 
            this.MnuAsignarProfes.Name = "MnuAsignarProfes";
            this.MnuAsignarProfes.Size = new System.Drawing.Size(172, 22);
            this.MnuAsignarProfes.Text = "Asignar profesores";
            this.MnuAsignarProfes.Click += new System.EventHandler(this.MnuAsignarProfes_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelDeProfesoresToolStripMenuItem,
            this.asignarToolStripMenuItem});
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // panelDeProfesoresToolStripMenuItem
            // 
            this.panelDeProfesoresToolStripMenuItem.Name = "panelDeProfesoresToolStripMenuItem";
            this.panelDeProfesoresToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.panelDeProfesoresToolStripMenuItem.Text = "Panel de profesores";
            this.panelDeProfesoresToolStripMenuItem.Click += new System.EventHandler(this.panelDeProfesoresToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelDeAlumnosToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // panelDeAlumnosToolStripMenuItem
            // 
            this.panelDeAlumnosToolStripMenuItem.Name = "panelDeAlumnosToolStripMenuItem";
            this.panelDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.panelDeAlumnosToolStripMenuItem.Text = "Panel de alumnos";
            // 
            // asignarToolStripMenuItem
            // 
            this.asignarToolStripMenuItem.Name = "asignarToolStripMenuItem";
            this.asignarToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.asignarToolStripMenuItem.Text = "Asignar";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SEUTCV2.Properties.Resources.Fondo_4;
            this.ClientSize = new System.Drawing.Size(902, 457);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Sisema de gestión escolar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuPanelGrupos;
        private System.Windows.Forms.ToolStripMenuItem MnuAsignarProfes;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelDeProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarToolStripMenuItem;
    }
}