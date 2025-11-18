namespace assignment_admin_
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblGenerat = new System.Windows.Forms.Label();
            this.visible = new System.Windows.Forms.Button();
            this.invisible = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(399, 293);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(190, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(399, 225);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(190, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(349, 372);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 38);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPassword.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(250, 291);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(113, 26);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUsername.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(246, 223);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(117, 26);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username:";
            // 
            // lblGenerat
            // 
            this.lblGenerat.AutoSize = true;
            this.lblGenerat.BackColor = System.Drawing.Color.Transparent;
            this.lblGenerat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGenerat.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerat.ForeColor = System.Drawing.Color.Red;
            this.lblGenerat.Location = new System.Drawing.Point(246, 123);
            this.lblGenerat.Name = "lblGenerat";
            this.lblGenerat.Size = new System.Drawing.Size(363, 54);
            this.lblGenerat.TabIndex = 6;
            this.lblGenerat.Text = "🍣 ApexOn Sushi";
            // 
            // visible
            // 
            this.visible.BackColor = System.Drawing.Color.White;
            this.visible.BackgroundImage = global::assignment_admin_.Properties.Resources.visibility__1_;
            this.visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.visible.Enabled = false;
            this.visible.FlatAppearance.BorderSize = 0;
            this.visible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visible.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.visible.Location = new System.Drawing.Point(555, 296);
            this.visible.Name = "visible";
            this.visible.Size = new System.Drawing.Size(30, 21);
            this.visible.TabIndex = 14;
            this.visible.UseVisualStyleBackColor = false;
            this.visible.Visible = false;
            this.visible.Click += new System.EventHandler(this.visible_Click);
            // 
            // invisible
            // 
            this.invisible.BackColor = System.Drawing.Color.White;
            this.invisible.BackgroundImage = global::assignment_admin_.Properties.Resources.visible__1_;
            this.invisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.invisible.Enabled = false;
            this.invisible.FlatAppearance.BorderSize = 0;
            this.invisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invisible.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.invisible.Location = new System.Drawing.Point(555, 296);
            this.invisible.Name = "invisible";
            this.invisible.Size = new System.Drawing.Size(30, 22);
            this.invisible.TabIndex = 15;
            this.invisible.UseVisualStyleBackColor = false;
            this.invisible.Visible = false;
            this.invisible.Click += new System.EventHandler(this.invisible_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(864, 523);
            this.Controls.Add(this.visible);
            this.Controls.Add(this.invisible);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblGenerat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblGenerat;
        private System.Windows.Forms.Button visible;
        private System.Windows.Forms.Button invisible;
    }
}

