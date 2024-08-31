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
    public partial class ctrlMenuButton : UserControl
    {
        public ctrlMenuButton()
        {
            InitializeComponent();

        }

        private Dictionary<string, Image> ButtonImages = new Dictionary<string, Image>
        {
            { "People", Properties.Resources.people },
            { "Drivers", Properties.Resources.DriverImg },
            { "Users", Properties.Resources.Users },
            { "Applications", Properties.Resources.Application},
            { "Settings", Properties.Resources.Settings}
        };

        private string _ButtonName = "";

        public string ButtonName
        {
            get { return _ButtonName; }
            set
            {
                _ButtonName = value;
                this.Name = _ButtonName;
                btnMenuButton.Text = "        " + _ButtonName;

                ButtonImages.TryGetValue(_ButtonName, out Image FoundImage);

                ButtonImage = FoundImage;
            }
        }

        private Image ButtonImage
        {
            set
            {
                btnMenuButton.Image = value;
            }
        }

        private ctrlDataPage _Page;

        public ctrlDataPage Page
        {
            get { return _Page; }
            set { _Page = value; }
        }

        public Button Button
        {
            get { return btnMenuButton; }
        }


        private bool _IsActive;

        public bool IsActive
        {
            get { return _IsActive; }
            set 
            { 
                _IsActive = value;
                if (_IsActive)
                {
                    Selected();
                } else
                {
                    Reset();
                }
            }
        }

        public void Reset ()
        {
            btnMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(95))))); ;
            pSidePanel.Visible = false;
            if (Page != null)
            {
                Page.Visible = false;
            }
        }

        public void Selected ()
        {
            this.btnMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(200))))); ;
            pSidePanel.Visible = true;
            if (Page != null)
            {
                Page.Visible = true;
            }
        }
    }
}
