using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login123
{
    public partial class para_entender : Form
    {
        public para_entender()
        {
            InitializeComponent();
            this.Load += para_entender_Load;
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
        }


        private void para_entender_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\lenny\Desktop\w\para entender la historia de five nights at Freddy pac Man inteligente.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                Application.Exit();
            }
        }
    }
}
