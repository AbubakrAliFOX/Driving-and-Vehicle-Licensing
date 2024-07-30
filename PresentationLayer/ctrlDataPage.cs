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
        public ctrlDataPage()
        {
            InitializeComponent();

            FormatStyles();

        }
        private void FormatStyles()
        {
            this.Location = new System.Drawing.Point(256, 0);
            this.Size = new System.Drawing.Size(1010, 478);
            this.TabIndex = 4;
            this.Visible = false;
            this.DataGridView.RowHeadersWidth = 30;
        }

        private string _Title;
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
                lblTitle.Text = $"Manage {Title}";
                RefreshData();
            }
        }

        private string[] _SearchableColumns;
        public string[] SearchableColumns
        {
            get
            {
                return _SearchableColumns;
            }
            set
            {
                _SearchableColumns = value;
                ctrlSearchBar1.SearchableColumns = SearchableColumns;
            }
        }

        private DataTable _Data;
        public DataTable Data
        {
            get { return _Data; }
            set
            {
                _Data = value;

                ctrlSearchBar1.UnfilteredData = new DataView(Data);
                DataGridView.DataSource = ctrlSearchBar1.FilteredData;
                lblRecordsNumber.Text = ctrlSearchBar1.NumberOfRecords.ToString();
            }
        }

        public DataGridView dgv
        {
            get { return this.DataGridView; }
        }

        private Dictionary<string, Func<DataTable>> DataSources = new Dictionary<string, Func<DataTable>>
        {
            { "People", clsPerson.GetAllPeople },
            { "Drivers", clsDriver.GetAllDrivers },
            { "Users", clsUser.GetAllUsers }
        };
        
        private void RefreshData ()
        {
            DataSources.TryGetValue(Title, out var DataSourceTable);
            Data = DataSourceTable();
            RefreshRecordsNumber();
        }

        private void RefreshRecordsNumber ()
        {
            lblRecordsNumber.Text = ctrlSearchBar1.FilteredData.Count.ToString();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewPerson addNewPersonForm = new AddNewPerson(-1);
            addNewPersonForm.ShowDialog();
            RefreshData();
        }

        private void ctrlSearchBar1_FilterChanged(object sender, EventArgs e)
        {
            RefreshRecordsNumber();
        }
    }
}
