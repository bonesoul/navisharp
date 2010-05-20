namespace NaviSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.background = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.picBattery = new System.Windows.Forms.PictureBox();
            this.battery_images = new System.Windows.Forms.ImageList();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(472, 228);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.picBattery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 43);
            // 
            // labelTime
            // 
            this.labelTime.ForeColor = System.Drawing.Color.Silver;
            this.labelTime.Location = new System.Drawing.Point(371, 11);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(58, 22);
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picBattery
            // 
            this.picBattery.Location = new System.Drawing.Point(435, 5);
            this.picBattery.Name = "picBattery";
            this.picBattery.Size = new System.Drawing.Size(32, 32);
            this.picBattery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBattery.Click += new System.EventHandler(this.picBattery_Click);
            // 
            // battery_images
            // 
            this.battery_images.ImageSize = new System.Drawing.Size(32, 32);
            this.battery_images.Images.Clear();
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource1"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource2"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource3"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource4"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource5"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource6"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource7"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource8"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource9"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource10"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource11"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource12"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource13"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource14"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource15"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource16"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource17"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource18"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource19"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource20"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource21"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource22"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource23"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource24"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource25"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource26"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource27"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource28"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource29"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource30"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource31"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource32"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource33"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource34"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource35"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource36"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource37"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource38"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource39"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource40"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource41"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource42"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource43"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource44"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource45"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource46"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource47"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource48"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource49"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource50"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource51"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource52"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource53"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource54"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource55"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource56"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource57"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource58"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource59"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource60"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource61"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource62"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource63"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource64"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource65"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource66"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource67"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource68"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource69"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource70"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource71"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource72"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource73"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource74"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource75"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource76"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource77"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource78"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource79"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource80"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource81"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource82"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource83"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource84"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource85"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource86"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource87"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource88"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource89"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource90"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource91"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource92"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource93"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource94"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource95"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource96"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource97"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource98"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource99"))));
            this.battery_images.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource100"))));
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(472, 272);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "NaviSharp";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList battery_images;
        private System.Windows.Forms.PictureBox picBattery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTime;
    }
}

