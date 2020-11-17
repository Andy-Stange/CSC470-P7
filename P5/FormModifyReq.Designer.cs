namespace Builder
{
    partial class FormModifyReq
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
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(35, 79);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(76, 17);
            this.labelState.TabIndex = 0;
            this.labelState.Text = "Statement:";
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
            this.comboBoxFeature.Size = new System.Drawing.Size(548, 24);
            this.comboBoxFeature.TabIndex = 2;
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(118, 79);
            this.textBoxState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(548, 259);
            this.textBoxState.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(316, 350);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(160, 24);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(507, 350);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(160, 24);
            this.buttonModify.TabIndex = 5;
            this.buttonModify.Text = "Modify Requirement";
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // FormModifyReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 396);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.comboBoxFeature);
            this.Controls.Add(this.labelFeat);
            this.Controls.Add(this.labelState);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormModifyReq";
            this.Text = "Modify Requirement";
            this.Load += new System.EventHandler(this.FormModifyReq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelFeat;
        private System.Windows.Forms.ComboBox comboBoxFeature;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonModify;
    }

}