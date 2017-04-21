using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage());
        }

        public static String CreateMessage()
        {
            return "Hello, World";
        }
    }
}
