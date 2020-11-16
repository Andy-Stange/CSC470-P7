using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P5;

namespace Builder
{
    public partial class FormCreateFeature : Form
    {
        private int _selectProj;
        public FormCreateFeature(int selectProjID)
        {
            InitializeComponent();
            _selectProj = selectProjID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCreateFeature_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            FakeFeatureRepository feat = new FakeFeatureRepository();
            Feature f = new Feature();
            f.ID = feat.GetNextFeatureID(_selectProj);
            f.ProjectID = _selectProj;

            if (feat.isDuplicate(featTextBox.Text.Trim()) == true)
            {
                MessageBox.Show("Title Must Be Unique", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (featTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Title Must Have a Value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                f.Title = featTextBox.Text.Trim();
            }
            this.Close();

        }
    }
}
