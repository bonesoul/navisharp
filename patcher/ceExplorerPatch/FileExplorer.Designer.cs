namespace ceExplorerPatch
{
    partial class FileExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu menu;

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
            this.menu = new System.Windows.Forms.MainMenu();
            this.FSView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // FSView
            // 
            this.FSView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FSView.Location = new System.Drawing.Point(0, 0);
            this.FSView.Name = "FSView";
            this.FSView.Size = new System.Drawing.Size(240, 268);
            this.FSView.TabIndex = 0;
            this.FSView.View = System.Windows.Forms.View.List;
            this.FSView.ItemActivate += new System.EventHandler(this.FSView_ItemActivate);
            // 
            // FileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.FSView);
            this.Menu = this.menu;
            this.Name = "FileExplorer";
            this.Text = "FileExplorer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView FSView;

    }
}