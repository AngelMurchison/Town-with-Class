using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town
{
   public class Bank : Building, IBuildable
    {
        public Bank(string buildingtype) : base(buildingtype) { }

        private double AmountofMoney { get; set; }
        public double DepositMoney(double deposit)
        {
            return AmountofMoney + deposit;
        }
        public double WithdrawMoney(double withdrawn)
        {
            return AmountofMoney - withdrawn;
        }
        string IBuildable.DisplayName(string Name)
        {
            return $"{Name}";
        }
        string IBuildable.ToString()
        {
            return $"{BuildingType}: {Name}";
        }

        static void Main(string[] args)
        {
        }
    }
}
