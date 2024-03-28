using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.task2
{
    internal interface ISoftware
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        void ShowInfo();

        bool canUse(DateTime currentDate);
    }
}
