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
    public partial class FormModifyReq : Form
    {
        private int _ProjectID;
        private int _FeatrueID;
        private int _RequirementID;
        public FormModifyReq(int ProjID, int FeatID, int ReqID)
        {
            InitializeComponent();
            _ProjectID = ProjID;
            _FeatrueID = FeatID;
            _RequirementID = ReqID;
        }

        private void FormModifyReq_Load(object sender, EventArgs e)
        {

        }
    }
}
