using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Model
{

    public class CreateUserRequest
    {
        public string InitialBalance { get; set; }
        public string AccountName { get; set; }
        public string Address { get; set; }
    }

}
