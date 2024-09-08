using BusinessLayer;
using PresentationLayer.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }


        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            RefreshData();

            if (dgv != null && dgv.RowCount > 0)
            {
                dgv.Columns["ID"].Width = clsUtils.SetSmallCellWidth(10);
                dgv.Columns["Title"].Width = clsUtils.SetSmallCellWidth(25);
                dgv.Columns["Description"].Width = clsUtils.SetSmallCellWidth(40);
                dgv.Columns["Fees"].Width = clsUtils.SetSmallCellWidth(25);

            }
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmEditTestType EditTestType = new frmEditTestType((int)dgv.CurrentRow.Cells[0].Value, (string)dgv.CurrentRow.Cells[1].Value, (string)dgv.CurrentRow.Cells[2].Value, (decimal)dgv.CurrentRow.Cells[3].Value);
            EditTestType.ShowDialog();
            RefreshData();
        }

        private void RefreshData()
        {
            dgv.DataSource = clsTest.GetTestTypes();
            lblRecordsNumber.Text = Convert.ToString(this.dgv.Rows.Count);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
