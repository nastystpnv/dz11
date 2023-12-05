using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    internal class Building
    {
        int buildingNumber { get; set; }
        int high { get; set; }
        int floor { get; set; }
        int flat { get; set; }
        int padic { get; set; }
        public Building(int buildingNumber, int high, int floor, int flat, int padic)
        {
            this.buildingNumber = buildingNumber;
            this.high = high;
            this.floor = floor;
            this.flat = flat;
            this.padic = padic;
        }
    }

}
