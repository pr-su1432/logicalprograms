using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalprograms
{
    internal class stopwatch
    {
        public void watch()
        {
            Console.WriteLine("The stopwatch, press S to begin and Q to stop");
            var UserInput = Console.ReadLine();
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();

            switch (UserInput)
            {
                case "s":
                    stopWatch.Start(); ;
                    break;
                case "q":
                    stopWatch.Stop();

                    break;
                default:
                    Console.WriteLine("You did something wrong");
                    break;
            }

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value. 
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 2);
            Console.WriteLine("RunTime " + elapsedTime);

            Console.ReadLine();
        }
    }
}
