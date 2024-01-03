using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication2
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SoundPlayer snd = new SoundPlayer(WindowsFormsApplication2.Properties.Resources.MainTheme);
            
            if(button1.Text == "OFF")
            {
                button1.Text = "ON";
                snd.Play();
            }
            else
            {
                button1.Text = "OFF";
                snd.Stop();
            }
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
