namespace BookShop_shenuLogin
{
    partial class welcome
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
            this.videoPlayerWinForm1 = new CSVideoPlayer.VideoPlayerWinForm();
            this.SuspendLayout();
            // 
            // videoPlayerWinForm1
            // 
            this.videoPlayerWinForm1.BackColor = System.Drawing.Color.Black;
            this.videoPlayerWinForm1.FFmpegLibsPath = "";
            this.videoPlayerWinForm1.Location = new System.Drawing.Point(1, 1);
            this.videoPlayerWinForm1.Name = "videoPlayerWinForm1";
            this.videoPlayerWinForm1.Size = new System.Drawing.Size(798, 446);
            this.videoPlayerWinForm1.TabIndex = 0;
            this.videoPlayerWinForm1.UserKey = "Your registration key";
            this.videoPlayerWinForm1.UserName = "Your email";
            this.videoPlayerWinForm1.Load += new System.EventHandler(this.videoPlayerWinForm1_Load);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.videoPlayerWinForm1);
            this.Name = "welcome";
            this.Text = "welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private CSVideoPlayer.VideoPlayerWinForm videoPlayerWinForm1;
    }
}