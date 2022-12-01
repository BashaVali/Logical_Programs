using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopWatch
    {
        DateTime dateTime = DateTime.Now;
        public void Start()
        {
            int startHr = dateTime.Hour;
            int startMin = dateTime.Minute;
            int startSec = dateTime.Second;
            int startMilliSec = dateTime.Millisecond;
            Console.WriteLine("Press s to start");
            string start = Console.ReadLine().ToLower();
            if (start.Equals("s"))
            {
                Console.WriteLine(startMilliSec);
                Console.WriteLine("Press x to exit");
                string stop = Console.ReadLine().ToLower();
                if (stop.Equals("x"))
                {
                    DateTime dateTime2 = DateTime.Now;
                    Console.WriteLine(dateTime2.Millisecond);
                    int stopHr = dateTime2.Hour;
                    int stopMin = dateTime2.Minute;
                    int stopSec = dateTime2.Second;
                    int stopMilliSec = dateTime2.Millisecond;
                    Console.WriteLine("StopWatch Details:- Hours:" + (stopHr - startHr) + " Minutes:" + (stopMin - startMin) + " Seconds:" + (stopSec - startSec) + " MilliSeconds:" + (stopMilliSec - startMilliSec));
                }
            }

        }
    }
}
