using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Model
{
    public class CreateUserResponse
    {
        public string NewBalance { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string ErrorResponse { get; set; }
        public string sucessmessage { get; set; }

    }

    public class Root
    {
        public CreateUserResponse Data { get; set; }
        public string Message { get; set; }
    }
}
