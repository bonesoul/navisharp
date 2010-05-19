namespace ceExplorerPatch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuRunExplorer = new System.Windows.Forms.MenuItem();
            this.listboxInfo = new System.Windows.Forms.ListBox();
            this.cmdPatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuRunExplorer);
            this.menuItem1.Text = "Menu";
            // 
            // menuRunExplorer
            // 
            this.menuRunExplorer.Text = "Run Explorer";
            this.menuRunExplorer.Click += new System.EventHandler(this.menuRunExplorer_Click);
            // 
            // listboxInfo
            // 
            this.listboxInfo.Location = new System.Drawing.Point(3, 31);
            this.listboxInfo.Name = "listboxInfo";
            this.listboxInfo.Size = new System.Drawing.Size(234, 156);
            this.listboxInfo.TabIndex = 0;
            // 
            // cmdPatch
            // 
            this.cmdPatch.Enabled = false;
            this.cmdPatch.Location = new System.Drawing.Point(3, 193);
            this.cmdPatch.Name = "cmdPatch";
            this.cmdPatch.Size = new System.Drawing.Size(234, 29);
            this.cmdPatch.TabIndex = 1;
            this.cmdPatch.Text = "Patch";
            this.cmdPatch.Click += new System.EventHandler(this.cmdPatch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.cmdPatch);
            this.Controls.Add(this.listboxInfo);
            this.Menu = this.mainMenu;
            this.Name = "Form1";
            this.Text = "ceExplorerPatcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuRunExplorer;
        private System.Windows.Forms.ListBox listboxInfo;
        private System.Windows.Forms.Button cmdPatch;
    }
}

