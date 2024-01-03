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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();   
        }

        SoundPlayer snd = new SoundPlayer(WindowsFormsApplication2.Properties.Resources.MainTheme);
        private void Menu_Load(object sender, EventArgs e)
        {
            //Properties.Resources.MainTheme
             //notify.wav
            snd.Play();


        }

        private void playButton_Click(object sender, EventArgs e)
        {
            snd.Stop();
            this.Hide();
            Form openForm = new Form1Game();
            //openForm.Visible = true;
            openForm.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form openForm = new credits();
            openForm.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form openForm = new settings();
            openForm.Visible = true;
        }
    }
}
