using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class deathscreen : Form
    {
        public deathscreen()
        {
            InitializeComponent();
        }



        private void deathscreen_Load(object sender, EventArgs e)
        {
            label1.Text = Form1Game.score.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deathscreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            label1.Text = "0";
        }
    }
}
