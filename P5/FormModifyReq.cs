using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5

{
    public partial class FormModifyReq : Form
    {
        private int _ProjectID;
        private int _FeatureID;
        private int _RequirementID;
        private int _NewFeatID;
        public FormModifyReq(int ProjID, int FeatID, int ReqID)
        {
            InitializeComponent();
            _ProjectID = ProjID;
            _FeatureID = FeatID;
            _RequirementID = ReqID;
            _NewFeatID = _FeatureID;
        }

        private void FormModifyReq_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            FakeFeatureRepository Fake1 = new FakeFeatureRepository();
            FakeRequirementRepository Freq1 = new FakeRequirementRepository();
            List<Feature> feats = new List<Feature>();
            Requirement req = new Requirement();
            req = Freq1.GetRequirementByID(_RequirementID);

            feats = Fake1.GetAll(_ProjectID);
            int index = 0;
            foreach (Feature feat in feats)
            {
                comboBoxFeature.Items.Add(feat.Title);
                if (feat.ID == _FeatureID)
                {
                    comboBoxFeature.SelectedIndex = index;
                }
                index++;
            }
            textBoxState.Text = req.Statement.ToString();

            this.comboBoxFeature.SelectedIndexChanged += new System.EventHandler(comboBoxFeat_SelectedIndexChanged);

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            FakeRequirementRepository Freq = new FakeRequirementRepository();
            Requirement req = new Requirement();
            string error;

            req.ProjectID = _ProjectID;
            req.FeatureID = _NewFeatID;
            req.ID = _RequirementID;
            req.Statement = textBoxState.Text;

            error = Freq.Modify(req);
            if(error != "")
            {
                MessageBox.Show(error, "Attention");
            }
            else
            {
                MessageBox.Show("Requirement Successfully Modified!", "Attention");
                this.Close();
            }


        }
        private void comboBoxFeat_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            FakeFeatureRepository Fake = new FakeFeatureRepository();
            Feature feat = new Feature();
            string selectedFeat = comboBoxFeature.Text;

            feat = Fake.GetFeatureByTitle(selectedFeat);
            _NewFeatID = feat.ID;
        }
    }
}
