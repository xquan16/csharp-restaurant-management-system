namespace assignment_admin_
{
    partial class Ordermanagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.maip = new System.Windows.Forms.Button();
            this.mac = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderpanel = new System.Windows.Forms.Panel();
            this.osbtnback = new System.Windows.Forms.Button();
            this.maippanel = new System.Windows.Forms.Panel();
            this.maipback = new System.Windows.Forms.Button();
            this.maipdone = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.macpanel = new System.Windows.Forms.Panel();
            this.macback = new System.Windows.Forms.Button();
            this.macdone = new System.Windows.Forms.Button();
            this.tbmac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.orderpanel.SuspendLayout();
            this.maippanel.SuspendLayout();
            this.macpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order State";
            // 
            // maip
            // 
            this.maip.BackColor = System.Drawing.SystemColors.HotTrack;
            this.maip.Location = new System.Drawing.Point(27, 377);
            this.maip.Name = "maip";
            this.maip.Size = new System.Drawing.Size(217, 63);
            this.maip.TabIndex = 2;
            this.maip.Text = "Mark as in progress";
            this.maip.UseVisualStyleBackColor = false;
            this.maip.Click += new System.EventHandler(this.maip_Click);
            // 
            // mac
            // 
            this.mac.Location = new System.Drawing.Point(525, 377);
            this.mac.Name = "mac";
            this.mac.Size = new System.Drawing.Size(227, 63);
            this.mac.TabIndex = 3;
            this.mac.Text = "Mark as complete";
            this.mac.UseVisualStyleBackColor = true;
            this.mac.Click += new System.EventHandler(this.mac_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 307);
            this.dataGridView1.TabIndex = 4;
            // 
            // orderpanel
            // 
            this.orderpanel.Controls.Add(this.osbtnback);
            this.orderpanel.Controls.Add(this.label1);
            this.orderpanel.Controls.Add(this.dataGridView1);
            this.orderpanel.Controls.Add(this.mac);
            this.orderpanel.Controls.Add(this.maip);
            this.orderpanel.Location = new System.Drawing.Point(-1, -2);
            this.orderpanel.Name = "orderpanel";
            this.orderpanel.Size = new System.Drawing.Size(802, 451);
            this.orderpanel.TabIndex = 5;
            // 
            // osbtnback
            // 
            this.osbtnback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.osbtnback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.osbtnback.Location = new System.Drawing.Point(16, 5);
            this.osbtnback.Name = "osbtnback";
            this.osbtnback.Size = new System.Drawing.Size(194, 39);
            this.osbtnback.TabIndex = 5;
            this.osbtnback.Text = "Back to Main page";
            this.osbtnback.UseVisualStyleBackColor = false;
            this.osbtnback.Click += new System.EventHandler(this.button1_Click);
            // 
            // maippanel
            // 
            this.maippanel.Controls.Add(this.maipback);
            this.maippanel.Controls.Add(this.maipdone);
            this.maippanel.Controls.Add(this.textBox1);
            this.maippanel.Controls.Add(this.label3);
            this.maippanel.Controls.Add(this.label2);
            this.maippanel.Location = new System.Drawing.Point(-1, -2);
            this.maippanel.Name = "maippanel";
            this.maippanel.Size = new System.Drawing.Size(802, 448);
            this.maippanel.TabIndex = 6;
            // 
            // maipback
            // 
            this.maipback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maipback.Location = new System.Drawing.Point(172, 266);
            this.maipback.Name = "maipback";
            this.maipback.Size = new System.Drawing.Size(412, 65);
            this.maipback.TabIndex = 4;
            this.maipback.Text = "Back To Order State";
            this.maipback.UseVisualStyleBackColor = true;
            this.maipback.Click += new System.EventHandler(this.maipback_Click);
            // 
            // maipdone
            // 
            this.maipdone.BackColor = System.Drawing.SystemColors.Highlight;
            this.maipdone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maipdone.Location = new System.Drawing.Point(172, 352);
            this.maipdone.Name = "maipdone";
            this.maipdone.Size = new System.Drawing.Size(412, 69);
            this.maipdone.TabIndex = 3;
            this.maipdone.Text = "Done";
            this.maipdone.UseVisualStyleBackColor = false;
            this.maipdone.Click += new System.EventHandler(this.maipdone_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter An ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(750, 69);
            this.label2.TabIndex = 0;
            this.label2.Text = "MARK AS IN PROGRESS";
            // 
            // macpanel
            // 
            this.macpanel.Controls.Add(this.macback);
            this.macpanel.Controls.Add(this.macdone);
            this.macpanel.Controls.Add(this.tbmac);
            this.macpanel.Controls.Add(this.label5);
            this.macpanel.Controls.Add(this.label4);
            this.macpanel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.macpanel.ForeColor = System.Drawing.Color.Black;
            this.macpanel.Location = new System.Drawing.Point(0, 0);
            this.macpanel.Name = "macpanel";
            this.macpanel.Size = new System.Drawing.Size(799, 448);
            this.macpanel.TabIndex = 4;
            // 
            // macback
            // 
            this.macback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macback.Location = new System.Drawing.Point(207, 233);
            this.macback.Name = "macback";
            this.macback.Size = new System.Drawing.Size(376, 74);
            this.macback.TabIndex = 4;
            this.macback.Text = "Back To Order State";
            this.macback.UseVisualStyleBackColor = true;
            this.macback.Click += new System.EventHandler(this.macback_Click);
            // 
            // macdone
            // 
            this.macdone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macdone.Location = new System.Drawing.Point(207, 326);
            this.macdone.Name = "macdone";
            this.macdone.Size = new System.Drawing.Size(376, 74);
            this.macdone.TabIndex = 3;
            this.macdone.Text = "Done";
            this.macdone.UseVisualStyleBackColor = true;
            this.macdone.Click += new System.EventHandler(this.macdone_Click);
            // 
            // tbmac
            // 
            this.tbmac.Location = new System.Drawing.Point(248, 177);
            this.tbmac.Name = "tbmac";
            this.tbmac.Size = new System.Drawing.Size(265, 22);
            this.tbmac.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enter An ID ：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(130, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(536, 69);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mark As Complete";
            // 
            // Ordermanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderpanel);
            this.Controls.Add(this.macpanel);
            this.Controls.Add(this.maippanel);
            this.Name = "Ordermanagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordermanagement";
            this.Load += new System.EventHandler(this.Ordermanagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.orderpanel.ResumeLayout(false);
            this.orderpanel.PerformLayout();
            this.maippanel.ResumeLayout(false);
            this.maippanel.PerformLayout();
            this.macpanel.ResumeLayout(false);
            this.macpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button maip;
        private System.Windows.Forms.Button mac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel orderpanel;
        private System.Windows.Forms.Panel maippanel;
        private System.Windows.Forms.Button maipdone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel macpanel;
        private System.Windows.Forms.Button macdone;
        private System.Windows.Forms.TextBox tbmac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button maipback;
        private System.Windows.Forms.Button macback;
        private System.Windows.Forms.Button osbtnback;
    }
}