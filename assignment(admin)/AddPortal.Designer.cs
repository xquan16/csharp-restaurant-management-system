namespace assignment_admin_
{
    partial class AddPortal
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.backMU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(89, 47);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(106, 25);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "MemberID:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Palatino Linotype", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(89, 132);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(90, 23);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(89, 207);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(225, 47);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(284, 22);
            this.txtMemberID.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(225, 134);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(284, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(225, 210);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(284, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(89, 284);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(56, 25);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Role:";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(225, 287);
            this.txtRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(284, 22);
            this.txtRole.TabIndex = 7;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(557, 156);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(123, 41);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // backMU
            // 
            this.backMU.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backMU.BackgroundImage = global::assignment_admin_.Properties.Resources.back;
            this.backMU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backMU.Location = new System.Drawing.Point(12, 10);
            this.backMU.Name = "backMU";
            this.backMU.Size = new System.Drawing.Size(50, 50);
            this.backMU.TabIndex = 9;
            this.backMU.UseVisualStyleBackColor = false;
            this.backMU.Click += new System.EventHandler(this.backMU_Click);
            // 
            // AddPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::assignment_admin_.Properties.Resources.pngtree_abstract_dark_background_with_empty_space_portal_image_15684454;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.backMU);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPortal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button backMU;
    }
}