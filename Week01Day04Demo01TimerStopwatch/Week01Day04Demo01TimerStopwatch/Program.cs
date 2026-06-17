using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week01Day04Demo01TimerStopwatch
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TimerStopWatch());
        }
    }
}

/* Timer Component
 * The timer has one event - Tick Event
 * which occurs once for every time period if the timer is ENABLED: Make sure it is enabled
 * 
 * Need to specify the time in milliseonds
 * Timers are required to implment animation or periodic events
 * Timer is not visible on the form 
 *
 *
 * Stopwatch allows us to start stopwatch so as to track time
 * 
 * Stopwatch myStopWatch = new System.Diagnostics.Stopwatch();
 * 
 * Properties: EllasedMilliseconds - The number of milliseconds that have passed
 *                                   since the stopwatch started
 * Methods :  start() , stop()
 * 
 */
