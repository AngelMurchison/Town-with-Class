﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town
{
   public class Bank
    {
        public Bank(string buildingtype)
        {
            this.BuildingType = buildingtype;
        }
        public string Name { get; set; }
        public string BuildingType { get; set; }
        public int NumberOfRooms { get; set; }
        public string ConstructionMaterial { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public int SquareFootage { get; set; }
        public int Floors { get; set; }
        public int BathRooms { get; }
        public int Volume { get; set; }
        public string Address1 { get; }
        public string Address2 { get; }
        public string city { get; }
        public string zip { get; }
        public string FullAddress
        {
            get
            {
                return $"{Address1}, {Address2}, {city}, {zip}";
            }
        }
        public int CurrentOccupants { get; set; }
        public int IncreaseOccupants()
        {
            return CurrentOccupants += 1;
        }
        public int DecreaseOccupants()
        {
            return CurrentOccupants -= 1;
        }
        private double AmountofMoney { get; set; }
        public double DepositMoney(double deposit)
        {
            return AmountofMoney + deposit;
        }
        public double WithdrawMoney(double withdrawn)
        {
            return AmountofMoney - withdrawn;
        }
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
