using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace video_locadora
{
    public partial class Form_Splash : Form
    {
        public Form_Splash()
        {
            InitializeComponent();
        }

        private void Form_Splash_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            for (double i = 0; i < 1; i += 0.05)
            {
                this.Opacity = i;
                this.Refresh();
                System.Threading.Thread.Sleep(20);
            }

            Form_Principal Form_Princ = new Form_Principal();
            Form_Princ.ShowDialog();
            this.Close();
        }
    }
}
