namespace Clock
{
    partial class TimeNow
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
            this.L_Time = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_Time
            // 
            this.L_Time.AccessibleName = "L_Time";
            this.L_Time.AutoSize = true;
            this.L_Time.Font = new System.Drawing.Font("DS-Digital", 40F);
            this.L_Time.Location = new System.Drawing.Point(69, 40);
            this.L_Time.Name = "L_Time";
            this.L_Time.Size = new System.Drawing.Size(173, 53);
            this.L_Time.TabIndex = 0;
            this.L_Time.Text = "label1";
            this.L_Time.Click += new System.EventHandler(this.L_Time_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(265, 117);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // TimeNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 152);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.L_Time);
            this.Name = "TimeNow";
            this.Text = "TimeNow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Time;
        private System.Windows.Forms.Button btn_Refresh;
    }
}