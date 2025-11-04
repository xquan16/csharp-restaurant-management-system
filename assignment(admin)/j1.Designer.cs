namespace assignment_admin_
{
    partial class reservationfrm
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
            this.reservationlbl = new System.Windows.Forms.Label();
            this.MRgrp = new System.Windows.Forms.GroupBox();
            this.Editbtn = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.requestgrp = new System.Windows.Forms.GroupBox();
            this.Viewbtn = new System.Windows.Forms.Button();
            this.Profilegrp = new System.Windows.Forms.GroupBox();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MRgrp.SuspendLayout();
            this.requestgrp.SuspendLayout();
            this.Profilegrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservationlbl
            // 
            this.reservationlbl.AutoSize = true;
            this.reservationlbl.BackColor = System.Drawing.Color.Transparent;
            this.reservationlbl.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reservationlbl.Location = new System.Drawing.Point(301, 9);
            this.reservationlbl.Name = "reservationlbl";
            this.reservationlbl.Size = new System.Drawing.Size(262, 71);
            this.reservationlbl.TabIndex = 0;
            this.reservationlbl.Text = "Reservation";
            // 
            // MRgrp
            // 
            this.MRgrp.BackColor = System.Drawing.Color.Transparent;
            this.MRgrp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MRgrp.Controls.Add(this.Editbtn);
            this.MRgrp.Controls.Add(this.btnCreate);
            this.MRgrp.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRgrp.ForeColor = System.Drawing.Color.Black;
            this.MRgrp.Location = new System.Drawing.Point(300, 174);
            this.MRgrp.Name = "MRgrp";
            this.MRgrp.Size = new System.Drawing.Size(263, 210);
            this.MRgrp.TabIndex = 1;
            this.MRgrp.TabStop = false;
            this.MRgrp.Text = "Manage Reservation";
            // 
            // Editbtn
            // 
            this.Editbtn.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Editbtn.Location = new System.Drawing.Point(94, 132);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(87, 36);
            this.Editbtn.TabIndex = 1;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreate.Location = new System.Drawing.Point(94, 65);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(87, 36);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create New";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // requestgrp
            // 
            this.requestgrp.BackColor = System.Drawing.Color.Transparent;
            this.requestgrp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.requestgrp.Controls.Add(this.Viewbtn);
            this.requestgrp.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestgrp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.requestgrp.Location = new System.Drawing.Point(12, 216);
            this.requestgrp.Name = "requestgrp";
            this.requestgrp.Size = new System.Drawing.Size(238, 168);
            this.requestgrp.TabIndex = 3;
            this.requestgrp.TabStop = false;
            this.requestgrp.Text = "Request";
            // 
            // Viewbtn
            // 
            this.Viewbtn.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Viewbtn.Location = new System.Drawing.Point(72, 75);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(87, 36);
            this.Viewbtn.TabIndex = 1;
            this.Viewbtn.Text = "View";
            this.Viewbtn.UseVisualStyleBackColor = true;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click);
            // 
            // Profilegrp
            // 
            this.Profilegrp.BackColor = System.Drawing.Color.Transparent;
            this.Profilegrp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Profilegrp.Controls.Add(this.Updatebtn);
            this.Profilegrp.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profilegrp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Profilegrp.Location = new System.Drawing.Point(613, 174);
            this.Profilegrp.Name = "Profilegrp";
            this.Profilegrp.Size = new System.Drawing.Size(235, 153);
            this.Profilegrp.TabIndex = 3;
            this.Profilegrp.TabStop = false;
            this.Profilegrp.Text = "Manage Profile";
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Updatebtn.Location = new System.Drawing.Point(74, 65);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(87, 36);
            this.Updatebtn.TabIndex = 1;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::assignment_admin_.Properties.Resources.lg__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(818, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reservationfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::assignment_admin_.Properties.Resources.reserved_sign_on_restaurant_table_534761709_d4ef78d8a57743429658561abb9f615e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Profilegrp);
            this.Controls.Add(this.requestgrp);
            this.Controls.Add(this.MRgrp);
            this.Controls.Add(this.reservationlbl);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "reservationfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Coordinator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MRgrp.ResumeLayout(false);
            this.requestgrp.ResumeLayout(false);
            this.Profilegrp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reservationlbl;
        private System.Windows.Forms.GroupBox MRgrp;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox requestgrp;
        private System.Windows.Forms.Button Viewbtn;
        private System.Windows.Forms.GroupBox Profilegrp;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button button1;
    }
}

