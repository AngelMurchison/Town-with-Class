using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town
{
class School
    {
        public string Name { get; set; }
        public string BuildingType { get; set; }
        public string DisplayName()
        {
            return $"{Name}";
        }
        public override string ToString()
        {
            return $"{BuildingType}: {Name}";
        }

        static void Main(string[] args)
        {
        }
    }
}
