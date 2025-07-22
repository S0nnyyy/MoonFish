using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_07_2025
{
    class Stopky
    {
        private DateTime startTime;
        private DateTime endTime;
        public void Start()
        {
            startTime = DateTime.Now;
        }
        public void Stop()
        {
            endTime = DateTime.Now;
        }
        public TimeSpan ElapsedTime()
        {
            return endTime - startTime;
        }
        public string ToString()
        {
            return $"Elapsed time: {ElapsedTime()}";
        }
    }
}
