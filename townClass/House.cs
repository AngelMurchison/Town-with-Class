using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town
{
   public class House : Building, IBuildable
    {
        string IBuildable.DisplayName(string Name)
        {
            return $"{Name}";
        }
        string IBuildable.ToString()
        {
            return $"{BuildingType}: {Name}";
        }
        public House(string buildingtype):base(buildingtype)
        {
        }
        public int BedRooms { get; }
        public string DisplayName()
        {
            return $"{Name}";
        }
        public override string ToString()
        {
            return $"{BuildingType}: {Name}";
        }

        static void Main(string[] Args)
        {

        }
    }
}