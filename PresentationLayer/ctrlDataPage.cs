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


        }

        public ctrlDataPage(string Title, DataTable Data, string[] SearchableColumns = null)
        {
            InitializeComponent();

            FormatStyles(Title);

            this.Data = Data;

            ctrlSearchBar1.SearchableColumns = SearchableColumns;
            ctrlSearchBar1.UnfilteredData = new DataView(Data);
            dvg.DataSource = ctrlSearchBar1.FilteredData;

            lblRecordsNumber.Text = Convert.ToString(this.Data.Rows.Count);
        }

        //private string SearchColumn;

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

        private void FormatStyles (string Title)
        {
            this.Location = new System.Drawing.Point(256, 0);
            this.Size = new System.Drawing.Size(1010, 478);
            this.TabIndex = 4;
            this.Visible = false;
            this.dvg.RowHeadersWidth = 30;
            lblTitle.Text = $"Manage {Title}";
        }

        //private void PopulateSearchableList (string[] SearchableColumns)
        //{
        //    if(SearchableColumns != null)
        //    {
        //        foreach (string item in SearchableColumns)
        //        {
        //            cbFilterList.Items.Add(item);
        //        }

        //        cbFilterList.SelectedIndex = 0;

        //    }
        //}


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewPerson addNewPersonForm = new AddNewPerson(-1);
            addNewPersonForm.ShowDialog();
        }

        private void cbFilterList_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    if (cbFilterList.SelectedIndex != 0)
        //    {
        //        tbSearch.Visible = true;
        //    } else
        //    {
        //        tbSearch.Visible = false;
        //    }

        //    SearchColumn = cbFilterList.SelectedItem.ToString().Replace(" ","");
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
       
        //    DataView DataView = new DataView(Data);

        //    Type ColumnDataType = GetColumnType(DataView, SearchColumn);

        //    if (ColumnDataType == typeof(Int32))
        //    {
        //        int SearchTerm;
        //        int.TryParse(tbSearch.Text, out SearchTerm);

        //        if (tbSearch.Text != "")
        //        {
        //            DataView.RowFilter = $"{SearchColumn} = {SearchTerm}";
        //        }
        //    }
        //    else
        //    {
        //        DataView.RowFilter = $"{SearchColumn} LIKE '%{tbSearch.Text}%'";
        //    }

        //    // Bind the filtered DataView to the DataGridView
        //    dvg.DataSource = DataView;
        //}

        //private Type GetColumnType(DataView view, string columnName)
        //{
        //    DataTable table = view.Table;

        //    if (table.Columns.Contains(columnName))
        //    {
        //        DataColumn column = table.Columns[columnName];
        //        return column.DataType;
        //    }
        //    else
        //    {
        //        throw new ArgumentException($"Column '{columnName}' does not exist in the DataView.");
        //    }
        }

    }
}
