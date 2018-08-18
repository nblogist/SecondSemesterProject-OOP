namespace Clock
{
    partial class Clock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock));
            this.Image_Timer = new System.Windows.Forms.PictureBox();
            this.Image_Clock = new System.Windows.Forms.PictureBox();
            this.App_Title = new System.Windows.Forms.Label();
            this.Image_StopWatch = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Clock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_StopWatch)).BeginInit();
            this.SuspendLayout();
            // 
            // Image_Timer
            // 
            this.Image_Timer.BackColor = System.Drawing.Color.Transparent;
            this.Image_Timer.Image = ((System.Drawing.Image)(resources.GetObject("Image_Timer.Image")));
            this.Image_Timer.Location = new System.Drawing.Point(250, 64);
            this.Image_Timer.Name = "Image_Timer";
            this.Image_Timer.Size = new System.Drawing.Size(156, 139);
            this.Image_Timer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_Timer.TabIndex = 1;
            this.Image_Timer.TabStop = false;
            this.Image_Timer.Click += new System.EventHandler(this.Image_Timer_Click);
            // 
            // Image_Clock
            // 
            this.Image_Clock.BackColor = System.Drawing.Color.Transparent;
            this.Image_Clock.Image = ((System.Drawing.Image)(resources.GetObject("Image_Clock.Image")));
            this.Image_Clock.Location = new System.Drawing.Point(12, 64);
            this.Image_Clock.Name = "Image_Clock";
            this.Image_Clock.Size = new System.Drawing.Size(156, 139);
            this.Image_Clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_Clock.TabIndex = 2;
            this.Image_Clock.TabStop = false;
            this.Image_Clock.Click += new System.EventHandler(this.Image_Clock_Click);
            // 
            // App_Title
            // 
            this.App_Title.AutoSize = true;
            this.App_Title.BackColor = System.Drawing.Color.Transparent;
            this.App_Title.Font = new System.Drawing.Font("Oswald Regular", 25F);
            this.App_Title.Location = new System.Drawing.Point(167, 9);
            this.App_Title.Name = "App_Title";
            this.App_Title.Size = new System.Drawing.Size(102, 46);
            this.App_Title.TabIndex = 3;
            this.App_Title.Text = "CLOCK";
            // 
            // Image_StopWatch
            // 
            this.Image_StopWatch.BackColor = System.Drawing.Color.Transparent;
            this.Image_StopWatch.Image = ((System.Drawing.Image)(resources.GetObject("Image_StopWatch.Image")));
            this.Image_StopWatch.Location = new System.Drawing.Point(12, 249);
            this.Image_StopWatch.Name = "Image_StopWatch";
            this.Image_StopWatch.Size = new System.Drawing.Size(156, 139);
            this.Image_StopWatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_StopWatch.TabIndex = 4;
            this.Image_StopWatch.TabStop = false;
            this.Image_StopWatch.Click += new System.EventHandler(this.Image_StopWatch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(250, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 224);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.Panel_TimeSpan_Click);
            // 
            // Clock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(437, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Image_StopWatch);
            this.Controls.Add(this.App_Title);
            this.Controls.Add(this.Image_Clock);
            this.Controls.Add(this.Image_Timer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Clock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clock";
            ((System.ComponentModel.ISupportInitialize)(this.Image_Timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Clock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_StopWatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Image_Timer;
        private System.Windows.Forms.PictureBox Image_Clock;
        private System.Windows.Forms.Label App_Title;
        private System.Windows.Forms.PictureBox Image_StopWatch;
        private System.Windows.Forms.Panel panel1;
    }
}