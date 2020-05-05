using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingApp
{
    public partial class Form1 : Form
    {
        int red, green, blue;

        private void ColorSwitch_Tick(object sender, EventArgs e)
        {
            ColorSwitch.Interval = 20;
            red = RedBar.Value;
            green = GreenBar.Value;
            blue = BlueBar.Value;
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        public Form1()
        {
            InitializeComponent();
            ColorSwitch.Start();
        }
        
    }
}
