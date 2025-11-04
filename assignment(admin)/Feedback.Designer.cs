namespace assignment_admin_
{
    partial class Feedback
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
            this.lblFeedback = new System.Windows.Forms.Label();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.backF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Stencil", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(261, 27);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(217, 32);
            this.lblFeedback.TabIndex = 0;
            this.lblFeedback.Text = "Feedback Log";
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFeedback.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Location = new System.Drawing.Point(40, 85);
            this.dgvFeedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersWidth = 62;
            this.dgvFeedback.RowTemplate.Height = 28;
            this.dgvFeedback.Size = new System.Drawing.Size(670, 387);
            this.dgvFeedback.TabIndex = 1;
            this.dgvFeedback.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedback_CellContentClick);
            // 
            // backF
            // 
            this.backF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backF.BackgroundImage = global::assignment_admin_.Properties.Resources.back;
            this.backF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backF.Location = new System.Drawing.Point(12, 9);
            this.backF.Name = "backF";
            this.backF.Size = new System.Drawing.Size(50, 50);
            this.backF.TabIndex = 5;
            this.backF.UseVisualStyleBackColor = false;
            this.backF.Click += new System.EventHandler(this.backF_Click);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::assignment_admin_.Properties.Resources.hand_putting_feedback_form_paper_in_the_feedback_box_vote_feedback_rating_concept_illustration_in_flat_style_on_green_background_vector;
            this.ClientSize = new System.Drawing.Size(752, 512);
            this.Controls.Add(this.backF);
            this.Controls.Add(this.dgvFeedback);
            this.Controls.Add(this.lblFeedback);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.DataGridView dgvFeedback;
        private System.Windows.Forms.Button backF;
    }
}