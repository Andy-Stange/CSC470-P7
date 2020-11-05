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
    public partial class FormModifySelectIssue : Form
    {
        public int _selectedID;
        public FormModifySelectIssue(int CurrentProjectID)
        {
            InitializeComponent();
            _selectedID = CurrentProjectID;
        }

        private void FormModifySelectIssue_Load(object sender, EventArgs e)
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

                _selectedID = sID;
               
                FormModifyIssue mod = new FormModifyIssue();
                mod.ShowDialog();
   
            }
            else
            {
                MessageBox.Show("Only 1 Issue can be selected.", "Attention");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
