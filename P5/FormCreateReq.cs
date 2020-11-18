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
    public partial class FormCreateReq : Form
    {
        private int _selectProj;
        private int __selectFeat;
        public FormCreateReq(int selectedProj)
        {
            InitializeComponent();
            _selectProj = selectedProj;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCreateReq_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            string isFeat;
            FakeFeatureRepository fake = new FakeFeatureRepository();
            FakeRequirementRepository freq = new FakeRequirementRepository();
            List<Feature> listFeat = new List<Feature>();

            listFeat = fake.GetAll(_selectProj);

            textBoxState.Enabled = false;
            buttonCreate.Enabled = false;

            comboBoxFeature.Items.Add("<Make Selection>");
            comboBoxFeature.SelectedIndex = 0;

            foreach(Feature f in listFeat)
            {
                isFeat = f.Title;
                comboBoxFeature.Items.Add(isFeat);

            }

            this.comboBoxFeature.SelectedIndexChanged += new System.EventHandler(comboBoxFeat_SelectedIndexChanged);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        { 
           
            FakeRequirementRepository freq1 = new FakeRequirementRepository();
            FakeFeatureRepository fake2 = new FakeFeatureRepository();
            List<Feature> listFeat1 = new List<Feature>();
            Requirement req = new Requirement();
            listFeat1 = fake2.GetAll(_selectProj);

            string s = comboBoxFeature.Text;

            foreach(Feature ft in listFeat1)
            {
                if(ft.Title == s)
                {
                    __selectFeat = ft.ID;
                }
            }


            req.ID = freq1.GetNextReqID(_selectProj);
            req.ProjectID = _selectProj;
            req.FeatureID = __selectFeat;
            req.Statement = textBoxState.Text.Trim();

            string result = freq1.Add(req);
            if(result == "")
            {
                MessageBox.Show("Requirement Added Sucessfully","",MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show(result, "Attention", MessageBoxButtons.OK);
                return;
            }

        }

        private void comboBoxFeat_SelectedIndexChanged(object sender,  System.EventArgs e)
        {
            if(comboBoxFeature.SelectedIndex != 0)
            {
                textBoxState.Enabled = true;
                buttonCreate.Enabled = true;
            }
            else
            {
                textBoxState.Enabled = false;
                buttonCreate.Enabled = false;
            }

        }
    }
}
