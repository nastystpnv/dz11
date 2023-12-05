using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    internal class BuildingCollection
    {
        private Building[] buildings;

        public BuildingCollection()
        {
            buildings = new Building[10]; 
        }
        public Building this[int buildingNumber]
        {
            get
            {
                if (buildingNumber >= 0 && buildingNumber < buildings.Length)
                {
                    return buildings[buildingNumber];
                }
                else
                {
                    throw new IndexOutOfRangeException("такого номера не существует");
                }
            }
        }
    }
}
