using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ceExplorerPatch
{
    public partial class FileExplorer : Form
    {
        public FileExplorer()
        {
            InitializeComponent();
            Navigate();
        }

        public void Navigate()
        {
            this.Navigate("");
        }

        public void Navigate(string Path)
        {
            menu.MenuItems.Clear();
            FSView.Items.Clear();

            FileSystem.Navigate(Path);
            ArrayList folders = FileSystem.GetFolders();
            ArrayList files = FileSystem.GetFiles();

            // navigation menu
            string[] dirs;
            dirs=FileSystem.CurrentPath.Split('\\');

            for(int i=dirs.Length-1;i>=0;i--)
            {
                if (dirs[i] != "")
                {
                    MenuItem m = new MenuItem();
                    m.Text = dirs[i];

                    if (menu.MenuItems.Count==0)
                        menu.MenuItems.Add(m);
                    else
                        menu.MenuItems[0].MenuItems.Add(m);                     
                }
            }            
            // add my-device menu
            MenuItem root = new MenuItem();
            root.Text = "My Device";
            if (menu.MenuItems.Count == 0)
                menu.MenuItems.Add(root);
            else
                menu.MenuItems[0].MenuItems.Add(root);

            // filesystem view            
            foreach (string folder in folders)
            {
                FSView.Items.Add(new ListViewItem(folder));
            }
            foreach (string file in files)
            {
                FSView.Items.Add(new ListViewItem(file));
            }
        }

        private void FSView_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem selected = FSView.Items[FSView.SelectedIndices[0]];
            string SelectedPath = FileSystem.CurrentPath + selected.Text;

            if (FileSystem.CheckItemType(SelectedPath) == FileSystemItemType.FOLDER)
                this.Navigate(FileSystem.CurrentPath + selected.Text);
            else
                FileSystem.Execute(SelectedPath);
        }
    }
}