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

        private void buttonModify_Click(object sender, EventArgs e)
        {
            FakeIssueRepository iss2 = new FakeIssueRepository();
            Issue i2 = new Issue();
            i2.ID = Convert.ToInt32(modID.Text);
            i2.Title = modTitle.Text;
            i2.DiscoveryDate = Convert.ToDateTime(modDateTime.Text);
            i2.Discoverer = modDis.Text;
            i2.Component = modComp.Text;
            i2.IssueStatusID = Convert.ToInt32(modStatus.Text);
            i2.InitialDescription = modDes.Text;


            var result = iss2.Modify(i2);
            this.Close();
        }
    }
}
