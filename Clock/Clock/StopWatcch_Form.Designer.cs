namespace Clock
{
    partial class StopWatch_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopWatch_Form));
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.L_S = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_M = new System.Windows.Forms.Label();
            this.L_H = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.L_MS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(54, 176);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(220, 176);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(75, 23);
            this.btn_Pause.TabIndex = 1;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(358, 176);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // L_S
            // 
            this.L_S.AutoSize = true;
            this.L_S.BackColor = System.Drawing.Color.Transparent;
            this.L_S.Font = new System.Drawing.Font("DS-Digital", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_S.Location = new System.Drawing.Point(265, 48);
            this.L_S.Name = "L_S";
            this.L_S.Size = new System.Drawing.Size(96, 66);
            this.L_S.TabIndex = 6;
            this.L_S.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 54);
            this.label2.TabIndex = 9;
            this.label2.Text = ":";
            // 
            // L_M
            // 
            this.L_M.AutoSize = true;
            this.L_M.BackColor = System.Drawing.Color.Transparent;
            this.L_M.Font = new System.Drawing.Font("DS-Digital", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_M.Location = new System.Drawing.Point(145, 48);
            this.L_M.Name = "L_M";
            this.L_M.Size = new System.Drawing.Size(96, 66);
            this.L_M.TabIndex = 8;
            this.L_M.Text = "00";
            // 
            // L_H
            // 
            this.L_H.AutoSize = true;
            this.L_H.BackColor = System.Drawing.Color.Transparent;
            this.L_H.Font = new System.Drawing.Font("DS-Digital", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_H.Location = new System.Drawing.Point(23, 48);
            this.L_H.Name = "L_H";
            this.L_H.Size = new System.Drawing.Size(96, 66);
            this.L_H.TabIndex = 10;
            this.L_H.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 54);
            this.label3.TabIndex = 12;
            this.label3.Text = ":";
            // 
            // L_MS
            // 
            this.L_MS.AutoSize = true;
            this.L_MS.BackColor = System.Drawing.Color.Transparent;
            this.L_MS.Font = new System.Drawing.Font("DS-Digital", 50F);
            this.L_MS.Location = new System.Drawing.Point(379, 48);
            this.L_MS.Name = "L_MS";
            this.L_MS.Size = new System.Drawing.Size(96, 66);
            this.L_MS.TabIndex = 11;
            this.L_MS.Text = "00";
            // 
            // StopWatch_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.L_MS);
            this.Controls.Add(this.L_H);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_M);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_S);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StopWatch_Form";
            this.Text = "StopWatch";
            this.Load += new System.EventHandler(this.StopWatch_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label L_S;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_M;
        private System.Windows.Forms.Label L_H;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_MS;
    }
}