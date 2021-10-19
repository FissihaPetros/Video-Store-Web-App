using System.Collections.Generic;
using Video_Store_Web_App.Models;

namespace Video_Store_Web_App.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}