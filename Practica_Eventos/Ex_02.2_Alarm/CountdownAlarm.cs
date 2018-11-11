// Ex_02.2. 
//
// A countdown alarm program that uses delegates to 
// notify anyone who is interested that the designated 
// amount of time has passed. 
//
// You'll need a class to simulate the countdown clock 
// that accepts a message and a number of seconds to wait (supplied by the user). 
//
// After waiting the appropriate amount of time, 
// the countdown clock should call the delegate and 
// pass the message to any registered observers. 
//
// (When you're calculating the time to wait, remember that Thread.Sleep()
// takes an argument in milliseconds) 
//
// Create an observer class as well that echoes the received message to the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex_02._2_Alarm
{
    public class TimeEventArg : EventArgs
    {
        public int seconds;
        public string message;

        public TimeEventArg(int seconds, string message)
        {
            this.seconds = seconds;
            this.message = message;
        }
    }

    public class CountdownAlarm
    {
        public delegate void TimePassedHandler(object alarm, TimeEventArg tiInformation);
        public event TimePassedHandler TimePassed;

        private int seconds;
        private string message;

        public void SecondsToWaitRequest()
        {
            Console.Write("Ingrese segundos para la cuenta regresiva: ");
            if (int.TryParse(Console.ReadLine(),out int validSeconds))
            {
                this.seconds = validSeconds;
            }
        }

        public void MessageRequest()
        {
            Console.Write("Ingrese mensaje a mostrar una vez concluida la cuenta: ");
            this.message = Console.ReadLine();
        }

        public void Run()
        {
            while (true)
            {
                Thread.Sleep(1000);

                if (this.seconds == 0)
                {
                    TimeEventArg ti = new TimeEventArg(this.seconds, this.message);

                    if (TimePassed != null)
                    {
                        Console.WriteLine(this.seconds);
                        TimePassed(this, ti);
                    }
                    break;
                }
                Console.WriteLine(this.seconds);
                seconds--;
            }
        }
    }

    public class DisplayAlarm
    {
        public void Subscribe(CountdownAlarm alarm)
        {
            alarm.TimePassed += Alarm_TimePassed;
        }

        private void Alarm_TimePassed(object alarm, TimeEventArg tiInformation)
        {
            Console.WriteLine("\nCUENTA REGRESIVA CONCLUIDA!\n" + tiInformation.message);
        }
    }

    class Tester
    {
        public void Run()
        {
            CountdownAlarm alarm = new CountdownAlarm();

            alarm.SecondsToWaitRequest();
            alarm.MessageRequest();

            DisplayAlarm displayAlarm = new DisplayAlarm();
            displayAlarm.Subscribe(alarm);

            alarm.Run();
        }   
    }
}
