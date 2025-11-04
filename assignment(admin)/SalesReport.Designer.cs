namespace assignment_admin_
{
    partial class SalesReport
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
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.grpBoxOptions = new System.Windows.Forms.GroupBox();
            this.btnChef = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.backSR = new System.Windows.Forms.Button();
            this.grpBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalesReport
            // 
            this.lblSalesReport.AutoSize = true;
            this.lblSalesReport.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReport.Location = new System.Drawing.Point(363, 7);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(187, 33);
            this.lblSalesReport.TabIndex = 0;
            this.lblSalesReport.Text = "Sales Report";
            // 
            // grpBoxOptions
            // 
            this.grpBoxOptions.BackgroundImage = global::assignment_admin_.Properties.Resources.istockphoto_533272455_612x6121;
            this.grpBoxOptions.Controls.Add(this.btnChef);
            this.grpBoxOptions.Controls.Add(this.btnCategory);
            this.grpBoxOptions.Controls.Add(this.btnMonth);
            this.grpBoxOptions.Font = new System.Drawing.Font("Poor Richard", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxOptions.Location = new System.Drawing.Point(46, 80);
            this.grpBoxOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxOptions.Name = "grpBoxOptions";
            this.grpBoxOptions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxOptions.Size = new System.Drawing.Size(382, 334);
            this.grpBoxOptions.TabIndex = 1;
            this.grpBoxOptions.TabStop = false;
            this.grpBoxOptions.Text = "Please choose a filter for your report";
            this.grpBoxOptions.Enter += new System.EventHandler(this.grpBoxOptions_Enter);
            // 
            // btnChef
            // 
            this.btnChef.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChef.Location = new System.Drawing.Point(51, 250);
            this.btnChef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChef.Name = "btnChef";
            this.btnChef.Size = new System.Drawing.Size(285, 48);
            this.btnChef.TabIndex = 2;
            this.btnChef.Text = "Chef";
            this.btnChef.UseVisualStyleBackColor = true;
            this.btnChef.Click += new System.EventHandler(this.btnChef_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Location = new System.Drawing.Point(51, 162);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(285, 48);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonth.Location = new System.Drawing.Point(51, 63);
            this.btnMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(285, 48);
            this.btnMonth.TabIndex = 0;
            this.btnMonth.Text = "Month";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // dgvSales
            // 
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(464, 89);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 62;
            this.dgvSales.RowTemplate.Height = 28;
            this.dgvSales.Size = new System.Drawing.Size(444, 326);
            this.dgvSales.TabIndex = 2;
            // 
            // backSR
            // 
            this.backSR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backSR.BackgroundImage = global::assignment_admin_.Properties.Resources.back;
            this.backSR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backSR.Location = new System.Drawing.Point(12, 12);
            this.backSR.Name = "backSR";
            this.backSR.Size = new System.Drawing.Size(50, 50);
            this.backSR.TabIndex = 5;
            this.backSR.UseVisualStyleBackColor = false;
            this.backSR.Click += new System.EventHandler(this.backSR_Click);
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::assignment_admin_.Properties.Resources._360_F_518543293_FC1LEAcASIyfoHgmoPjB1ZVxvgwZsdqR;
            this.ClientSize = new System.Drawing.Size(957, 502);
            this.Controls.Add(this.backSR);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.grpBoxOptions);
            this.Controls.Add(this.lblSalesReport);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReport";
            this.grpBoxOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalesReport;
        private System.Windows.Forms.GroupBox grpBoxOptions;
        private System.Windows.Forms.Button btnChef;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Button backSR;
    }
}