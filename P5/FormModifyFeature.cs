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
    public partial class FormModifyFeature : Form
    {
        private int _selectProj;
        private int _selectID;

        public FormModifyFeature(int selectedProj)
        {
            InitializeComponent();
            _selectProj = selectedProj;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModifyFeature_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            FakeFeatureRepository fake = new FakeFeatureRepository();
            List<Feature> listfeat = fake.GetAll(_selectProj);

            dataModify.ColumnCount = 2;
            dataModify.Columns[0].Name = "Id";
            dataModify.Columns[0].Width = 30;
            dataModify.Columns[1].Name = "Title";
            dataModify.Columns[1].Width = 620;

            foreach(Feature f1 in listfeat)
            {
                string[] row = { f1.ID.ToString(), f1.Title};
                dataModify.Rows.Add(row);
            }
        }

        private void dataModify_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if(dataModify.SelectedCells.Count < 0)
            {
                MessageBox.Show("A Feature must be selected.", "Attention");
            }
            else
            {
                _selectID = dataModify.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataModify.Rows[_selectID];
                int sID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                _selectID = sID;

                FormModifyFeatureTitle mod = new FormModifyFeatureTitle(_selectID);
                mod.ShowDialog();
                this.Close();
            }
        }
    }
}
