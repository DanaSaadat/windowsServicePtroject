using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace windowsServiceProject
{
    public class HeartBeart
    {
        private readonly Timer _timer;
        public HeartBeart()
        {
            _timer = new System.Timers.Timer(2000) { AutoReset = true };
            _timer.Elapsed += TimerElapsed;
        }
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            string[] LINES = new string[] { DateTime.Now.ToString() };
            //string[] LINES = new string[] { "dana","saadat" };
            //File.AppendAllLines(@"C:\Temp\demo\HeartBeart.txt", LINES);
            File.AppendAllLines(@"C:\Temp\Demo\danaNote.txt", LINES);
        }
       
        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

    }
}
