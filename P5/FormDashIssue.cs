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
    public partial class FormDashIssue : Form
    {
        private int _currentProj;
        private int issueN;

        List<string> Month;
        List<string> Discover;

        public FormDashIssue(int CurrentProjID)
        {
            InitializeComponent();
            _currentProj = CurrentProjID;
        }

        private void FormDashIssue_Load(object sender, EventArgs e)
        {
            FakeIssueRepository iss = new FakeIssueRepository();
            issueN = iss.GetTotalNumberOfIssues(_currentProj);
            Month = iss.GetIssuesByMonth(_currentProj);
            Discover = iss.GetIssuesByDiscoverer(_currentProj);

            issueNumber.Text = Convert.ToString(issueN);
            foreach(string M in Month)
            {
                listMonth.Text = String.Join(Environment.NewLine, M);
            }
            foreach (string D in Discover)
            {
                listDis.Text = String.Join(Environment.NewLine, D); ;
            }




        }

        private void FormDashIssue_Load(object sender, EventArgs e)
        {

        }
    }
}
