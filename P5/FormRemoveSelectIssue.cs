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
        public string _selectedTitle;
        public FormRemoveSelectIssue()
        {
            InitializeComponent();
        }

        private void FormRemoveSelectIssue_Load(object sender, EventArgs e)
        {
            FakeIssueRepository iss = new FakeIssueRepository();
            Issue i = new Issue();
            dataIssue.DataSource = iss.GetAll(i.ProjectID);
        }
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (dataIssue.SelectedCells.Count < 0)
            {
                MessageBox.Show("A Issue must be selected.", "Attention");
            }
            else if (dataIssue.SelectedCells.Count == 1)
            {
                _selectedID = dataIssue.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataIssue.Rows[_selectedID];
                int sID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                FakeIssueRepository iss2 = new FakeIssueRepository();
                Issue i2 = iss2.GetIssueByID(sID);

                DialogResult result = MessageBox.Show("Are you sure you want to Remove:" + i2.Title,
                                    "Confirmation",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool res = iss2.Remove(i2);
                }
                else
                {
                    MessageBox.Show("Remove Canceled", "Attention", MessageBoxButtons.OK);
                }       
            }
            else
            {
                MessageBox.Show("Only 1 Issue can be selected.", "Attention");
            }

        }
    }
}
