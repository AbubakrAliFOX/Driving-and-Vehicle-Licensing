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
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            RefreshData();

            if (dgv != null && dgv.RowCount > 0)
            {
                dgv.Columns["ID"].Width = clsUtils.SetSmallCellWidth(33);
                dgv.Columns["Title"].Width = clsUtils.SetSmallCellWidth(33);
                dgv.Columns["Fees"].Width = clsUtils.SetSmallCellWidth(33);

            }
        }

        private void RefreshData()
        {
            dgv.DataSource = clsApplication.GetApplicationTypes();
            lblRecordsNumber.Text = Convert.ToString(this.dgv.Rows.Count);
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmEditApplicationType EditApplicationType = new frmEditApplicationType((int)dgv.CurrentRow.Cells[0].Value, (string)dgv.CurrentRow.Cells[1].Value, (decimal)dgv.CurrentRow.Cells[2].Value);
            EditApplicationType.ShowDialog();
            RefreshData();
        }
    }
}
