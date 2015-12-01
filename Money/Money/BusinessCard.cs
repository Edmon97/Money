using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class BusinessCard
    {
        public int Money { get; set; }

        public void GetCount()
        {
            Console.WriteLine("Money: " + Money);
            Console.WriteLine("BusinessCard.GetCount");
        }

        public void AddMoney()
        {
            Console.WriteLine("BusinessCard.AddMoney");
        }
    }
}
