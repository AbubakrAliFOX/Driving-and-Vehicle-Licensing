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
        string Filter;
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

            cbFilterList.SelectedIndex = 0;
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

        private void cbFilterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterList.SelectedIndex != 0)
            {
                tbSearch.Visible = true;
            } else
            {
                tbSearch.Visible = false;
            }

            Filter = cbFilterList.SelectedItem.ToString().Replace(" ","");
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
       
            DataView dataView = new DataView(Data);

            if (Filter == "PersonID")
            {
                int SearchTerm;
                int.TryParse(tbSearch.Text, out SearchTerm);

                if (tbSearch.Text != "")
                {
                    dataView.RowFilter = $"PersonID = {SearchTerm}";
                }
            }
            else
            {
                dataView.RowFilter = $"{Filter} LIKE '%{tbSearch.Text}%'";
            }


            // Bind the filtered DataView to the DataGridView
            dvg.DataSource = dataView;
        }
    }
}
