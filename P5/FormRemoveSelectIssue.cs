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
    public partial class FormRemoveSelectIssue : Form
    {
        public int _selectedID;
        public int _selectedProj;
        public FormRemoveSelectIssue(int CurrentProjID)
        {
            InitializeComponent();
            _selectedProj = CurrentProjID;
        }

        private void FormRemoveSelectIssue_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            FakeIssueRepository iss = new FakeIssueRepository();
            List<Issue> yourList = iss.GetAll(_selectedProj);

            dataIssue.ColumnCount = 7;
            dataIssue.Columns[0].Name = "Id";
            dataIssue.Columns[0].Width = 30;
            dataIssue.Columns[1].Name = "Title";
            dataIssue.Columns[1].Width = 400;
            dataIssue.Columns[2].Name = "Discovery Date";
            dataIssue.Columns[1].Width = 150;
            dataIssue.Columns[3].Name = "Discoverer";
            dataIssue.Columns[4].Name = "IntialDes.";
            dataIssue.Columns[5].Name = "Components";
            dataIssue.Columns[6].Name = "Status";

            foreach (Issue i2 in yourList)
            {
                string[] row = {i2.ID.ToString(),i2.Title,i2.DiscoveryDate.ToString("yyyymmdd hh:mm"),
                                 i2.Discoverer,i2.InitialDescription,i2.Component,i2.IssueStatusID.ToString()};
                dataIssue.Rows.Add(row);
            }
        }
        private void buttonSelect_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelect_Click_1(object sender, EventArgs e)
        {

            if (dataIssue.SelectedCells.Count < 0)
            {
                MessageBox.Show("A Issue must be selected.", "Attention");
            }
            else
            {
                _selectedID = dataIssue.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataIssue.Rows[_selectedID];
                int sID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                _selectedID = sID;

                FakeIssueRepository iss2 = new FakeIssueRepository();
                Issue i2 = iss2.GetIssueByID(sID);
                DialogResult result = MessageBox.Show("Are you sure you want to Remove:" + i2.Title, "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool res = iss2.Remove(i2);
                }
                else
                {
                    MessageBox.Show("Remove Canceled", "Attention", MessageBoxButtons.OK);
                }
            }

        }
    }
}
