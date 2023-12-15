using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emne3_PpUke5
{
    internal class Items
    {
        public string Name { get; set; }

        public Items(string name)
        {
            Name = name;
        }

        public void ShowItem()
        {
            Console.WriteLine($"Name: {Name}");
        }

    }
}
