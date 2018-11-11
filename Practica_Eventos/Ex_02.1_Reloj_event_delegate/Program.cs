// Example 02.1
//
// Using the event keyword 
// turns your delegate into an event, 
// and restricts other classes' ability 
// to interact with it to subscribing or unsubscribing
//
// Fix potential problems in example 02.0
//
// assign delegate by writing the shortened version

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloj_event_delegate
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
