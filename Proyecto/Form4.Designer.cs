namespace Proyecto
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInformacion;
        private System.Windows.Forms.TabPage tabServicios;
        private System.Windows.Forms.TabPage tabVistaGeneral;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtInformacion;
        private System.Windows.Forms.TextBox txtBuscar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInformacion = new System.Windows.Forms.TabPage();
            this.panel = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.tabServicios = new System.Windows.Forms.TabPage();
            this.tabVistaGeneral = new System.Windows.Forms.TabPage();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabInformacion.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInformacion);
            this.tabControl1.Controls.Add(this.tabServicios);
            this.tabControl1.Controls.Add(this.tabVistaGeneral);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInformacion
            // 
            this.tabInformacion.Controls.Add(this.panel);
            this.tabInformacion.Location = new System.Drawing.Point(4, 22);
            this.tabInformacion.Name = "tabInformacion";
            this.tabInformacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabInformacion.Size = new System.Drawing.Size(792, 574);
            this.tabInformacion.TabIndex = 0;
            this.tabInformacion.Text = "INFORMACION";
            this.tabInformacion.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblTitulo);
            this.panel.Controls.Add(this.txtInformacion);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(3, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(786, 568);
            this.panel.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(124, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "INFORMACION";
            // 
            // txtInformacion
            // 
            this.txtInformacion.Location = new System.Drawing.Point(10, 40);
            this.txtInformacion.Multiline = true;
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.ReadOnly = true;
            this.txtInformacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInformacion.Size = new System.Drawing.Size(766, 518);
            this.txtInformacion.TabIndex = 1;
            this.txtInformacion.TextChanged += new System.EventHandler(this.txtInformacion_TextChanged);
            // 
            // tabServicios
            // 
            this.tabServicios.Location = new System.Drawing.Point(4, 22);
            this.tabServicios.Name = "tabServicios";
            this.tabServicios.Padding = new System.Windows.Forms.Padding(3);
            this.tabServicios.Size = new System.Drawing.Size(792, 574);
            this.tabServicios.TabIndex = 1;
            this.tabServicios.Text = "SERVICIOS";
            this.tabServicios.UseVisualStyleBackColor = true;
            // 
            // tabVistaGeneral
            // 
            this.tabVistaGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabVistaGeneral.Name = "tabVistaGeneral";
            this.tabVistaGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabVistaGeneral.Size = new System.Drawing.Size(792, 574);
            this.tabVistaGeneral.TabIndex = 2;
            this.tabVistaGeneral.Text = "VISTA GENERAL";
            this.tabVistaGeneral.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(0, 0);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtBuscar);
            this.Name = "Form4";
            this.Text = "Detalles del Hotel";
            this.tabControl1.ResumeLayout(false);
            this.tabInformacion.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}