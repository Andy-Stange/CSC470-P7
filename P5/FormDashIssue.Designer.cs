namespace Builder
{
    partial class FormDashIssue
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
            this.issueLabel = new System.Windows.Forms.Label();
            this.issueNumber = new System.Windows.Forms.Label();
            this.issueMonth = new System.Windows.Forms.Label();
            this.listMonth = new System.Windows.Forms.ListBox();
            this.issueDis = new System.Windows.Forms.Label();
            this.listDis = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.Location = new System.Drawing.Point(90, 71);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(177, 20);
            this.issueLabel.TabIndex = 0;
            this.issueLabel.Text = "Total Number of Issues:";
            // 
            // issueNumber
            // 
            this.issueNumber.AutoSize = true;
            this.issueNumber.Location = new System.Drawing.Point(273, 71);
            this.issueNumber.Name = "issueNumber";
            this.issueNumber.Size = new System.Drawing.Size(76, 20);
            this.issueNumber.TabIndex = 1;
            this.issueNumber.Text = "labelssue";
            // 
            // issueMonth
            // 
            this.issueMonth.AutoSize = true;
            this.issueMonth.Location = new System.Drawing.Point(90, 139);
            this.issueMonth.Name = "issueMonth";
            this.issueMonth.Size = new System.Drawing.Size(125, 20);
            this.issueMonth.TabIndex = 2;
            this.issueMonth.Text = "Issues by Month";
            // 
            // listMonth
            // 
            this.listMonth.FormattingEnabled = true;
            this.listMonth.ItemHeight = 20;
            this.listMonth.Location = new System.Drawing.Point(94, 162);
            this.listMonth.Name = "listMonth";
            this.listMonth.Size = new System.Drawing.Size(328, 164);
            this.listMonth.TabIndex = 3;
            // 
            // issueDis
            // 
            this.issueDis.AutoSize = true;
            this.issueDis.Location = new System.Drawing.Point(90, 376);
            this.issueDis.Name = "issueDis";
            this.issueDis.Size = new System.Drawing.Size(155, 20);
            this.issueDis.TabIndex = 4;
            this.issueDis.Text = "Issues by Discoverer";
            // 
            // listDis
            // 
            this.listDis.FormattingEnabled = true;
            this.listDis.ItemHeight = 20;
            this.listDis.Location = new System.Drawing.Point(94, 399);
            this.listDis.Name = "listDis";
            this.listDis.Size = new System.Drawing.Size(328, 164);
            this.listDis.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(322, 591);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonCancel.Size = new System.Drawing.Size(100, 50);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormDashIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 694);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.listDis);
            this.Controls.Add(this.issueDis);
            this.Controls.Add(this.listMonth);
            this.Controls.Add(this.issueMonth);
            this.Controls.Add(this.issueNumber);
            this.Controls.Add(this.issueLabel);
            this.Name = "FormDashIssue";
            this.Text = "Issue Dashboard";
            this.Load += new System.EventHandler(this.FormDashIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.Label issueNumber;
        private System.Windows.Forms.Label issueMonth;
        private System.Windows.Forms.ListBox listMonth;
        private System.Windows.Forms.Label issueDis;
        private System.Windows.Forms.ListBox listDis;
        private System.Windows.Forms.Button buttonCancel;
    }
}