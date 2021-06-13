using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormMiniProject.Models;

namespace WinFormMiniProject
{
    public partial class AddressEntry : Form
    {
        ISaveAddress _parent;
        public AddressEntry(ISaveAddress parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        private void saveAddressEntry_Click(object sender, EventArgs e)
        {
            AddressModel address = new AddressModel
            {
                StreetAddress = streetAddressText.Text,
                City = cityText.Text,
                State = stateText.Text,
                ZipCode = zipCodeText.Text
            };
             
            _parent.SaveAddress(address);

            this.Close();
        }
    }
}
