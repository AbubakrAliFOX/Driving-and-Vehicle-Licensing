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
    public partial class ctrlFindPerson : UserControl
    {
        public ctrlFindPerson()
        {
            InitializeComponent();

            cbFilterList.SelectedIndex = 0;
        }

        public clsPerson PersonInfo
        {
            get { return ctrlPersonCard1.PersonInfo; }
            set
            {
                ctrlPersonCard1.PersonInfo = value;
            }
        }

        private string SearchColumn;


        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                if (SearchColumn == "PersonID")
                {
                    int SearchTerm;
                    int.TryParse(tbSearch.Text, out SearchTerm);

                    clsPerson GetPerson = clsPerson.Find(SearchTerm);

                    if (GetPerson != null)
                    {
                        PersonInfo = GetPerson;
                    } 
                    else
                    {
                        PersonInfo = null;
                    }
                }
                else
                {
                    clsPerson GetPerson = clsPerson.FindByNationalNo(tbSearch.Text);

                    if (GetPerson != null)
                    {
                        PersonInfo = GetPerson;
                    }
                    else
                    {
                        PersonInfo = null;
                    }
                }
            }
        }

        private void cbFilterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchColumn = cbFilterList.SelectedItem.ToString().Replace(" ", "");
        }
    }
}
