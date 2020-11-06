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
        private int ID;
        public FormRecordIssue(int ProjectID)
        {
            InitializeComponent();
            ID = ProjectID;
        }

        private void FormRecordIssue_Load(object sender, EventArgs e)
        {
            int nextID;
            string disc;
            string IsStat;
            FakeIssueRepository IssueRepo = new FakeIssueRepository();
            FakeAppUserRepository AppRepo = new FakeAppUserRepository();
            FakeIssueStatusRepository IssueStatRepo = new FakeIssueStatusRepository();
            List<AppUser> userList = new List<AppUser>();
            List<IssueStatus> issueStatList = new List<IssueStatus>();
            nextID = IssueRepo.GetNextIssueID(ID);
            textBoxIssueID.Text = nextID.ToString();
            userList = AppRepo.GetAll();
            foreach(AppUser user in userList)
            {
                disc = (user.LastName + ", " + user.FirstName);
                comboBoxDiscoverer.Items.Add(disc);
            }
            issueStatList = IssueStatRepo.GetAll();
            foreach(IssueStatus stat in issueStatList)
            {
                IsStat = stat.Value;
                comboBoxIssueStatus.Items.Add(IsStat);
            }
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
            issue.Discoverer = comboBoxDiscoverer.SelectedItem.ToString();
            issue.InitialDescription = textBoxInitialDescription.ToString();
            issue.Component = textBoxComponent.ToString();
            string IssueStat = comboBoxIssueStatus.SelectedItem.ToString();
            issue.IssueStatusID = StatRepo.GetIdByStatus(IssueStat);

        }
    }
}
