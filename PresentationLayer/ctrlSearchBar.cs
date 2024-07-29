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
    public partial class ctrlSearchBar : UserControl
    {
        public ctrlSearchBar()
        {
            InitializeComponent();

            //PopulateSearchableList(SearchableColumns);
        }

        private string SearchColumn;

        public string[] SearchableColumns
        {
            set
            {
                PopulateSearchableList(value);
            }
        }
        public DataView FilteredData { get; private set; }

        private DataView _unfilteredData;
        public DataView UnfilteredData
        {
            get { return _unfilteredData; }
            set
            {
                if (value != null)
                {
                    _unfilteredData = value;
                    FilteredData = new DataView(value.Table);
                }
                else
                {
                    _unfilteredData = null;
                    FilteredData = null;
                }
            }
        }

        private Type GetColumnType(DataView view, string columnName)
        {
            DataTable table = view.Table;

            if (table.Columns.Contains(columnName))
            {
                DataColumn column = table.Columns[columnName];
                return column.DataType;
            }
            else
            {
                throw new ArgumentException($"Column '{columnName}' does not exist in the DataView.");
            }
        }
        private void PopulateSearchableList(string[] SearchableColumns)
        {
            if (SearchableColumns != null)
            {
                foreach (string item in SearchableColumns)
                {
                    cbFilterList.Items.Add(item);
                }

                cbFilterList.SelectedIndex = 0;

            }
        }

        private void cbFilterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterList.SelectedIndex != 0)
            {
                tbSearch.Visible = true;
            }
            else
            {
                tbSearch.Visible = false;
            }

            SearchColumn = cbFilterList.SelectedItem.ToString().Replace(" ", "");
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            //DataView DataView = new DataView(Data);

            Type ColumnDataType = GetColumnType(UnfilteredData, SearchColumn);

            if (ColumnDataType == typeof(Int32))
            {
                int SearchTerm;
                int.TryParse(tbSearch.Text, out SearchTerm);

                if (tbSearch.Text != "")
                {
                    FilteredData.RowFilter = $"{SearchColumn} = {SearchTerm}";
                }
                else
                {
                    FilteredData.RowFilter = string.Empty;
                }
            }
            else
            {
                if (tbSearch.Text != "")
                {
                    FilteredData.RowFilter = $"{SearchColumn} LIKE '%{tbSearch.Text}%'";
                }
                else
                {
                    FilteredData.RowFilter = string.Empty;
                }
            }

            // Bind the filtered DataView to the DataGridView
            //dvg.DataSource = LocalData;
        }
    }
}
