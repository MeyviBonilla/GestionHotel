using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form3 : Form
    {
        private Hotel hotel;
        private TabControl tabControl1;
        private TabPage tabInformacion;
        private TabPage tabServicios;
        private TabPage tabVistaGeneral;
        private Panel panel;
        private TextBox txtInformacion;
        private TextBox txtBuscar;

        public Form3(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.Size = new Size(800, 600);
            ConfigureTabControl();
            LoadHotelInfo();
        }

        private void ConfigureTabControl()
        {
            // Configurar TabControl
            tabControl1 = new TabControl();
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            // Pestaña Información
            tabInformacion = new TabPage("INFORMACION");

            // Panel principal para la pestaña Información
            panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.Padding = new Padding(10);

            // Label para el título INFORMACION
            Label lblTitulo = new Label();
            lblTitulo.Text = "INFORMACION";
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(10, 10);

            // TextBox para la información
            txtInformacion = new TextBox();
            txtInformacion.Multiline = true;
            txtInformacion.ReadOnly = true;
            txtInformacion.Location = new Point(10, 40);
            txtInformacion.Size = new Size(panel.Width - 20, panel.Height - 50);
            txtInformacion.ScrollBars = ScrollBars.Vertical;
            txtInformacion.Font = new Font("Segoe UI", 9F);
            txtInformacion.BackColor = Color.White;

            panel.Controls.Add(lblTitulo);
            panel.Controls.Add(txtInformacion);
            tabInformacion.Controls.Add(panel);

            // Pestaña Servicios
            tabServicios = new TabPage("SERVICIOS");

            // Pestaña Vista General
            tabVistaGeneral = new TabPage("VISTA GENERAL");

            // Barra de búsqueda
            txtBuscar = new TextBox();
            txtBuscar.Text = "Escriba aquí";
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.Enter += new EventHandler(txtBuscar_Enter);
            txtBuscar.Leave += new EventHandler(txtBuscar_Leave);
            txtBuscar.Size = new Size(200, 23);
            txtBuscar.Location = new Point(this.Width - 220, 5);
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Agregar pestañas al TabControl
            tabControl1.TabPages.Add(tabInformacion);
            tabControl1.TabPages.Add(tabServicios);
            tabControl1.TabPages.Add(tabVistaGeneral);

            // Suscribir al evento de cambio de pestaña
            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);

            // Agregar controles al formulario
            this.Controls.Add(tabControl1);
            this.Controls.Add(txtBuscar);
        }

        // Eventos para simular placeholder
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Escriba aquí")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Escriba aquí";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void LoadHotelInfo()
        {
            if (hotel != null && !string.IsNullOrEmpty(hotel.Descripcion))
            {
                txtInformacion.Text = hotel.Descripcion;
            }
            else
            {
                txtInformacion.Text = "Información no disponible";
            }
        }

        private void LoadHotelServices()
        {
            tabServicios.Controls.Clear();

            if (hotel != null && hotel.Servicios != null && hotel.Servicios.Count > 0)
            {
                ListBox lstServicios = new ListBox();
                lstServicios.Dock = DockStyle.Fill;
                lstServicios.Font = new Font("Segoe UI", 9F);

                foreach (string servicio in hotel.Servicios)
                {
                    lstServicios.Items.Add(servicio);
                }

                tabServicios.Controls.Add(lstServicios);
            }
            else
            {
                Label lblNoServices = new Label();
                lblNoServices.Text = "No hay servicios disponibles";
                lblNoServices.AutoSize = true;
                lblNoServices.Location = new Point(10, 10);
                tabServicios.Controls.Add(lblNoServices);
            }
        }

        private void LoadHotelOverview()
        {
            tabVistaGeneral.Controls.Clear();

            Label lblOverview = new Label();
            lblOverview.Text = hotel != null ? hotel.Nombre : "Vista General";
            lblOverview.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOverview.AutoSize = true;
            lblOverview.Location = new Point(10, 10);

            tabVistaGeneral.Controls.Add(lblOverview);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "INFORMACION":
                    LoadHotelInfo();
                    break;
                case "SERVICIOS":
                    LoadHotelServices();
                    break;
                case "VISTA GENERAL":
                    LoadHotelOverview();
                    break;
            }
        }
    }
}