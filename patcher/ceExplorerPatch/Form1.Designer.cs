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
            this.listboxInfo = new System.Windows.Forms.ListBox();
            this.cmdPatch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listboxInfo
            // 
            this.listboxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listboxInfo.Location = new System.Drawing.Point(3, 3);
            this.listboxInfo.Name = "listboxInfo";
            this.listboxInfo.Size = new System.Drawing.Size(234, 100);
            this.listboxInfo.TabIndex = 0;
            // 
            // cmdPatch
            // 
            this.cmdPatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPatch.Enabled = false;
            this.cmdPatch.Location = new System.Drawing.Point(13, 123);
            this.cmdPatch.Name = "cmdPatch";
            this.cmdPatch.Size = new System.Drawing.Size(211, 29);
            this.cmdPatch.TabIndex = 1;
            this.cmdPatch.Text = "Patch";
            this.cmdPatch.Click += new System.EventHandler(this.cmdPatch_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(0, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 27);
            this.label3.Text = "USE THIS SOFTWARE ON YOUR OWN RISK!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 27);
            this.label2.Text = "Instructions: http://code.google.com/p/navisharp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdPatch);
            this.Controls.Add(this.listboxInfo);
            this.Name = "Form1";
            this.Text = "NaviSharp Patcher 0.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxInfo;
        private System.Windows.Forms.Button cmdPatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

