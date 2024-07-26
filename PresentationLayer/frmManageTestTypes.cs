using BusinessLayer;
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
            lblRecordsNumber.Text = Convert.ToString(this.dgv.Rows.Count);
        }

        private void SetupDataGridView()
        {
            dgv.DataSource = clsTest.GetTestTypes();
            if (dgv != null)
            {
                dgv.Columns["ID"].Width = 100;
                dgv.Columns["Title"].Width = 190;
                dgv.Columns["Description"].Width = 300;
                dgv.Columns["Fees"].Width = 100;

            }
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmEditTestType EditTestType = new frmEditTestType((int)dgv.CurrentRow.Cells[0].Value, (string)dgv.CurrentRow.Cells[1].Value, (string)dgv.CurrentRow.Cells[2].Value, (decimal)dgv.CurrentRow.Cells[3].Value);
            EditTestType.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
