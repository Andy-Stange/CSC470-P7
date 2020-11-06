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
    
    public partial class FormModifyIssue : Form
    {
        public int _selectID;
        public FormModifyIssue(int selectedID)
        {
            InitializeComponent();
            _selectID = selectedID;
        }

        private void FormModifyIssue_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            FakeIssueRepository iss = new FakeIssueRepository();
            Issue i2 = iss.GetIssueByID(_selectID);
            modID.Text = Convert.ToString(i2.ID);
            modTitle.Text = i2.Title;
            modDateTime.Text = Convert.ToString(i2.DiscoveryDate);
            modDis.Text = i2.Discoverer;
            modComp.Text = i2.Component;
            modStatus.Text = Convert.ToString(i2.IssueStatusID);
            modDes.Text = i2.InitialDescription;

        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            FakeIssueRepository iss2 = new FakeIssueRepository();
            Issue i3 = new Issue
            {
                ID = Convert.ToInt32(modID.Text),
                Title = modTitle.Text,
                DiscoveryDate = Convert.ToDateTime(modDateTime.Text),
                Discoverer = modDis.Text,
                Component = modComp.Text,
                IssueStatusID = Convert.ToInt32(modStatus.Text),
                InitialDescription = modDes.Text
            };
            _ = iss2.Modify(i3);
            this.Close();
        }
    }
}
