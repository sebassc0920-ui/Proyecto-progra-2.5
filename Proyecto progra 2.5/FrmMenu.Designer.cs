namespace Proyecto_progra_2._5
{
    partial class FrmMenu
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
            this.registroDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seccionAdministrativaYPartePrivadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAlLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeDatosToolStripMenuItem,
            this.seccionAdministrativaYPartePrivadaToolStripMenuItem,
            this.mantenimientoDeEmpleadosToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.volverAlLoginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroDeDatosToolStripMenuItem
            // 
            this.registroDeDatosToolStripMenuItem.Name = "registroDeDatosToolStripMenuItem";
            this.registroDeDatosToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.registroDeDatosToolStripMenuItem.Text = "Registro de Datos";
            // 
            // seccionAdministrativaYPartePrivadaToolStripMenuItem
            // 
            this.seccionAdministrativaYPartePrivadaToolStripMenuItem.Name = "seccionAdministrativaYPartePrivadaToolStripMenuItem";
            this.seccionAdministrativaYPartePrivadaToolStripMenuItem.Size = new System.Drawing.Size(221, 20);
            this.seccionAdministrativaYPartePrivadaToolStripMenuItem.Text = "Seccion Administrativa y Parte Privada";
            // 
            // mantenimientoDeEmpleadosToolStripMenuItem
            // 
            this.mantenimientoDeEmpleadosToolStripMenuItem.Name = "mantenimientoDeEmpleadosToolStripMenuItem";
            this.mantenimientoDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.mantenimientoDeEmpleadosToolStripMenuItem.Text = "Mantenimiento de Empleados";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            // 
            // volverAlLoginToolStripMenuItem
            // 
            this.volverAlLoginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.volverAlLoginToolStripMenuItem.Name = "volverAlLoginToolStripMenuItem";
            this.volverAlLoginToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.volverAlLoginToolStripMenuItem.Text = "Volver al Login o Salir";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seccionAdministrativaYPartePrivadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAlLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}