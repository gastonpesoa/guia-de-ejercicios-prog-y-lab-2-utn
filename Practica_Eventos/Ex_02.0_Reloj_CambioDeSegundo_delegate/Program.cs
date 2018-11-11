//Example 02.0 
//
// You can implement events with delegates 
// by setting up a publishing class with a 
// delegate and subscribing classes that handle the event
//
// Two potential problems:
//
// use the assignment operator (=) 
// rather than the subscribe operator (+=)
//
// other methods can call delegate SecondChangeHandler directly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloj_CambioDeSegundo_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
