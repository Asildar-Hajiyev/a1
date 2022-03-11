using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAround
{
  public  class Vehicle
    {
        public string Cycle { get; set; }
        public double Motor { get; set; }
        public int DriveWay { get; set; }
        public string Color { get; set; }
        public int PassengerCount { get; set; }
        public int DriveTime { get; set; }

        public int GetSpeed(int getspeed)
        {
            return getspeed;
        }
    }
}
