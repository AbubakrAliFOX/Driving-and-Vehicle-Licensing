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
    public partial class ctrlApplicationDataPage : UserControl
    {
        public ctrlApplicationDataPage()
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(button1, button1.Width, 0);
        }

        private void ctrlApplicationDataPage_Load(object sender, EventArgs e)
        {
            rjDropdownMenu1.IsMainMenu = true;
        }
    }
}
