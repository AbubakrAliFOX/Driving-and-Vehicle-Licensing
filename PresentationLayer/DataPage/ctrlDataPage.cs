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
            //this.Location = new System.Drawing.Point(256, 0);
            //this.Size = new System.Drawing.Size(1010, 478);
            //this.Visible = false;
            this.DataGridView.RowHeadersWidth = 30;
        }

        public delegate void DataBackEventHandler(object sender, EventArgs e);

        public event DataBackEventHandler AddNewButton;

        private string _Title = "";
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                if(value != "")
                {
                    _Title = value;
                    lblTitle.Text = $"Manage {Title}";
                    RefreshData();
                    ctrlSearchBar1.SearchableColumns = SearchableColumns;
                }
            }
        }

        public string[] SearchableColumns
        {
            get
            {
                _SearchableColumns.TryGetValue(Title.Replace(" ", ""), out string [] SearchableItems);
                return SearchableItems;
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
            { "Users", clsUser.GetAllUsers },
            { "LocalDrivingLicenses", clsLocalDrivingLicensApplication.GetLocalDrivingLicenseApplications},
            { "InternationalDrivingLicenses", clsInternationalLicense.GetAllLicenses},
            { "DetainedLicenses", clsDetain.GetAllDetainedLicenses}
        };

        private Dictionary<string, string[]> _SearchableColumns = new Dictionary<string, string[]>
        {
            { "People", new string[] { "None", "Person ID", "National No", "Full Name", "Nationality", "Gender", "Phone", "Email" }},
            { "Drivers", new string[] { "None","Driver ID","National No","Created By User", "Active Licences" }},
            { "Users", new string[] { "None", "User ID", "Full Name", "User Name" }},
            { "LocalDrivingLicenses", new string[] { "None", "L.D.L.AppID", "National No", "Full Name", "Application Status" }},
            { "InternationalDrivingLicenses", new string[] { "None", "Int.License ID", "L.License ID", "Application ID", "Driver ID"}},
            { "DetainedLicenses", new string[] { "None", "Detain ID", "National No", "Full Name", "Release Application ID"}}
        };

        public void RefreshData ()
        {
            DataSources.TryGetValue(Title.Replace(" ",""), out var DataSourceTable);
            Data = DataSourceTable();
            RefreshRecordsNumber();
        }

        private void RefreshRecordsNumber ()
        {
            lblRecordsNumber.Text = ctrlSearchBar1.FilteredData.Count.ToString();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(AddNewButton != null)
            {
                AddNewButton.Invoke(this, e);
            } else
            {
                frmAddEditPerson addNewPersonForm = new frmAddEditPerson();
                addNewPersonForm.ShowDialog();
            }
            RefreshData();
        }
        public void SetAddNewClickEventHandler(EventHandler eventHandler)
        {
            btnAddNew.Click -= btnAddNew_Click; // Remove the default handler if needed
            btnAddNew.Click += eventHandler;
        }

        private void ctrlSearchBar1_FilterChanged(object sender, EventArgs e)
        {
            RefreshRecordsNumber();
        }
    }
}
