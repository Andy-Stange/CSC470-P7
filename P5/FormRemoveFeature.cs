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
    public partial class FormRemoveFeature : Form
    {
        private int _selectProj;
        private int _selectID;
        public FormRemoveFeature(int selectedProj)
        {
            InitializeComponent();
            _selectProj = selectedProj;

        }

        private void FormRemoveFeature_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            FakeFeatureRepository fake = new FakeFeatureRepository();
            List<Feature> listfeat = fake.GetAll(_selectProj);

            dataRemove.ColumnCount = 2;
            dataRemove.Columns[0].Name = "Id";
            dataRemove.Columns[0].Width = 30;
            dataRemove.Columns[1].Name = "Title";
            dataRemove.Columns[1].Width = 620;

            foreach (Feature f1 in listfeat)
            {
                string[] row = { f1.ID.ToString(), f1.Title };
                dataRemove.Rows.Add(row);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if(dataRemove.SelectedCells.Count < 0)
            {
                MessageBox.Show("A must be selected.", "Attention");
            }
            else
            {
                _selectID = dataRemove.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataRemove.Rows[_selectID];
                int sID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                _selectID = sID;

                FakeFeatureRepository fake1 = new FakeFeatureRepository();
                Feature f2 = fake1.GetFeatureByID(_selectID);
                DialogResult result = MessageBox.Show("Are you sure you want to Remove:" + f2.Title, "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string res = fake1.Remove(f2);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Remove Canceled", "Attention", MessageBoxButtons.OK);
                }
            }
        }
    }
}
