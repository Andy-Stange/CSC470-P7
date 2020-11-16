namespace Builder
{
    partial class FormCreateReq
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(39, 99);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(88, 20);
            this.labelState.TabIndex = 0;
            this.labelState.Text = "Statement:";
            this.labelState.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFeat
            // 
            this.labelFeat.AutoSize = true;
            this.labelFeat.Location = new System.Drawing.Point(58, 50);
            this.labelFeat.Name = "labelFeat";
            this.labelFeat.Size = new System.Drawing.Size(69, 20);
            this.labelFeat.TabIndex = 1;
            this.labelFeat.Text = "Feature:";
            this.labelFeat.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxFeature
            // 
            this.comboBoxFeature.FormattingEnabled = true;
            this.comboBoxFeature.Location = new System.Drawing.Point(133, 50);
            this.comboBoxFeature.Name = "comboBoxFeature";
            this.comboBoxFeature.Size = new System.Drawing.Size(616, 28);
            this.comboBoxFeature.TabIndex = 2;
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(133, 99);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(616, 323);
            this.textBoxState.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(355, 437);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(180, 30);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(570, 437);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(180, 30);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Create Requirement";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.comboBoxFeature);
            this.Controls.Add(this.labelFeat);
            this.Controls.Add(this.labelState);
            this.Name = "Form1";
            this.Text = "FormCreateReq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelFeat;
        private System.Windows.Forms.ComboBox comboBoxFeature;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreate;
    }
}