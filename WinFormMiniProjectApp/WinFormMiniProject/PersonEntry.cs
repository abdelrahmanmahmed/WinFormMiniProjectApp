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
    public partial class PersonEntry : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        
        public PersonEntry()
        {
            InitializeComponent();
            //addresses.Add(new AddressModel { StreetAddress = "JP1", City = "KL", State = "KL", ZipCode = "53300" });
            addressesList.DataSource = addresses;
            addressesList.DisplayMember = nameof(AddressModel.AddressDisplayValue);
        }

        
        private void addNewAddress_Click(object sender, EventArgs e)
        {
            AddressEntry addressEntry = new AddressEntry(this);
            addressEntry.Show();
                       
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void saveRecord_Click(object sender, EventArgs e)
        {
            PerssonModel person = new PerssonModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                IsActive = isActive.Checked,
                Addresses = addresses.ToList()
            };
        }
    }
}
