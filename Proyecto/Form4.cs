using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Proyecto
{
    public partial class Form4 : Form
    {
        private Hotel hotel;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCorreo;
        private TextBox txtPrecio;
        private Button btnReservar;
        private Button btnImprimir;
        private DataGridView dgvReserva;
        private string reserva;

        public Form4(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.Size = new Size(800, 600);
            ConfigureTabControl();
            LoadHotelInfo();
            InitializeReservationTab();
        }

        private void ConfigureTabControl()
        {
            // Configurar TabControl y pestañas
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            // Configuración para la pestaña Información
            tabInformacion.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Padding = new Padding(10);

            lblTitulo.Text = "INFORMACIÓN";
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(10, 10);

            txtInformacion.Multiline = true;
            txtInformacion.ReadOnly = true;
            txtInformacion.Location = new Point(10, 40);
            txtInformacion.Size = new Size(panel.Width - 20, panel.Height - 50);
            txtInformacion.ScrollBars = ScrollBars.Vertical;
            txtInformacion.Font = new Font("Segoe UI", 9F);
            txtInformacion.BackColor = Color.White;

            // Agregar controles al panel
            panel.Controls.Add(lblTitulo);
            panel.Controls.Add(txtInformacion);

            // Suscribir al evento de cambio de pestaña
            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);

            // Agregar controles al formulario
            this.Controls.Add(tabControl1);
            this.Controls.Add(txtBuscar);
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
                case "INFORMACIÓN":
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

        private void InitializeReservationTab()
        {
            TabPage tabReserva = new TabPage("RESERVA");

            // Panel de reserva
            Panel panelReserva = new Panel();
            panelReserva.Dock = DockStyle.Fill;
            panelReserva.Padding = new Padding(10);

            // Controles de entrada para la reserva
            Label lblNombre = new Label { Text = "Nombre:", Location = new Point(10, 10), AutoSize = true };
            txtNombre = new TextBox { Location = new Point(120, 10), Width = 200 };

            Label lblApellido = new Label { Text = "Apellido:", Location = new Point(10, 40), AutoSize = true };
            txtApellido = new TextBox { Location = new Point(120, 40), Width = 200 };

            Label lblCorreo = new Label { Text = "Correo:", Location = new Point(10, 70), AutoSize = true };
            txtCorreo = new TextBox { Location = new Point(120, 70), Width = 200 };

            Label lblPrecio = new Label { Text = "Precio:", Location = new Point(10, 100), AutoSize = true };
            txtPrecio = new TextBox { Location = new Point(120, 100), Width = 200 };

            btnReservar = new Button { Text = "Reservar", Location = new Point(120, 130) };
            btnReservar.Click += BtnReservar_Click;

            btnImprimir = new Button { Text = "Generar PDF", Location = new Point(220, 130) };
            btnImprimir.Click += BtnImprimir_Click;

            // Tabla para mostrar la reserva
            dgvReserva = new DataGridView
            {
                Location = new Point(10, 170),
                Size = new Size(760, 200),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true,
                ColumnCount = 4
            };
            dgvReserva.Columns[0].Name = "Nombre";
            dgvReserva.Columns[1].Name = "Apellido";
            dgvReserva.Columns[2].Name = "Correo";
            dgvReserva.Columns[3].Name = "Precio";

            // Agregar controles al panel de reserva
            panelReserva.Controls.Add(lblNombre);
            panelReserva.Controls.Add(txtNombre);
            panelReserva.Controls.Add(lblApellido);
            panelReserva.Controls.Add(txtApellido);
            panelReserva.Controls.Add(lblCorreo);
            panelReserva.Controls.Add(txtCorreo);
            panelReserva.Controls.Add(lblPrecio);
            panelReserva.Controls.Add(txtPrecio);
            panelReserva.Controls.Add(btnReservar);
            panelReserva.Controls.Add(btnImprimir);
            panelReserva.Controls.Add(dgvReserva);

            // Agregar el panel de reserva a la pestaña de reserva
            tabReserva.Controls.Add(panelReserva);

            // Agregar la pestaña de reserva al TabControl
            tabControl1.TabPages.Add(tabReserva);
        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text;
            string precio = txtPrecio.Text;
            string fechaReserva = DateTime.Now.ToString("dd/MM/yyyy");

            reserva = $"*** Recibo de Reserva ***\n\n" +
                      $"Hotel: {hotel.Nombre}\n" +
                      $"Fecha de Reserva: {fechaReserva}\n\n" +
                      $"Datos del Cliente:\n" +
                      $"Nombre: {nombre} {apellido}\n" +
                      $"Correo: {correo}\n\n" +
                      $"Detalle de la Reserva:\n" +
                      $"Precio: {precio} USD\n\n" +
                      $"¡Gracias por su preferencia!";

            // Agregar datos a la tabla
            dgvReserva.Rows.Clear();
            dgvReserva.Rows.Add(nombre, apellido, correo, precio);

            MessageBox.Show(reserva, "Confirmación de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintDoc_PrintPage);

            PrintDialog printDlg = new PrintDialog
            {
                Document = printDoc,
                UseEXDialog = true
            }; 

            printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDoc.PrinterSettings.PrintToFile = true;

            SaveFileDialog saveDlg = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Guardar Reserva como PDF",
                FileName = "Reserva.pdf"
            };

            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.PrinterSettings.PrintFileName = saveDlg.FileName;

                try
                {
                    printDoc.Print();
                    MessageBox.Show("El recibo ha sido guardado como PDF exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al imprimir o generar PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Dibujar el contenido de la reserva en el documento a imprimir
            e.Graphics.DrawString(reserva, new Font("Segoe UI", 12), Brushes.Black, new RectangleF(50, 50, e.PageBounds.Width - 100, e.PageBounds.Height - 100));
        }

        private void txtInformacion_TextChanged(object sender, EventArgs e)
        {
            // Evento manejador para TextBox de Información
        }
    }
}
