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
                { "El Altar", new Hotel("Hotel El Altar" ) },
                { "Montecarlo", new Hotel("Hotel Montecarlo" ) },
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
            hoteles["El Altar"].Descripcion = "Hotel El Altar está en Riobamba, a 48 km del Volcán Chimborazo" +
                "y dispone de alojamiento con salón de uso común, parking privado gratis y terraza," +
                "Este hotel de 3 estrellas ofrece centro de negocios y servicio de conserjería." +
                "El alojamiento ofrece recepción 24 horas," + "traslado para ir o volver del aeropuerto" +
                "servicio de habitaciones y wifi gratis en todo el alojamiento.Esta hubicado Av 11 de Noviembre y Demetrio Aguilera, 060150 Riobamba, Ecuador.";

            hoteles["El Altar"].Servicios = new List<string>
            {
                                "                      SERVICIOS POPULARES    ",
                "- Recepción 24 horas",
                "- Traslado aeropuerto",
                "- WiFi gratis",
                "- Desayuno americano",
                "- Zona de juegos infantil",
                "- Habitacion sin humo",
                "- Salas de reuniones o eventos ",
                "- Spa y centro de bienestar",
                "",
                "***************TIPO DE HABITACIONES*************",
                " ",
                "                                HABITACIÒN CON CAMA GRANDE",
                "-  1 cama doble",
                "Caja fuerte, Bañera o ducha, Toallas, Ropa de cama, Escritorio, TV, ",
                " Teléfono, Canales vía satélite, Plancha para ropa, Calefacción, Toallas / sábanas (por un suplemento), ",
                " Canales por cable, Servicio de despertador, Acceso al salón executive, Armario,",
                " Toda la unidad en la planta baja, Perchero, Papel higiénico, Purificadores de aire. ",
                " Vistas a la ciudad, Baño privado, Minibar, WiFi gratis.",
                " ",
                "                                  PRECIO   ",
                "US$60 US$60 + US$9 de impuestos y cargos    (2 PERSONAS)",
                " ",
                  "                                HABITACIÒN TRILPE",
                "-  3 camas individuales",
                "Artículos de aseo gratis, Ducha, WC, Suelo de madera parquet, Toallas,",
                "Enchufe cerca de la cama, Productos de limpieza, ",
                "Escritorio, TV, Teléfono, Canales de pago, ",
                "Servicio de despertador / alarma, Canales por cable, ",
                "Servicio de despertador, Armario, Toda la unidad en la planta baja,",
                "Acceso a pisos superiores solo mediante escaleras,",
                "Perchero, Papel higiénico, Toda la unidad accesible en silla de ruedas",
                " ",
                "                                  PRECIO   ",
                "US$90 US$90 + US$13 de impuestos y cargo    (3 PERSONAS)",
                " ",
                "                                 HABITACIÒN CUADRUPLE",
                "- 4 camas individuales ",
                "Vistas a la ciudad, Baño privado, Minibar, WiFi gratis, Caja fuerte Bañera o ducha, Toallas",
                " Canales por cable, Servicio de despertador, Acceso al salón executive, Armario, Sofà cama.",
                "                                  PRECIO   ",
                "US$120 US$120 + US$18 de impuestos y cargos  (4 PERSONAS)",

            };
        }

        private void InitializeHotelMontecarlo()
        {
            hoteles["Montecarlo"].Descripcion = "Hotel El Altar está en Riobamba, a 50 km del Volcán Chimborazo," +
                "y ofrece alojamiento con jardín, parking privado gratis, salón de uso común y restaurante. " +
                " Este maravillos hotel ofrece servicio de habitaciones y recepción 24 horas. Algunas habitaciones  del  alojamiento " +
                " incluyen un balcón con vistas al jardín. Esta ubicado en la 10 de Agosto y España,  Riobamba, Ecuador.";

            hoteles["Montecarlo"].Servicios = new List<string>
            {
                                "                                SERVICIOS POPULARES",
                "- Restaurant gourmet",
                "- Spa y centro de bienestar",
                "- WiFi de alta velocidad",
                "- Servicio a la habitación 24/7",
                "- Parking gratis",
                "- Habitaciones familiares",
                "- Buen desayuno",
                "- Habitaciones sin humo",
                "    ",
                "    ",

                "***************TIPO DE HABITACIONES*************",
                " ",
                "                                HABITACIÒN TRILPE",
                "-  1 cama individual y 1 cama doble",
                "Artículos de aseo gratis, Ducha, WC, Suelo de madera parquet, Toallas,",
                "Enchufe cerca de la cama, Productos de limpieza, ",
                "Escritorio, TV, Teléfono, Canales de pago, ",
                "Servicio de despertador / alarma, Canales por cable, ",
                "Servicio de despertador, Armario, Toda la unidad en la planta baja,",
                "Acceso a pisos superiores solo mediante escaleras,",
                "Perchero, Papel higiénico, Toda la unidad accesible en silla de ruedas",
                " ",
                "                                  PRECIO   ",
                "US$45 US$45 + US$7 de impuestos y cargos     (2 PERSONAS)",
                "US$61  US$61 + US$9 de impuestos y cargos     (3 PERSONAS)",
                " ",
                "                                 HABITACIÒN CUADRUPLE",
                "- 3 camas individuales y 1 cama doble ",
                "Balcón, Vistas a un lugar de interés, Vistas a la ciudad, Baño en la habitación",
                "TV de pantalla plana, WiFi gratis",
                "                                  PRECIO   ",
                "US$76 US$76 + US$11 de impuestos y cargos  (4 PERSONAS)",
                "US$86 US$86 + US$13 de impuestos y cargos  (5 PERSONAS)",

            };
        }

        private void InitializeHotelChimborazo()
        {
            hoteles["Chimborazo"].Descripcion = "Hotel Chimborazo Internacional se encuentra en Riobamba," +
                " a 50 km del Volcàn Chimborazo , y ofrece alojamiento con salón de uso común, parking privado gratis, terraza y restaurante." +
                " Este hotel de 2 estrellas tiene wifi gratis, servicio de habitaciones y recepción 24 horas. " +
                " El alojamiento dispone de karaoke y servicio de conserjería. Estamos ubicados en la Argentinos y Los Nogales, 060101 Riobamba, Ecuador";

            hoteles["Chimborazo"].Servicios = new List<string>
            {
                               "                      SERVICIOS POPULARES",
                "Desayuno incluido",
                "Tours guiados",
                "WiFi gratis",
                "Gimnasio",
                "Piscina climatizada",
                "Servicio de habitaciones",
                "Parking gratis",
                "Restaurante",
                "Bar",
                " ",
                  "***************TIPO DE HABITACIONES*************",
                " ",
                "                                HABITACIÒN DOBLE",
                "-  1 cama individual",
               "Vistas, Baño en la habitación, TV de pantalla plana, Minibar, WiFi gratis, ",
                "  Artículos de aseo gratis, WC, Sofá,  Chimenea,  Bañera o ducha",
                " Suelo de madera o parquet, Toallas, Enchufe cerca de la cama, Entrada privada, TV, ",
                " Teléfono, Habitaciones comunicadas disponibles, Secador de pelo,  Canales por cable,",
                "Reloj despertador, Armario,  Papel higiénico, Sofá cama,  Purificadores de aire",
                " ",
                "                                  PRECIO   ",
                "US$52 US$52 + US$14 de impuestos y cargos     (2 PERSONAS)",
                " ",
                "                                 HABITACIÒN DOBLE CAMA",
                "- 1 cama individual y 1 cama doble ",
                " Artículos de aseo gratis, WC, Bañera o ducha, Suelo de madera o parquet, Toallas, Entrada privada, ",
                "TV, Teléfono, Radio,  Canales de pago, Secador de pelo, Armario.",
                "                                  PRECIO   ",
                "US$62 US$62 + US$16 de impuestos y cargos   (4 PERSONAS)",
                "",
                  "                              SUITE FAMILIAR",
                "- 3 camas individuales",
                "Wifi Gratis",
                "                                  PRECIO   ",
                "US$79 US$62 + US$21 de impuestos y cargos   (4 PERSONAS)",

            };
        }

        private void InitializeHotelZeus()
        {
            hoteles["Zeus"].Descripcion = "Hotel Zeus está en Riobamba, a 49 km del Volcàn Chimborazo, " +
                "y dispone de alojamiento con centro de fitness, parking privado gratis, jardín y terraza." +
                "Este alojamiento ofrece restaurante, servicio de habitaciones y recepción 24 horas, " +
                "además de wifi gratis en todo el alojamiento. Hay bar. En el hotel, " +
                "todas las habitaciones incluyen escritorio, TV de pantalla plana, baño privado," +
                "ropa de cama y toallas. Las unidades disponen de caja fuerte. " +
                "En Hotel Zeus se puede disfrutar de un desayuno americano. " +
                "Se puede jugar al billar y al ping-pong en el alojamiento, y también hay alquiler de bicicletas y alquiler de coches.";

            hoteles["Zeus"].Servicios = new List<string>
            {
                               "                SERVICIOS POPULARES",
                "Servicio de lavandería",
                "Recepción 24 horas",
                "WiFi gratis",
                "Restaurante internacional",
                "Bar",
                "Servicio de habitaciones",
                "Desayuno Fantastico",
                "Adaptado personas de movilidad reducida",
                " ",
                  "***************TIPO DE HABITACIONES*************",
                " ",
                "                                HABITACIÒN DOBLE CON VISTAS A LA MONTAÑA",
                "-  1 o 2 camas individuales y 2 camas individuales  y 1 cama doble  y 1 cama doble grande ",
               "Vistas a la montaña, Vistas a un lugar de interés, Vistas a la ciudad, Baño privado, TV de pantalla plana, Terraza, WiFi gratis",
                "Baño en la habitación, TV de pantalla plana, Minibar, WiFi gratis, ",
                "  Artículos de aseo gratis, WC, Sofá,  Chimenea,  Bañera o ducha",
                " Suelo de madera o parquet, Toallas, Enchufe cerca de la cama, Entrada privada, TV, ",
                " Teléfono, Habitaciones comunicadas disponibles, Secador de pelo,  Canales por cable,",
                "Reloj despertador, Armario,  Papel higiénico, Sofá cama,  Purificadores de aire",
                " ",
                "                                  PRECIO   ",
                "US$81 incluyen impuestos y cargos     (2 PERSONAS)",
                " ",
                "                                 HABITACIÒN IDIVIDUAL DE LUJO",
                "- 1 cama individual y 1 cama doble ",
               "Vistas a la montaña, Vistas a un lugar de interés, Vistas a la ciudad, Baño privado, TV de pantalla plana, Terraza, WiFi gratis",
                "Baño en la habitación, TV de pantalla plana, Minibar, WiFi gratis, ",
                "  Artículos de aseo gratis, WC, Sofá,  Chimenea,  Bañera o ducha",
                " Suelo de madera o parquet, Toallas, Enchufe cerca de la cama, Entrada privada, TV, ",
                " Teléfono, Habitaciones comunicadas disponibles, Secador de pelo,  Canales por cable,",
                "Reloj despertador, Armario,  Papel higiénico, Juegos de mesa/ puzles",
                "                                  PRECIO   ",
                "US$90 Incluyen impuestos y cargos   (1 PERSONA)",

            };
        }

        private void InitializeHotelAndaluza()
        {
            hoteles["La Andaluza"].Descripcion =  "El hotel Andaluza está situada en una finca rural muy acogedora, " +
                " en la localidad de Riobamba, y ofrece habitaciones con TV de plasma y conexión Wi-Fi gratuita, además de 2 bares y 2 restaurantes." +
                " Este establecimiento sirve un desayuno diario y alberga una zona de barbacoa y varias pistas de baloncesto " +
                " y voleibol. Las habitaciones de La Andaluza presentan un mobiliario de madera y un suelo de moqueta y disponen de calefacción" +
                "  y baño privado. Todos los días se sirve un desayuno bufé casero. Los restaurantes Stable y La Piedra proponen especialidades" +
                " de cocina regional e internacional y la cafetería El Mirado ofrece bebidas calientes y pasteles recién horneados. " +
                " El bar El Portal organiza concursos de karaoke y sirve bebidas y cócteles. Entre las instalaciones deportivas del hotel, " +
                " encontrará instalaciones para jugar a fútbol, voleibol y baloncesto. Si lo prefiere, podrá practicar equitación por los alrededores." +
                " El establecimiento también alberga una sala de juegos con mesas de ping pong. La Hostería La Andaluza está situada a 217 km de la ciudad de Quito " +
                " y a 233 km de Guayaquil. La estación de tren de Urbina se encuentra a 8 km.";

            hoteles["La Andaluza"].Servicios = new List<string>
            {
                                "                       SERVICIOS POPULARES",
                "Desayuno buffet",
                "Spa y masajes",
                "WiFi de alta velocidad",
                "Servicio de habitaciones",
                "Jardines",
                "Habitaciones familiares",
                "Bar",
                "Traslado a aeropuerto",
                " ",
                  "***************TIPO DE HABITACIONES*************",
                " ",
                "                                HABITACIÒN DOBLE SUPERIOR",
                "-   1 cama doble grande ",
               "Cuna disponible a petición, Baño privado, TV de pantalla plana, WiFi gratis, ",
                "Artículos de aseo gratis, Ducha, Caja fuerte, Productos de limpieza, ",
                "Escritorio, TV, Teléfono, Canales vía satélite, Calefacción, Secador de pelo, Servicio de despertador, Armario",
                " ",
                "                                  PRECIO   ",
                "US$15 + US$29 de impuestos y cargos     (2 PERSONAS)",
                "",
                "                                SUITE SUPERIOR",
                "-   1 cama doblemente  extragrande ",
                "Cuna disponible a petición, Suite privada, Baño privado, TV de pantalla plana, WiFi gratis",
                " ",
                "                                  PRECIO   ",
                "US$148 + US$37 de impuestos y cargos     (2 PERSONAS)",
                 "",
                "                                SUITE PRESIDENCIAL",
                "-   1 cama doblemente  extragrande ",
                "Cuna disponible a petición, Suite privada, Baño privado, TV de pantalla plana, WiFi gratis",
                " ",
                "                                  PRECIO   ",
                "US$242 + US$60 de impuestos y cargos     (2 PERSONAS)",

            };
        }

        private void InitializeHotelAbraspungo()
        {
            hoteles["Abraspungo"].Descripcion = "El Abraspungo está situado en Riobamba, en una casa de estilo rústico con una elegante decoración colonial y " +
                "  habitaciones con conexión Wi-Fi gratuita. El Hotel Hacienda Abraspungo tiene galerías españolas que dan al jardín. " +
                 " Las habitaciones del Abraspungo son elegantes y cuentan con vistas al jardín, TV por cable de pantalla plana y baño privado " +
                 " con artículos de aseo gratuitos. Algunas tienen balcón privado. El restaurante ofrece platos regionales e internacionales. " +
                 "El establecimiento está a 1,5 km del centro comercial Riobamba y alberga una tienda de recuerdos con artesanía regional." +
                 "La estación principal de autobuses de Riobamba está a 15 minutos en coche. Hay aparcamiento privado gratuito.";

            hoteles["Abraspungo"].Servicios = new List<string>
            {
                "                       SERVICIOS POPULARES",
                "Senderismo",
                "WiFi gratis",
                "Desayuno incluido",
                "Tours a caballo",
                "Restaurante",
                "Servicio de habitaciones",
                "Parking gratis",
                "Gimnasio",
                "Bar",
                "Traslado aeropuerto",
                " ",
                  "***********************************TIPO DE HABITACIONES*****************************************",
                " ",
                "                                HABITACIÒN DOBLE -2 CAMAS ",
                "- 2 camas dobles ",
               "Vistas a la montaña, Vistas a un lugar de interés, Vistas a la ciudad, Baño privado, TV de pantalla plana, Terraza, WiFi gratis",
               "Vistas al jardín, Patio, Baño en la habitación, TV de pantalla plana, WiFi gratis, Artículos de aseo gratis,",
                "Caja fuerte, WC, Bañera o ducha, Toallas, Ropa de cama, Enchufe cerca de la cama, Escritorio, Teléfono,",
                "Canales vía satélite, Calefacción, Secador de pelo, Toallas / sábanas (por un suplemento), Servicio de despertador / alarma,"+
                "Canales por cable, Servicio de despertador, Armario, Papel higiénico, Detector de monóxido de carbono",
                " ",
                "                                  PRECIO   ",
                "US$113 + US$28 de impuestos y cargos     (2 PERSONAS)",
                " ",
                "                                 HABITACIÒN DOBLE",
                "- 1 cama doble extragrande ",
                "Vistas al jardín, Patio, Baño en la habitación, TV de pantalla plana, WiFi gratis",
                "                                  PRECIO   ",
                "US$113 + US$28 de impuestos y cargos   (2 PERSONA)",
                "",
                "                                 SUITE JUNIOR",
                "- 1 cama doble extragrande ",
                "Vistas al jardín, Suite privada,  Patio, Baño en la habitación, TV de pantalla plana, WiFi gratis",
                "                                  PRECIO   ",
                "US$164 + US$41 de impuestos y cargos   (2 PERSONA)",

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
