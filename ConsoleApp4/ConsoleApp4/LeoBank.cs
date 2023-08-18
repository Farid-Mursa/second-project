using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class LeoBank:Card
    {
        public decimal PerIncrease { get; private set; }
        public decimal PerExtract { get; private set; }
        public LeoBank(string name, string surname, string cardNumber, int cVV, decimal balance, decimal perIncrease, decimal perExtract) :base(name,surname, cardNumber, cVV, balance)
        {
            PerIncrease = perIncrease;
            PerExtract= perExtract;

        }
        public override decimal Increase(decimal increase)
        {
            if (PerIncrease!=0)
            {
                decimal Per = increase;
                Per /= 100;
                Per *= PerIncrease;
                increase -= Per;
            }
            if (increase <= 0)
            {
                Console.WriteLine("The amount cant be zero or less than zero");
                return Balance;
            }

            return Balance += increase;
        }
        public override decimal Extract(decimal decrease)
        {
            if (PerExtract!=0)
            {
                decimal Per = decrease;
                Per /= 100;
                Per *= PerExtract;
                decrease += Per;
            }
            if (decrease <= 0)
            {
                Console.WriteLine("The amount cant be zero or less than zero");
                return Balance;
            }
            if (decrease > Balance)
            {
                Console.WriteLine("The amount you entered was higher than your balance");
                return Balance;
            }

            return Balance -= decrease;
        }
    }
}
