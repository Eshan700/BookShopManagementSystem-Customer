namespace BookShop_shenuLogin
{
    partial class formSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSignup));
            this.panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkShowpass = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConpass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.chkShowpass);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txtConpass);
            this.panel.Controls.Add(this.txtPass);
            this.panel.Controls.Add(this.txtUsername);
            this.panel.Controls.Add(this.btnClear);
            this.panel.Controls.Add(this.btnSignup);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label3);
            this.panel.Location = new System.Drawing.Point(219, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(421, 488);
            this.panel.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(185, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Back to Login";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Already Have an Account";
            // 
            // chkShowpass
            // 
            this.chkShowpass.AutoSize = true;
            this.chkShowpass.BackColor = System.Drawing.Color.RoyalBlue;
            this.chkShowpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkShowpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowpass.Location = new System.Drawing.Point(307, 293);
            this.chkShowpass.Name = "chkShowpass";
            this.chkShowpass.Size = new System.Drawing.Size(111, 19);
            this.chkShowpass.TabIndex = 1;
            this.chkShowpass.Text = "Show Password";
            this.chkShowpass.UseVisualStyleBackColor = false;
            this.chkShowpass.CheckedChanged += new System.EventHandler(this.chkShowpass_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(44, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password";
            // 
            // txtConpass
            // 
            this.txtConpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtConpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConpass.Location = new System.Drawing.Point(67, 261);
            this.txtConpass.Multiline = true;
            this.txtConpass.Name = "txtConpass";
            this.txtConpass.PasswordChar = '•';
            this.txtConpass.Size = new System.Drawing.Size(241, 26);
            this.txtConpass.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Location = new System.Drawing.Point(67, 174);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(241, 26);
            this.txtPass.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(67, 91);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(241, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnClear.Location = new System.Drawing.Point(48, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(354, 39);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSignup.Location = new System.Drawing.Point(48, 320);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(354, 39);
            this.btnSignup.TabIndex = 1;
            this.btnSignup.Text = "Signup";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(140, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Signup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(44, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(44, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // formSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 503);
            this.Controls.Add(this.panel);
            this.Location = new System.Drawing.Point(1, 1);
            this.Name = "formSignup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConpass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkShowpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
    }
}

