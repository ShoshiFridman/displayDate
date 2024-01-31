using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayDate
{
    public class time
    {
        static void main(string[] args)
        {
            Console.Write("Current Date and Time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();
        }
    }
}
