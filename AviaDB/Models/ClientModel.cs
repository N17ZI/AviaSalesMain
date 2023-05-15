using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaDB.Models
{
    public class ClientModel
    {
        public int id_users { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Passport { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
