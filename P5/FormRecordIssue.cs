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
    public partial class FormRecordIssue : Form
    {
        Project CurProject = new Project();
        private int ID;
        public FormRecordIssue(int ProjectID)
        {
            InitializeComponent();
            ID = ProjectID;
        }

        private void FormRecordIssue_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FakeIssueRepository IssueRepository = new FakeIssueRepository();
            FakeIssueStatusRepository StatRepo = new FakeIssueStatusRepository();
            IssueStatus IsStat = new IssueStatus();
            Issue issue = new Issue();
            issue.ProjectID = ID;
            issue.ID = IssueRepository.GetNextIssueID(ID);
            issue.DiscoveryDate = dateTimeDiscoveryDate.Value;
            if (!IssueRepository.isDuplicate(textBoxIssueTitle.ToString()))
                issue.Title = textBoxIssueTitle.ToString();
            issue.Discoverer = comboBoxDiscoverer.ToString();
            issue.InitialDescription = textBoxInitialDescription.ToString();
            issue.Component = textBoxComponent.ToString();
            string IssueStat = comboBoxIssueStatus.ToString();

        }
    }
}
