namespace Clock
{
    partial class Timer_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer_Form));
            this.Start_Timer = new System.Windows.Forms.Button();
            this.txt_Min = new System.Windows.Forms.TextBox();
            this.txt_Sec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_Timer
            // 
            this.Start_Timer.BackColor = System.Drawing.Color.Transparent;
            this.Start_Timer.Font = new System.Drawing.Font("Oswald Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Timer.ForeColor = System.Drawing.Color.DarkRed;
            this.Start_Timer.Location = new System.Drawing.Point(203, 381);
            this.Start_Timer.Name = "Start_Timer";
            this.Start_Timer.Size = new System.Drawing.Size(123, 47);
            this.Start_Timer.TabIndex = 3;
            this.Start_Timer.Text = "Start";
            this.Start_Timer.UseVisualStyleBackColor = false;
            this.Start_Timer.Click += new System.EventHandler(this.Start_Timer_Click);
            // 
            // txt_Min
            // 
            this.txt_Min.BackColor = System.Drawing.Color.SlateGray;
            this.txt_Min.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Min.Font = new System.Drawing.Font("Oswald Regular", 42F);
            this.txt_Min.Location = new System.Drawing.Point(122, 240);
            this.txt_Min.Multiline = true;
            this.txt_Min.Name = "txt_Min";
            this.txt_Min.Size = new System.Drawing.Size(128, 88);
            this.txt_Min.TabIndex = 5;
            this.txt_Min.Text = "00";
            this.txt_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Sec
            // 
            this.txt_Sec.BackColor = System.Drawing.Color.SlateGray;
            this.txt_Sec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Sec.Font = new System.Drawing.Font("Oswald Regular", 42F);
            this.txt_Sec.Location = new System.Drawing.Point(280, 240);
            this.txt_Sec.Multiline = true;
            this.txt_Sec.Name = "txt_Sec";
            this.txt_Sec.Size = new System.Drawing.Size(128, 88);
            this.txt_Sec.TabIndex = 6;
            this.txt_Sec.Text = "00";
            this.txt_Sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald Regular", 42F);
            this.label1.Location = new System.Drawing.Point(190, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 76);
            this.label1.TabIndex = 7;
            this.label1.Text = "TIMER";
            // 
            // Timer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(530, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Sec);
            this.Controls.Add(this.txt_Min);
            this.Controls.Add(this.Start_Timer);
            this.DoubleBuffered = true;
            this.Name = "Timer_Form";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Timer;
        private System.Windows.Forms.TextBox txt_Min;
        private System.Windows.Forms.TextBox txt_Sec;
        private System.Windows.Forms.Label label1;
    }
}

