using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHub_6._7
{
    public class UserOperation
    {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string Type { get; set; }
            public string Time { get; set; }

        public UserOperation(int userId,string type, string time) {
            UserId = userId;
            Type = type;
            Time = time;
        }
    }
}
