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
            this.labelID.Location = new System.Drawing.Point(102, 60);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(30, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(90, 90);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(42, 20);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title:";
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Location = new System.Drawing.Point(36, 190);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(96, 20);
            this.labelComp.TabIndex = 4;
            this.labelComp.Text = "Component:";
            // 
            // labelDis
            // 
            this.labelDis.AutoSize = true;
            this.labelDis.Location = new System.Drawing.Point(44, 155);
            this.labelDis.Name = "labelDis";
            this.labelDis.Size = new System.Drawing.Size(88, 20);
            this.labelDis.TabIndex = 5;
            this.labelDis.Text = "Discoverer:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 125);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(120, 20);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Discovery Date:";
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Location = new System.Drawing.Point(72, 220);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(60, 20);
            this.labelStat.TabIndex = 3;
            this.labelStat.Text = "Status:";
            // 
            // modTitle
            // 
            this.modTitle.Location = new System.Drawing.Point(138, 90);
            this.modTitle.Name = "modTitle";
            this.modTitle.Size = new System.Drawing.Size(400, 26);
            this.modTitle.TabIndex = 8;
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Location = new System.Drawing.Point(72, 250);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(131, 20);
            this.labelDes.TabIndex = 9;
            this.labelDes.Text = "Intial Description:";
            // 
            // modComp
            // 
            this.modComp.Location = new System.Drawing.Point(138, 190);
            this.modComp.Name = "modComp";
            this.modComp.Size = new System.Drawing.Size(400, 26);
            this.modComp.TabIndex = 10;
            // 
            // modDes
            // 
            this.modDes.Location = new System.Drawing.Point(138, 273);
            this.modDes.Multiline = true;
            this.modDes.Name = "modDes";
            this.modDes.Size = new System.Drawing.Size(400, 272);
            this.modDes.TabIndex = 11;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(398, 591);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(140, 30);
            this.buttonModify.TabIndex = 12;
            this.buttonModify.Text = "Modify Issue";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(212, 591);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 30);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // modDateTime
            // 
            this.modDateTime.Location = new System.Drawing.Point(138, 125);
            this.modDateTime.Name = "modDateTime";
            this.modDateTime.Size = new System.Drawing.Size(400, 26);
            this.modDateTime.TabIndex = 14;
            // 
            // modDis
            // 
            this.modDis.FormattingEnabled = true;
            this.modDis.Location = new System.Drawing.Point(138, 155);
            this.modDis.Name = "modDis";
            this.modDis.Size = new System.Drawing.Size(400, 28);
            this.modDis.TabIndex = 15;
            // 
            // modStatus
            // 
            this.modStatus.FormattingEnabled = true;
            this.modStatus.Location = new System.Drawing.Point(138, 220);
            this.modStatus.Name = "modStatus";
            this.modStatus.Size = new System.Drawing.Size(400, 28);
            this.modStatus.TabIndex = 16;
            // 
            // modID
            // 
            this.modID.Location = new System.Drawing.Point(138, 58);
            this.modID.Name = "modID";
            this.modID.ReadOnly = true;
            this.modID.Size = new System.Drawing.Size(82, 26);
            this.modID.TabIndex = 17;
            // 
            // FormModifyIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 676);
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