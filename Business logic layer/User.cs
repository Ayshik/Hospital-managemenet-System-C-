using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_managemenet_System.DataAccess_layer;

namespace Hospital_managemenet_System.Business_logic_layer
{
   public class User
    {
        DataAccess da = new DataAccess();

        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Catagory { get; set; }
        public string Status { get; set; }
        public string tp { get; set; }
        public string drid { get; set; }
        public string Star { get; set; }





    }
}
