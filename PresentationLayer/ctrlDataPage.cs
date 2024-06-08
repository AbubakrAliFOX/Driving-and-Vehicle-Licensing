using PeopleBussinessLayer;
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
        public ctrlDataPage(string Name, DataTable Data)
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(256, 0);
            this.Size = new System.Drawing.Size(1010, 478);
            this.TabIndex = 4;
            this.Name = Name;
            this.Data = Data;
            this.Visible = false;
        }

        private DataTable data = new DataTable();
        public DataTable Data
        {
            get { return data; }
            set { 
                data = value; 
                dvg.DataSource = this.Data;
            }
        }

    }
}
