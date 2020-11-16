using P5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class FormModifyFeatureTitle : Form
    {
        private int _selectId;
        public FormModifyFeatureTitle(int selectedID)
        {
            InitializeComponent();
            _selectId = selectedID;
        }

        private void FormModifyFeatureTitle_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            FakeFeatureRepository fake = new FakeFeatureRepository();
            Feature f1 = fake.GetFeatureByID(_selectId);
            modifyTextbox.Text = f1.Title;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            // Better make sure it isn't the empty string or all blanks
            string newProjectName = modifyTextbox.Text.Trim();
            if (newProjectName == "")
            {
                MessageBox.Show("Feature name cannot be empty or blank", "Attention");
                return;
            }
            FakeFeatureRepository fake2 = new FakeFeatureRepository();
            if (fake2.isDuplicate(newProjectName))
            {
                MessageBox.Show("Feature title already exists.", "Attention");
                return;
            }
            Feature feat = new Feature
            {
                ID = _selectId,
                Title = modifyTextbox.Text.Trim()
            };

            string result = fake2.Modify(feat);
            if (result != FakeFeatureRepository.NO_ERROR)
            {
                MessageBox.Show("Error modifying title. Error: " + result);
            }
            else
            {
                MessageBox.Show("Title modification successful.", "Information");
                this.Close();
            }
           
        }
    }
}
