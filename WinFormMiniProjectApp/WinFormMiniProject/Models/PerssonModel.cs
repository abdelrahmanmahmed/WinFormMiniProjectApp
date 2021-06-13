using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormMiniProject.Models
{
    public class PerssonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();
    }
}
