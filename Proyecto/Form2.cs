using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form2 : Form
    {
        private Dictionary<string, Hotel> hoteles;

        public Form2()
        {
            InitializeComponent();
            InitializeHotels();
        }

        private void InitializeHotels()
        {
            hoteles = new Dictionary<string, Hotel>
            {
                { "El Altar", new Hotel("Hotel El Altar") },
                { "Montecarlo", new Hotel("Hotel Montecarlo") },
                { "Chimborazo", new Hotel("Hotel Chimborazo") },
                { "Zeus", new Hotel("Hotel Zeus") },
                { "La Andaluza", new Hotel("Hotel La Andaluza") },
                { "Abraspungo", new Hotel("Hotel Abraspungo") }
            };

            // Inicializar información de los hoteles
            InitializeHotelElAltar();
            InitializeHotelMontecarlo();
            InitializeHotelChimborazo();
            InitializeHotelZeus();
            InitializeHotelAndaluza();
            InitializeHotelAbraspungo();

            // Asignación de eventos de botones
            btnConsultarElAltar_Click.Click += btnConsultarElAltar;
            btnConsultarMontecarlo_Click.Click += btnConsultarMontecarlo;
            btnConsultarChimborazo_Click.Click += btnConsultarChimborazo;
            btnConsultarZeus_Click.Click += btnConsultarZeus;
            btnConsultarAndaluza_Click.Click += btnConsultarAndaluza;
            btnConsultarAbraspungo_Click.Click += btnConsultarAbraspungo;
        }

        private void InitializeHotelElAltar()
        {
            hoteles["El Altar"].Descripcion = "Hotel de 3 estrellas ubicado a 48 km de Chimborazo Volcano, " +
                "con alojamiento con salón de uso común, parking privado gratis y terraza. " +
                "Ofrece centro de negocios y servicio de conserjería.";
            hoteles["El Altar"].Servicios = new List<string>
            {
                "Recepción 24 horas",
                "Traslado aeropuerto",
                "WiFi gratis",
                "Desayuno americano",
                "Zona de juegos infantil"
            };
        }

        private void InitializeHotelMontecarlo()
        {
            hoteles["Montecarlo"].Descripcion = "Hotel Montecarlo ofrece alojamiento de lujo con vista panorámica...";
            hoteles["Montecarlo"].Servicios = new List<string>
            {
                "Restaurant gourmet",
                "Spa y centro de bienestar",
                "WiFi de alta velocidad",
                "Servicio a la habitación 24/7"
            };
        }

        private void InitializeHotelChimborazo()
        {
            hoteles["Chimborazo"].Descripcion = "Hotel Chimborazo con alojamiento confortable y amplias vistas...";
            hoteles["Chimborazo"].Servicios = new List<string>
            {
                "Desayuno incluido",
                "Tours guiados",
                "WiFi gratis",
                "Gimnasio",
                "Piscina climatizada"
            };
        }

        private void InitializeHotelZeus()
        {
            hoteles["Zeus"].Descripcion = "Hotel Zeus situado en el corazón de la ciudad, ofrece elegancia y comodidad...";
            hoteles["Zeus"].Servicios = new List<string>
            {
                "Servicio de lavandería",
                "Recepción 24 horas",
                "WiFi gratis",
                "Restaurante internacional",
                "Bar"
            };
        }

        private void InitializeHotelAndaluza()
        {
            hoteles["La Andaluza"].Descripcion = "La Andaluza es un hotel boutique con atención personalizada y elegantes instalaciones...";
            hoteles["La Andaluza"].Servicios = new List<string>
            {
                "Desayuno buffet",
                "Spa y masajes",
                "WiFi de alta velocidad",
                "Servicio de habitaciones",
                "Jardines"
            };
        }

        private void InitializeHotelAbraspungo()
        {
            hoteles["Abraspungo"].Descripcion = "Hotel Abraspungo ubicado en un hermoso entorno natural con vistas a las montañas...";
            hoteles["Abraspungo"].Servicios = new List<string>
            {
                "Senderismo",
                "WiFi gratis",
                "Desayuno incluido",
                "Tours a caballo",
                "Restaurante"
            };
        }

        // Manejadores de eventos para cada botón de consulta
        private void btnConsultarElAltar(object sender, EventArgs e)
        {
            MostrarDetalleHotel("El Altar");
        }

        private void btnConsultarMontecarlo(object sender, EventArgs e)
        {
            MostrarDetalleHotel("Montecarlo");
        }

        private void btnConsultarChimborazo(object sender, EventArgs e)
        {
            MostrarDetalleHotel("Chimborazo");
        }

        private void btnConsultarZeus(object sender, EventArgs e)
        {
            MostrarDetalleHotel("Zeus");
        }

        private void btnConsultarAndaluza(object sender, EventArgs e)
        {
            MostrarDetalleHotel("La Andaluza");
        }

        private void btnConsultarAbraspungo(object sender, EventArgs e)
        {
            MostrarDetalleHotel("Abraspungo");
        }

        private void MostrarDetalleHotel(string nombreHotel)
        {
            try
            {
                if (hoteles.ContainsKey(nombreHotel))
                {
                    Form4 detalleForm = new Form4(hoteles[nombreHotel]);
                    detalleForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El hotel no existe en la colección.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Código de inicialización si es necesario
        }
    }
}
