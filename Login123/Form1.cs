using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;
using AxWMPLib;

namespace Login123
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer bocci = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            SoundPlayer Terminator = new SoundPlayer(@"C:\Users\lenny\Desktop\w\The Terminator.wav");
            Terminator.PlaySync();

            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
 
            bocci.controls.stop();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mostrar_contrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrar_contrasena.Checked)
            {
                ingrese_contrasena.UseSystemPasswordChar = false;
            }
            else
            {
                ingrese_contrasena.UseSystemPasswordChar = true;
            }
        }

        private async void iniciar_seccion_Click(object sender, EventArgs e)
        {
            principal princial = new principal();
            princial.Show();
            this.Hide();
            WindowsMediaPlayer noche = new WindowsMediaPlayer();
            noche.URL = @"C:\Users\lenny\Desktop\w\windows-xp-startup_1ph012N.mp3";
            noche.controls.play();
            await Task.Delay(3500);
            noche.controls.stop();

        }

        private async void regristrate_Click(object sender, EventArgs e)
        {
            bocci.URL = @"C:\Users\lenny\Desktop\w\COQUETA  BOCCHI THE ROCK  Grupo Frontera & Fuerza Regida  Cover completo.mp3";
            bocci.controls.play();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            para_entender entender = new para_entender();
            entender.Show();
            this.Hide();
        }
    }
}
