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
// using anonymous methods and lamda expressions

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Reloj_event_delegate
{
    
    // a class to hold the information about the event
    // in this case it will hold only information
    // available in the clock class, but could hold
    // additional state information
    public class TimeInfoEventArgs : EventArgs
    {
        public int hour;
        public int minute;
        public int second;
        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }

    // The publisher: the class that other classes
    // will observe. This class publishes one delegate:
    // SecondChangeHandler.
    public class Clock
    {
        // SecondChangedis an event, 
        // implemented by a delegate of type SecondChangeHandler

        // the delegate the subscribers must implement
        public delegate void SecondChangeHandler(object clock, TimeInfoEventArgs timeInformation);
        // an instance of the delegate with event keyword added
        // restricted access of SecondChanged using the keyword event.
        public event SecondChangeHandler SecondChanged;

        private int hour;
        private int minute;
        private int second;

        public void Run()
        {
            for (; ; )
            {
                // sleep 100 milliseconds
                Thread.Sleep(100);

                // get the current time
                DateTime dt = DateTime.Now;
                // if the second has changed
                // notify the subscribers
                if (dt.Second != second)
                {
                    // create the TimeInfoEventArgs object
                    // to pass to the subscriber
                    TimeInfoEventArgs timeInformation =
                            new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);

                    // if anyone has subscribed, notify them
                    if (SecondChanged != null)
                    {
                        SecondChanged(this, timeInformation);
                    }
                }

                // update the state
                this.second = dt.Second;
                this.minute = dt.Minute;
                this.hour = dt.Hour;
            }
        }
    }

    // A subscriber: DisplayClock subscribes to the
    // clock's events. The job of DisplayClock is
    // to display the current time
    public class DisplayClock
    {
        // given a clock, subscribe to
        // its SecondChangeHandler event.
        // assign delegate by writing the shortened version
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += TimeHasChanged;
        }

        // the method that implements the
        // delegated functionality
        public void TimeHasChanged(object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Current Time: {0}:{1}:{2}",
                ti.hour.ToString(), ti.minute.ToString(), ti.second.ToString());
        }
    }

    // a second subscriber whose job is to write to a file
    public class LogCurrentTime
    {
        public void Subscribe(Clock theClock)
        {
            // Anonymous methods allow you to pass a code block rather than the name of the method. 
            // This can make for code that is more efficient and easier to maintain, 
            // and the anonymous method has access to the variables in the scope in which they are defined.
            //
            // Notice that rather than registering an instance of a delegate, you use the keyword delegate, 
            // followed by the parameters that would be passed to your method, 
            // followed by the body of your method encased in braces and terminated by a semicolon.
            // This method has no name; hence, it is anonymous.
            // You cannot invoke the method except through the delegate; but that is exactly what you want
            theClock.SecondChanged += delegate (object aClock, TimeInfoEventArgs ti)
            {
                Console.WriteLine("Logging to file: {0}:{1}:{2}",
                ti.hour.ToString(), ti.minute.ToString(), ti.second.ToString());
            };

            // Example of lamda expressions
            // The lambda operator => is newly introduced in C# 3.0 and is read as "goes to". 
            // The left operand is a list of zero or more input parameters, 
            // and the right operand is the body of the lambda expression. 
            // Notice that => is an operator, which means that the preceding line of code is an expression. 
            // Just as x+x is an expression that returns a value-if x is 2, 
            // the expression returns the int value 4-a lambda expression is an expression that returns a method. 
            // It's not a method by itself. It's tricky to think of expressions as returning a method instead of a value, 
            //theClock.SecondChanged +=
            //    (aClock, ti) =>
            //    {
            //        Console.WriteLine("Current Time: {0}:{1}:{2}",
            //                           ti.hour.ToString(),
            //                           ti.minute.ToString(),
            //                           ti.second.ToString());
            //    };

            // Classes can no longer attempt to subscribe 
            // to the event using the assignment operator (=)
            //
            //theClock.SecondChanged = new Clock.SecondChangeHandler(WriteLogEntry);
        }
    }

    public class Tester
    {
        public void Run()
        {
            // create a new clock
            Clock theClock = new Clock();

            // create the display and tell it to
            // subscribe to the clock just created
            DisplayClock dc = new DisplayClock();
            dc.Subscribe(theClock);

            // create a Log object and tell it
            // to subscribe to the clock
            LogCurrentTime lct = new LogCurrentTime();
            lct.Subscribe(theClock);

            // Classes nor can they invoke the event directly
            //
            //Console.WriteLine("Calling the method directly!");
            //DateTime dt = DateTime.Now.AddHours(2);
            //TimeInfoEventArgs timeInformation =
            //    new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);
            //theClock.SecondChanged(theClock, timeInformation);

            // Get the clock started
            theClock.Run();
        }
    }
}
