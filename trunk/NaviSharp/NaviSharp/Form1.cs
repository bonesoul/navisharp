using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NaviLib;

namespace NaviSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = NaviLib.Screen.GetWorkingArea().Width;
            this.Height = NaviLib.Screen.GetWorkingArea().Height;

            Battery battery = new Battery();
            if (!battery.Charging)
                picBattery.Image = battery_images.Images[battery.Percent];
            else
                picBattery.Image = battery_images.Images[0];

            labelTime.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBattery_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bat!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            FileSystem.Run("\\residentflash\\MobileNavigator\\MobileNavigator.exe");
        }
    }
}