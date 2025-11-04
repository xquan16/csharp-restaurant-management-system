namespace assignment_admin_
{
    partial class EditPortal
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.backMU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Niagara Solid", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(503, 298);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(196, 41);
            this.btnEnter.TabIndex = 15;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click_1);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(200, 234);
            this.txtRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(288, 22);
            this.txtRole.TabIndex = 14;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Niagara Solid", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(98, 232);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(45, 26);
            this.lblRole.TabIndex = 13;
            this.lblRole.Text = "Role:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(204, 148);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(284, 22);
            this.txtPassword.TabIndex = 12;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(204, 75);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(284, 22);
            this.txtUsername.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Niagara Solid", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(98, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 22);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Niagara Solid", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(98, 78);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(73, 22);
            this.lblusername.TabIndex = 9;
            this.lblusername.Text = "Username:";
            // 
            // backMU
            // 
            this.backMU.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backMU.BackgroundImage = global::assignment_admin_.Properties.Resources.back;
            this.backMU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backMU.Location = new System.Drawing.Point(12, 12);
            this.backMU.Name = "backMU";
            this.backMU.Size = new System.Drawing.Size(50, 50);
            this.backMU.TabIndex = 16;
            this.backMU.UseVisualStyleBackColor = false;
            this.backMU.Click += new System.EventHandler(this.backMU_Click);
            // 
            // EditPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::assignment_admin_.Properties.Resources.pngtree_futuristic_shape_abstract_background_chemistry_technology_concept_for_website_image_438818;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.backMU);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblusername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPortal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button backMU;
    }
}