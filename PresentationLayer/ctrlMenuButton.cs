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
        UserControl page;
        public ctrlMenuButton(string buttonText, string btnImage)
        {
            InitializeComponent();

            this.Tag = "MenuButton";
            btnMenuButton.Text = "        " + buttonText;
            btnMenuButton.Image = Image.FromFile($"E:\\Downloads\\WebDev\\Projects\\DVL\\Assets\\{btnImage}");
            pSidePanel.Visible = false;
        }

        public UserControl Page
        {
            get { return page; }
            set { page = value; }
        }
        public Control MainButton
        {
            get { return btnMenuButton; }
        }


        public Control SidePanel
        {
            get { return this.pSidePanel; }
        }

        public void Reset ()
        {
            this.btnMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(95))))); ;
            this.SidePanel.Visible = false;
            if (this.Page != null)
            {
                this.Page.Visible = false;
            }
        }

        public void Selected ()
        {
            this.btnMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(200))))); ;
            this.SidePanel.Visible = true;
            if (this.Page != null)
            {
                this.Page.Visible = true;
            }
        }

    }
}
