using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  class Program
  {
    static void Main(string[] args)
    {
      String firstName;
      String lastName;

      Console.Write("What is your first name: ");
      firstName = Console.ReadLine();

      Console.Write("What is your last name: ");
      lastName = Console.ReadLine();

      Console.WriteLine("Hello " + firstName + " " + lastName);


      Console.ReadKey();

    }
  }
}
