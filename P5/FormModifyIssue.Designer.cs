namespace Builder
{
    partial class FormModifyIssue
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelComp = new System.Windows.Forms.Label();
            this.labelDis = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelStat = new System.Windows.Forms.Label();
            this.modTitle = new System.Windows.Forms.TextBox();
            this.labelDes = new System.Windows.Forms.Label();
            this.modComp = new System.Windows.Forms.TextBox();
            this.modDes = new System.Windows.Forms.TextBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.modDateTime = new System.Windows.Forms.DateTimePicker();
            this.modDis = new System.Windows.Forms.ComboBox();
            this.modStatus = new System.Windows.Forms.ComboBox();
            this.modID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(91, 48);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(25, 17);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(80, 72);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 17);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title:";
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Location = new System.Drawing.Point(32, 152);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(84, 17);
            this.labelComp.TabIndex = 4;
            this.labelComp.Text = "Component:";
            // 
            // labelDis
            // 
            this.labelDis.AutoSize = true;
            this.labelDis.Location = new System.Drawing.Point(39, 124);
            this.labelDis.Name = "labelDis";
            this.labelDis.Size = new System.Drawing.Size(80, 17);
            this.labelDis.TabIndex = 5;
            this.labelDis.Text = "Discoverer:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(11, 100);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(108, 17);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Discovery Date:";
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Location = new System.Drawing.Point(64, 176);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(52, 17);
            this.labelStat.TabIndex = 3;
            this.labelStat.Text = "Status:";
            // 
            // modTitle
            // 
            this.modTitle.Location = new System.Drawing.Point(123, 72);
            this.modTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modTitle.Name = "modTitle";
            this.modTitle.Size = new System.Drawing.Size(356, 22);
            this.modTitle.TabIndex = 8;
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Location = new System.Drawing.Point(64, 200);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(116, 17);
            this.labelDes.TabIndex = 9;
            this.labelDes.Text = "Intial Description:";
            // 
            // modComp
            // 
            this.modComp.Location = new System.Drawing.Point(123, 152);
            this.modComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modComp.Name = "modComp";
            this.modComp.Size = new System.Drawing.Size(356, 22);
            this.modComp.TabIndex = 10;
            // 
            // modDes
            // 
            this.modDes.Location = new System.Drawing.Point(123, 218);
            this.modDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modDes.Multiline = true;
            this.modDes.Name = "modDes";
            this.modDes.Size = new System.Drawing.Size(356, 218);
            this.modDes.TabIndex = 11;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(354, 473);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(124, 24);
            this.buttonModify.TabIndex = 12;
            this.buttonModify.Text = "Modify Issue";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(188, 473);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(124, 24);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // modDateTime
            // 
            this.modDateTime.Location = new System.Drawing.Point(123, 100);
            this.modDateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modDateTime.Name = "modDateTime";
            this.modDateTime.Size = new System.Drawing.Size(356, 22);
            this.modDateTime.TabIndex = 14;
            // 
            // modDis
            // 
            this.modDis.FormattingEnabled = true;
            this.modDis.Location = new System.Drawing.Point(123, 124);
            this.modDis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modDis.Name = "modDis";
            this.modDis.Size = new System.Drawing.Size(356, 24);
            this.modDis.TabIndex = 15;
            // 
            // modStatus
            // 
            this.modStatus.FormattingEnabled = true;
            this.modStatus.Location = new System.Drawing.Point(123, 176);
            this.modStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modStatus.Name = "modStatus";
            this.modStatus.Size = new System.Drawing.Size(356, 24);
            this.modStatus.TabIndex = 16;
            // 
            // modID
            // 
            this.modID.Location = new System.Drawing.Point(123, 46);
            this.modID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modID.Name = "modID";
            this.modID.ReadOnly = true;
            this.modID.Size = new System.Drawing.Size(73, 22);
            this.modID.TabIndex = 17;
            // 
            // FormModifyIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 541);
            this.Controls.Add(this.modID);
            this.Controls.Add(this.modStatus);
            this.Controls.Add(this.modDis);
            this.Controls.Add(this.modDateTime);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.modDes);
            this.Controls.Add(this.modComp);
            this.Controls.Add(this.labelDes);
            this.Controls.Add(this.modTitle);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelDis);
            this.Controls.Add(this.labelComp);
            this.Controls.Add(this.labelStat);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormModifyIssue";
            this.Text = "Modify Issue";
            this.Load += new System.EventHandler(this.FormModifyIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.Label labelDis;
        private System.Windows.Forms.Label labelDate;
        public System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.TextBox modTitle;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.TextBox modComp;
        private System.Windows.Forms.TextBox modDes;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker modDateTime;
        private System.Windows.Forms.ComboBox modDis;
        private System.Windows.Forms.ComboBox modStatus;
        private System.Windows.Forms.TextBox modID;
    }
}