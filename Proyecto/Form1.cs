using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        private const string USERNAME = "admin";
        private const string PASSWORD = "admin123";

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == USERNAME && txtContrasena.Text == PASSWORD)
            {
                Form2 mainForm = new Form2();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
