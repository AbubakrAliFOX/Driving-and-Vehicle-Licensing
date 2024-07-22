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
    public partial class ctrlDataPage : UserControl
    {
        public ctrlDataPage(string Title, DataTable Data)
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(256, 0);
            this.Size = new System.Drawing.Size(1010, 478);
            this.TabIndex = 4;
            this.Visible = false;
            this.dvg.RowHeadersWidth = 30;

            lblTitle.Text = $"Manage {Title}";
            this.Data = Data;
            lblRecordsNumber.Text = Convert.ToString(this.Data.Rows.Count);
            //CreateTableWithData(Data);
        }

        private DataTable data = new DataTable();
        public DataTable Data
        {
            get { return data; }
            set
            {
                data = value;
                dvg.DataSource = this.Data;
            }
        }

        public DataGridView dgv
        {
            get { return this.dvg; }
        }

        public void CreateTable (DataTable dt)
        {
            DataTable localDataTable = dt;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewPerson addNewPersonForm = new AddNewPerson(-1);
            addNewPersonForm.ShowDialog();
        }
    }
}
