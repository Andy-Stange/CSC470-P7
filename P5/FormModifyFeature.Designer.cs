namespace Builder
{
    partial class FormModifyFeature
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
            this.dataModify = new System.Windows.Forms.DataGridView();
            this.selectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataModify)).BeginInit();
            this.SuspendLayout();
            // 
            // dataModify
            // 
            this.dataModify.AllowUserToAddRows = false;
            this.dataModify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataModify.Location = new System.Drawing.Point(33, 32);
            this.dataModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataModify.MultiSelect = false;
            this.dataModify.Name = "dataModify";
            this.dataModify.RowHeadersWidth = 62;
            this.dataModify.RowTemplate.Height = 28;
            this.dataModify.Size = new System.Drawing.Size(486, 229);
            this.dataModify.TabIndex = 0;
            this.dataModify.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataModify_CellContentClick);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(433, 282);
            this.selectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(87, 19);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select Feature";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(306, 282);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 19);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FormModifyFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 309);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.dataModify);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormModifyFeature";
            this.Text = "Select Feature";
            this.Load += new System.EventHandler(this.FormModifyFeature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataModify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataModify;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button cancelButton;
    }
}