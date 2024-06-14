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
        private bool _isClicked = false;
        public ctrlMenuButton(string buttonText, string btnImage)
        {
            InitializeComponent();

            this.Tag = "MenuButton";
            btnMenuButton.Text = "        " + buttonText;
            btnMenuButton.Image = Image.FromFile($"E:\\Downloads\\WebDev\\Projects\\DVL\\Assets\\{btnImage}");
            pSidePanel.Visible = false;
        }

        public Control MainButton
        {
            get { return btnMenuButton; }
        }


        public Control SidePanel
        {
            get { return this.pSidePanel; }
        }

        public void AddClickEventHandler(EventHandler eventHandler)
        {
            this.Click += eventHandler;
        }

        private void btnMenuButton_Click(object sender, EventArgs e)
        {
            if (_isClicked)
            {
                this.btnMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(95))))); ;
            } else
            {
                this.btnMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(200))))); ;
            }

            _isClicked = !_isClicked;
        }

    }
}
