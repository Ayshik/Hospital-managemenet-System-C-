using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_managemenet_System.DataAccess_layer;

namespace Hospital_managemenet_System.Business_logic_layer
{
   public class Patient
    {
        DataAccess da = new DataAccess();
        public string UserName { get; set; }
       
        public string UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string Drfees { get; set; }
        public string Age { get; set; }
        public int Drid { get; set; }
        public string Room { get; set; }
        public string gender { get; set; }





    }
}
