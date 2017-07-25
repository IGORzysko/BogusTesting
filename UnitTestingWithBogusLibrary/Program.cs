using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingWithBogusLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("name", "surname", "address");
            person.DisplayData();
        }
    }
}
