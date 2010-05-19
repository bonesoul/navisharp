using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ceExplorerPatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.WindowState = FormWindowState.Maximized;
            CheckPatch();           
        }

        private void CheckPatch()
        {
            if (Patcher.Check()) cmdPatch.Enabled = true;
            else cmdPatch.Enabled = false;
            listboxInfo.Items.Clear();
            listboxInfo.Items.Add("Got Explorer.exe: " + Patcher.GotExplorerExe);
            listboxInfo.Items.Add("Got Init Key: " + Patcher.GotInitKey);
            listboxInfo.Items.Add("Current Shell: " + Patcher.Shell);
        }

        private void cmdPatch_Click(object sender, EventArgs e)
        {
            Patcher.Patch();
            this.CheckPatch();
        }
    }
}