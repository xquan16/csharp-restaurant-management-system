namespace assignment
{
    partial class inventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iibtnback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addpanel = new System.Windows.Forms.Panel();
            this.btaback = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbaprice = new System.Windows.Forms.TextBox();
            this.tbaquantity = new System.Windows.Forms.TextBox();
            this.tbaname = new System.Windows.Forms.TextBox();
            this.adddone = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editpanel = new System.Windows.Forms.Panel();
            this.bteback = new System.Windows.Forms.Button();
            this.tbedone = new System.Windows.Forms.Button();
            this.tbename = new System.Windows.Forms.TextBox();
            this.tbeprice = new System.Windows.Forms.TextBox();
            this.tbequantity = new System.Windows.Forms.TextBox();
            this.tbeid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.deletepanel = new System.Windows.Forms.Panel();
            this.btdback = new System.Windows.Forms.Button();
            this.tbddone = new System.Windows.Forms.Button();
            this.tbdid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.addpanel.SuspendLayout();
            this.editpanel.SuspendLayout();
            this.deletepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 291);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iibtnback);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 508);
            this.panel1.TabIndex = 7;
            // 
            // iibtnback
            // 
            this.iibtnback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iibtnback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iibtnback.Location = new System.Drawing.Point(279, 448);
            this.iibtnback.Name = "iibtnback";
            this.iibtnback.Size = new System.Drawing.Size(194, 39);
            this.iibtnback.TabIndex = 11;
            this.iibtnback.Text = "Back to Main page";
            this.iibtnback.UseVisualStyleBackColor = false;
            this.iibtnback.Click += new System.EventHandler(this.iibtnback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingredient Inventory";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btndelete.Location = new System.Drawing.Point(568, 393);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(110, 43);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnedit.Location = new System.Drawing.Point(319, 393);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(110, 43);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnadd.Location = new System.Drawing.Point(46, 393);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(110, 43);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID :";
            // 
            // addpanel
            // 
            this.addpanel.Controls.Add(this.btaback);
            this.addpanel.Controls.Add(this.label6);
            this.addpanel.Controls.Add(this.tbaprice);
            this.addpanel.Controls.Add(this.tbaquantity);
            this.addpanel.Controls.Add(this.tbaname);
            this.addpanel.Controls.Add(this.adddone);
            this.addpanel.Controls.Add(this.label5);
            this.addpanel.Controls.Add(this.label4);
            this.addpanel.Controls.Add(this.label3);
            this.addpanel.Location = new System.Drawing.Point(-2, -1);
            this.addpanel.Name = "addpanel";
            this.addpanel.Size = new System.Drawing.Size(801, 511);
            this.addpanel.TabIndex = 10;
            this.addpanel.Visible = false;
            // 
            // btaback
            // 
            this.btaback.BackColor = System.Drawing.SystemColors.Info;
            this.btaback.Location = new System.Drawing.Point(15, 23);
            this.btaback.Name = "btaback";
            this.btaback.Size = new System.Drawing.Size(116, 51);
            this.btaback.TabIndex = 9;
            this.btaback.Text = "back to inventory";
            this.btaback.UseVisualStyleBackColor = false;
            this.btaback.Click += new System.EventHandler(this.btaback_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 51);
            this.label6.TabIndex = 8;
            this.label6.Text = "ADD PAGE";
            // 
            // tbaprice
            // 
            this.tbaprice.Location = new System.Drawing.Point(261, 272);
            this.tbaprice.Name = "tbaprice";
            this.tbaprice.Size = new System.Drawing.Size(295, 22);
            this.tbaprice.TabIndex = 7;
            this.tbaprice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // tbaquantity
            // 
            this.tbaquantity.Location = new System.Drawing.Point(261, 216);
            this.tbaquantity.Name = "tbaquantity";
            this.tbaquantity.Size = new System.Drawing.Size(295, 22);
            this.tbaquantity.TabIndex = 6;
            // 
            // tbaname
            // 
            this.tbaname.Location = new System.Drawing.Point(259, 163);
            this.tbaname.Name = "tbaname";
            this.tbaname.Size = new System.Drawing.Size(295, 22);
            this.tbaname.TabIndex = 5;
            // 
            // adddone
            // 
            this.adddone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adddone.Location = new System.Drawing.Point(246, 321);
            this.adddone.Name = "adddone";
            this.adddone.Size = new System.Drawing.Size(276, 69);
            this.adddone.TabIndex = 4;
            this.adddone.Text = "Done";
            this.adddone.UseVisualStyleBackColor = false;
            this.adddone.Click += new System.EventHandler(this.adddone_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // editpanel
            // 
            this.editpanel.Controls.Add(this.bteback);
            this.editpanel.Controls.Add(this.tbedone);
            this.editpanel.Controls.Add(this.tbename);
            this.editpanel.Controls.Add(this.tbeprice);
            this.editpanel.Controls.Add(this.tbequantity);
            this.editpanel.Controls.Add(this.tbeid);
            this.editpanel.Controls.Add(this.label11);
            this.editpanel.Controls.Add(this.label10);
            this.editpanel.Controls.Add(this.label9);
            this.editpanel.Controls.Add(this.label8);
            this.editpanel.Controls.Add(this.label7);
            this.editpanel.Location = new System.Drawing.Point(0, 0);
            this.editpanel.Name = "editpanel";
            this.editpanel.Size = new System.Drawing.Size(795, 511);
            this.editpanel.TabIndex = 9;
            this.editpanel.Visible = false;
            // 
            // bteback
            // 
            this.bteback.BackColor = System.Drawing.SystemColors.Info;
            this.bteback.Location = new System.Drawing.Point(31, 37);
            this.bteback.Name = "bteback";
            this.bteback.Size = new System.Drawing.Size(177, 36);
            this.bteback.TabIndex = 10;
            this.bteback.Text = "back to inventory";
            this.bteback.UseVisualStyleBackColor = false;
            this.bteback.Click += new System.EventHandler(this.bteback_Click);
            // 
            // tbedone
            // 
            this.tbedone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbedone.Location = new System.Drawing.Point(285, 389);
            this.tbedone.Name = "tbedone";
            this.tbedone.Size = new System.Drawing.Size(183, 56);
            this.tbedone.TabIndex = 9;
            this.tbedone.Text = "Done";
            this.tbedone.UseVisualStyleBackColor = false;
            this.tbedone.Click += new System.EventHandler(this.tbedone_Click);
            // 
            // tbename
            // 
            this.tbename.Location = new System.Drawing.Point(317, 191);
            this.tbename.Name = "tbename";
            this.tbename.Size = new System.Drawing.Size(305, 22);
            this.tbename.TabIndex = 8;
            // 
            // tbeprice
            // 
            this.tbeprice.Location = new System.Drawing.Point(317, 296);
            this.tbeprice.Name = "tbeprice";
            this.tbeprice.Size = new System.Drawing.Size(305, 22);
            this.tbeprice.TabIndex = 7;
            // 
            // tbequantity
            // 
            this.tbequantity.Location = new System.Drawing.Point(317, 243);
            this.tbequantity.Name = "tbequantity";
            this.tbequantity.Size = new System.Drawing.Size(305, 22);
            this.tbequantity.TabIndex = 6;
            // 
            // tbeid
            // 
            this.tbeid.Location = new System.Drawing.Point(317, 143);
            this.tbeid.Name = "tbeid";
            this.tbeid.Size = new System.Drawing.Size(305, 22);
            this.tbeid.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(166, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "New Price(RM) :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(166, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "New quantity :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(166, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "New Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(166, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 51);
            this.label7.TabIndex = 0;
            this.label7.Text = "Edit Page";
            // 
            // deletepanel
            // 
            this.deletepanel.Controls.Add(this.btdback);
            this.deletepanel.Controls.Add(this.tbddone);
            this.deletepanel.Controls.Add(this.tbdid);
            this.deletepanel.Controls.Add(this.label13);
            this.deletepanel.Controls.Add(this.label12);
            this.deletepanel.Location = new System.Drawing.Point(0, 0);
            this.deletepanel.Name = "deletepanel";
            this.deletepanel.Size = new System.Drawing.Size(801, 517);
            this.deletepanel.TabIndex = 10;
            this.deletepanel.Visible = false;
            // 
            // btdback
            // 
            this.btdback.BackColor = System.Drawing.SystemColors.Info;
            this.btdback.Location = new System.Drawing.Point(12, 22);
            this.btdback.Name = "btdback";
            this.btdback.Size = new System.Drawing.Size(142, 47);
            this.btdback.TabIndex = 4;
            this.btdback.Text = "back to inventory";
            this.btdback.UseVisualStyleBackColor = false;
            this.btdback.Click += new System.EventHandler(this.btdback_Click);
            // 
            // tbddone
            // 
            this.tbddone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbddone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbddone.Location = new System.Drawing.Point(217, 298);
            this.tbddone.Name = "tbddone";
            this.tbddone.Size = new System.Drawing.Size(337, 92);
            this.tbddone.TabIndex = 3;
            this.tbddone.Text = "Done";
            this.tbddone.UseVisualStyleBackColor = false;
            this.tbddone.Click += new System.EventHandler(this.tbddone_Click);
            // 
            // tbdid
            // 
            this.tbdid.Location = new System.Drawing.Point(227, 199);
            this.tbdid.Name = "tbdid";
            this.tbdid.Size = new System.Drawing.Size(368, 22);
            this.tbdid.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(154, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 38);
            this.label13.TabIndex = 1;
            this.label13.Text = "ID :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(251, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 46);
            this.label12.TabIndex = 0;
            this.label12.Text = "Delete Page";
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editpanel);
            this.Controls.Add(this.deletepanel);
            this.Controls.Add(this.addpanel);
            this.Controls.Add(this.label2);
            this.Name = "inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.addpanel.ResumeLayout(false);
            this.addpanel.PerformLayout();
            this.editpanel.ResumeLayout(false);
            this.editpanel.PerformLayout();
            this.deletepanel.ResumeLayout(false);
            this.deletepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel addpanel;
        private System.Windows.Forms.Button adddone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbaprice;
        private System.Windows.Forms.TextBox tbaquantity;
        private System.Windows.Forms.TextBox tbaname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel editpanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button tbedone;
        private System.Windows.Forms.TextBox tbename;
        private System.Windows.Forms.TextBox tbeprice;
        private System.Windows.Forms.TextBox tbequantity;
        private System.Windows.Forms.TextBox tbeid;
        private System.Windows.Forms.Panel deletepanel;
        private System.Windows.Forms.Button tbddone;
        private System.Windows.Forms.TextBox tbdid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bteback;
        private System.Windows.Forms.Button btdback;
        private System.Windows.Forms.Button btaback;
        private System.Windows.Forms.Button iibtnback;
    }
}