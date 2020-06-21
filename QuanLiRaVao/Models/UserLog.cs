using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRaVao.Models
{
    public class UserLog
    {
        public string UserCode { get; set; }
        public DateTime TimeLog { get; set; } = DateTime.Now;
    }
}
