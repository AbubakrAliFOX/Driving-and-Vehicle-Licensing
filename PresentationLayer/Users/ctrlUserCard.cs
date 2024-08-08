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
    public partial class ctrlUserCard : UserControl
    {
        public ctrlUserCard()
        {
            InitializeComponent();
        }

        private clsUser _UserInfo;

        public clsUser UserInfo
        {
            get { return _UserInfo; }
            set
            {
                _UserInfo = value;
                if (_UserInfo != null)
                {
                    ctrlPersonCard1.PersonInfo = clsPerson.Find(_UserInfo.PersonID);
                    FillUserCard(_UserInfo);
                }
            }
        }

        private void FillUserCard(clsUser UserInfo)
        {
            lblUserID.Text = UserInfo.UserID.ToString();
            lblUserName.Text = UserInfo.UserName;
            lblIsActive.Text = UserInfo.IsActive ? "Yes" : "No";
        }
    }
}
