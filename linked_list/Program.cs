using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList ld = new LinkedList();
            ld.AddData(56);
            ld.AddData(30);
            ld.AddData(70);
          
            ld.display();
            Console.WriteLine("---------");
            /*addprevious ad = new addprevious();
            ad.AddData(23);
            ad.AddData(24);
            ad.AddData(25);
            ad.AddData(26);
            ad.display();*/
         
        }
    }
}
