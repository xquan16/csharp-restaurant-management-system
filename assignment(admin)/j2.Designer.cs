namespace assignment_admin_
{
    partial class AddRfrm
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
            this.Backbtn = new System.Windows.Forms.Button();
            this.CustomerDetailgrp = new System.Windows.Forms.GroupBox();
            this.contactlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountP = new System.Windows.Forms.NumericUpDown();
            this.duration = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Eventtxt = new System.Windows.Forms.Label();
            this.amountlbl = new System.Windows.Forms.Label();
            this.Datetxt = new System.Windows.Forms.Label();
            this.SRequestgrp = new System.Windows.Forms.GroupBox();
            this.ASPlbl = new System.Windows.Forms.Label();
            this.SpecialRtxt = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.CustomerDetailgrp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).BeginInit();
            this.SRequestgrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Backbtn.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Backbtn.Location = new System.Drawing.Point(12, 481);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(80, 33);
            this.Backbtn.TabIndex = 0;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // CustomerDetailgrp
            // 
            this.CustomerDetailgrp.BackColor = System.Drawing.Color.Transparent;
            this.CustomerDetailgrp.Controls.Add(this.contactlbl);
            this.CustomerDetailgrp.Controls.Add(this.Namelbl);
            this.CustomerDetailgrp.Controls.Add(this.txtPhoneNum);
            this.CustomerDetailgrp.Controls.Add(this.Nametxt);
            this.CustomerDetailgrp.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDetailgrp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomerDetailgrp.Location = new System.Drawing.Point(23, 211);
            this.CustomerDetailgrp.Name = "CustomerDetailgrp";
            this.CustomerDetailgrp.Size = new System.Drawing.Size(256, 248);
            this.CustomerDetailgrp.TabIndex = 1;
            this.CustomerDetailgrp.TabStop = false;
            this.CustomerDetailgrp.Text = "Customer Details";
            // 
            // contactlbl
            // 
            this.contactlbl.AutoSize = true;
            this.contactlbl.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactlbl.Location = new System.Drawing.Point(6, 152);
            this.contactlbl.Name = "contactlbl";
            this.contactlbl.Size = new System.Drawing.Size(117, 23);
            this.contactlbl.TabIndex = 5;
            this.contactlbl.Text = "Phone Number: ";
            this.contactlbl.Click += new System.EventHandler(this.contactlbl_Click);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(6, 43);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(75, 30);
            this.Namelbl.TabIndex = 4;
            this.Namelbl.Text = "Name :";
            this.Namelbl.Click += new System.EventHandler(this.Namelbl_Click);
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.Location = new System.Drawing.Point(6, 179);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(244, 30);
            this.txtPhoneNum.TabIndex = 3;
            // 
            // Nametxt
            // 
            this.Nametxt.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nametxt.Location = new System.Drawing.Point(6, 85);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(244, 34);
            this.Nametxt.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboType);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AmountP);
            this.groupBox1.Controls.Add(this.duration);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Controls.Add(this.Eventtxt);
            this.groupBox1.Controls.Add(this.amountlbl);
            this.groupBox1.Controls.Add(this.Datetxt);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(295, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 305);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservation Details";
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Corporate",
            "General",
            "Private Event"});
            this.comboType.Location = new System.Drawing.Point(186, 244);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(152, 34);
            this.comboType.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10:00 AM",
            "11:00 AM",
            "12:00 PM ",
            "1:00 PM",
            "2:00 PM",
            "3:00 PM",
            "4:00 PM",
            "5:00 PM",
            "6:00 PM",
            "7:00 PM",
            "8:00 PM",
            "9:00 PM"});
            this.comboBox1.Location = new System.Drawing.Point(186, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 34);
            this.comboBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Time:";
            // 
            // AmountP
            // 
            this.AmountP.Location = new System.Drawing.Point(286, 193);
            this.AmountP.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.AmountP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountP.Name = "AmountP";
            this.AmountP.Size = new System.Drawing.Size(52, 34);
            this.AmountP.TabIndex = 11;
            this.AmountP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(286, 142);
            this.duration.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.duration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(52, 34);
            this.duration.TabIndex = 6;
            this.duration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Duration of event in hours:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Date
            // 
            this.Date.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.Date.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date.Location = new System.Drawing.Point(6, 46);
            this.Date.MinDate = new System.DateTime(2025, 3, 25, 0, 0, 0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(332, 34);
            this.Date.TabIndex = 9;
            // 
            // Eventtxt
            // 
            this.Eventtxt.AutoSize = true;
            this.Eventtxt.Location = new System.Drawing.Point(7, 247);
            this.Eventtxt.Name = "Eventtxt";
            this.Eventtxt.Size = new System.Drawing.Size(108, 26);
            this.Eventtxt.TabIndex = 8;
            this.Eventtxt.Text = "Event Type :";
            // 
            // amountlbl
            // 
            this.amountlbl.AutoSize = true;
            this.amountlbl.Font = new System.Drawing.Font("Segoe Print", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlbl.Location = new System.Drawing.Point(6, 196);
            this.amountlbl.Name = "amountlbl";
            this.amountlbl.Size = new System.Drawing.Size(187, 31);
            this.amountlbl.TabIndex = 7;
            this.amountlbl.Text = "Amount of people :";
            this.amountlbl.Click += new System.EventHandler(this.amountlbl_Click);
            // 
            // Datetxt
            // 
            this.Datetxt.AutoSize = true;
            this.Datetxt.Location = new System.Drawing.Point(233, 18);
            this.Datetxt.Name = "Datetxt";
            this.Datetxt.Size = new System.Drawing.Size(105, 26);
            this.Datetxt.TabIndex = 6;
            this.Datetxt.Text = "Arrival date";
            this.Datetxt.Click += new System.EventHandler(this.Datetxt_Click);
            // 
            // SRequestgrp
            // 
            this.SRequestgrp.BackColor = System.Drawing.Color.Transparent;
            this.SRequestgrp.Controls.Add(this.ASPlbl);
            this.SRequestgrp.Controls.Add(this.SpecialRtxt);
            this.SRequestgrp.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRequestgrp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SRequestgrp.Location = new System.Drawing.Point(657, 9);
            this.SRequestgrp.Name = "SRequestgrp";
            this.SRequestgrp.Size = new System.Drawing.Size(224, 146);
            this.SRequestgrp.TabIndex = 4;
            this.SRequestgrp.TabStop = false;
            this.SRequestgrp.Text = "Request";
            // 
            // ASPlbl
            // 
            this.ASPlbl.AutoSize = true;
            this.ASPlbl.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASPlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ASPlbl.Location = new System.Drawing.Point(6, 34);
            this.ASPlbl.Name = "ASPlbl";
            this.ASPlbl.Size = new System.Drawing.Size(177, 46);
            this.ASPlbl.TabIndex = 6;
            this.ASPlbl.Text = "Add special request:\r\n(Type None if no request)\r\n";
            this.ASPlbl.Click += new System.EventHandler(this.ASPlbl_Click);
            // 
            // SpecialRtxt
            // 
            this.SpecialRtxt.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialRtxt.Location = new System.Drawing.Point(6, 98);
            this.SpecialRtxt.Name = "SpecialRtxt";
            this.SpecialRtxt.Size = new System.Drawing.Size(209, 30);
            this.SpecialRtxt.TabIndex = 6;
            this.SpecialRtxt.Text = "none";
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Savebtn.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.Location = new System.Drawing.Point(817, 481);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(79, 33);
            this.Savebtn.TabIndex = 5;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // AddRfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::assignment_admin_.Properties.Resources.reserved_sign_on_restaurant_table_534761709_d4ef78d8a57743429658561abb9f615e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 526);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.SRequestgrp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CustomerDetailgrp);
            this.Controls.Add(this.Backbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddRfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Reservation";
            this.Load += new System.EventHandler(this.AddRfrm_Load);
            this.CustomerDetailgrp.ResumeLayout(false);
            this.CustomerDetailgrp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).EndInit();
            this.SRequestgrp.ResumeLayout(false);
            this.SRequestgrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.GroupBox CustomerDetailgrp;
        private System.Windows.Forms.Label contactlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label Eventtxt;
        private System.Windows.Forms.Label Datetxt;
        private System.Windows.Forms.GroupBox SRequestgrp;
        private System.Windows.Forms.Label ASPlbl;
        private System.Windows.Forms.TextBox SpecialRtxt;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Label amountlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown duration;
        private System.Windows.Forms.NumericUpDown AmountP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboType;
    }
}