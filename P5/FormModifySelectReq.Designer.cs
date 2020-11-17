namespace Builder
{
    partial class FormModifySelectReq
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
            this.labelState = new System.Windows.Forms.Label();
            this.labelFeat = new System.Windows.Forms.Label();
            this.comboBoxFeature = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.dataGridReqs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReqs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(13, 79);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(100, 17);
            this.labelState.TabIndex = 0;
            this.labelState.Text = "Requirements:";
            // 
            // labelFeat
            // 
            this.labelFeat.AutoSize = true;
            this.labelFeat.Location = new System.Drawing.Point(52, 40);
            this.labelFeat.Name = "labelFeat";
            this.labelFeat.Size = new System.Drawing.Size(61, 17);
            this.labelFeat.TabIndex = 1;
            this.labelFeat.Text = "Feature:";
            // 
            // comboBoxFeature
            // 
            this.comboBoxFeature.FormattingEnabled = true;
            this.comboBoxFeature.Location = new System.Drawing.Point(118, 40);
            this.comboBoxFeature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxFeature.Name = "comboBoxFeature";
            this.comboBoxFeature.Size = new System.Drawing.Size(648, 24);
            this.comboBoxFeature.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(388, 482);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(160, 24);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSelect.Location = new System.Drawing.Point(605, 482);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(160, 24);
            this.buttonSelect.TabIndex = 5;
            this.buttonSelect.Text = "Select Requirement";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // dataGridReqs
            // 
            this.dataGridReqs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReqs.Location = new System.Drawing.Point(118, 79);
            this.dataGridReqs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridReqs.Name = "dataGridReqs";
            this.dataGridReqs.RowHeadersWidth = 62;
            this.dataGridReqs.RowTemplate.Height = 28;
            this.dataGridReqs.Size = new System.Drawing.Size(647, 374);
            this.dataGridReqs.TabIndex = 6;
            // 
            // FormModifySelectReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 522);
            this.Controls.Add(this.dataGridReqs);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxFeature);
            this.Controls.Add(this.labelFeat);
            this.Controls.Add(this.labelState);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormModifySelectReq";
            this.Text = "Select Requirement";
            this.Load += new System.EventHandler(this.FormModifySelectReq_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReqs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelFeat;
        private System.Windows.Forms.ComboBox comboBoxFeature;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.DataGridView dataGridReqs;
    }
}