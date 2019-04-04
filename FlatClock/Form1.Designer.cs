namespace FlatClock
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
            this.components = new System.ComponentModel.Container();
            this.Clock = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clock
            // 
            this.Clock.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Clock.AnimationSpeed = 500;
            this.Clock.BackColor = System.Drawing.Color.Transparent;
            this.Clock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27F);
            this.Clock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.Clock.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.Clock.InnerMargin = 2;
            this.Clock.InnerWidth = -1;
            this.Clock.Location = new System.Drawing.Point(12, 0);
            this.Clock.MarqueeAnimationSpeed = 2000;
            this.Clock.Maximum = 60;
            this.Clock.Minimum = 1;
            this.Clock.Name = "Clock";
            this.Clock.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(115)))), ((int)(((byte)(142)))));
            this.Clock.OuterMargin = -25;
            this.Clock.OuterWidth = 26;
            this.Clock.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
            this.Clock.ProgressWidth = 25;
            this.Clock.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Clock.Size = new System.Drawing.Size(256, 241);
            this.Clock.StartAngle = 270;
            this.Clock.Step = 1;
            this.Clock.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Clock.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Clock.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Clock.SubscriptText = "";
            this.Clock.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Clock.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Clock.SuperscriptText = "13";
            this.Clock.TabIndex = 0;
            this.Clock.Text = "22:15";
            this.Clock.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Clock.Value = 50;
            this.Clock.Click += new System.EventHandler(this.Clock_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tag = "Tick";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(130)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(278, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Clock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar Clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

