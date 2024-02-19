using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prakt_16_02_24
{
    public class Bank
    {
        public int money { get; set; }
        public string name { get; set; }
        public int percent { get; set; }
        public Bank(int money, string name, int percent)
        {
            this.money = money;
            this.name = name;
            this.percent = percent;
        }
    }


}
