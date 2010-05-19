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
            CheckPatch();           
        }

        private void CheckPatch()
        {
            if (Patcher.Check()) cmdPatch.Enabled = true;
            else cmdPatch.Enabled = true;
            listboxInfo.Items.Clear();
            listboxInfo.Items.Add("Got Explorer.exe: " + Patcher.GotExplorerExe);
            listboxInfo.Items.Add("Got Init Key: " + Patcher.GotInitKey);
            listboxInfo.Items.Add("Current Shell: " + Patcher.Shell);
        }
       
        private void menuRunExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                FileSystem.Execute("\\windows\\explorer.exe");
            }
            catch (Exception exc) { }
        }

        private void cmdPatch_Click(object sender, EventArgs e)
        {
            Patcher.Patch();
            this.CheckPatch();
        }
    }
}