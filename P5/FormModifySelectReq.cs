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
    public partial class FormModifySelectReq : Form
    {
        private int _SelectedProj;
        private List<Feature> Flist = new List<Feature>();
        private int _SelectedFeat;
        private int _SelectedReq;
        public FormModifySelectReq(int ProjID)
        {
            InitializeComponent();
            _SelectedProj = ProjID;
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModifySelectReq_Load_1(object sender, EventArgs e)
        {
            this.CenterToParent();
            string featTitle;
            FakeFeatureRepository FakeFeat = new FakeFeatureRepository();

            Flist = FakeFeat.GetAll(_SelectedProj);

            foreach (Feature feat in Flist)
            {
                featTitle = feat.Title;
                comboBoxFeature.Items.Add(featTitle);
            }
            dataGridReqs.Enabled = false;
            buttonSelect.Enabled = false;

            this.comboBoxFeature.SelectedIndexChanged += new System.EventHandler(comboBoxFeat_SelectedIndexChanged);

        }
        private void comboBoxFeat_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            dataGridReqs.Enabled = true;
            buttonSelect.Enabled = true;

            this.dataGridReqs.DataSource = null;
            this.dataGridReqs.Rows.Clear();

            FakeRequirementRepository fakeReq = new FakeRequirementRepository();
            List<Requirement> reqList = new List<Requirement>();
            string selF = comboBoxFeature.Text;

            foreach(Feature feat in Flist)
            {
                if(feat.Title == selF)
                {
                    _SelectedFeat = feat.ID;
                }
            }

            reqList = fakeReq.GetAll(_SelectedProj);

            dataGridReqs.ColumnCount = 2;
            dataGridReqs.Columns[0].Name = "ID";
            dataGridReqs.Columns[0].Width = 30;
            dataGridReqs.Columns[1].Name = "Requirement";
            dataGridReqs.Columns[1].Width = 620;
            dataGridReqs.RowTemplate.Height = 20;

            foreach (Requirement req in reqList)
            {
                if(req.FeatureID == _SelectedFeat)
                {
                    string[] row = { req.ID.ToString(), req.Statement };
                    dataGridReqs.Rows.Add(row);
                }

            }

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if(dataGridReqs.SelectedCells.Count < 0)
            {
                MessageBox.Show("Must Select A Requirement!", "Attention");
            }
            else
            {
                int selectedRow = dataGridReqs.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridReqs.Rows[selectedRow];
                _SelectedReq = Convert.ToInt32(row.Cells["ID"].Value);

                FormModifyReq form = new FormModifyReq(_SelectedProj, _SelectedFeat, _SelectedReq);
                form.ShowDialog();
                form.Dispose();
            }
        }
    }
}
