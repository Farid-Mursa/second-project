using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal abstract class Card
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string CardNumber { get; private set; }
        public int CVV { get; private set; }
        public decimal Balance { get ;protected set; }

        public abstract decimal Increase(decimal increase);
        public abstract decimal Extract(decimal decrease);

        public Card(string name, string surname, string cardNumber, int cVV, decimal balance)
        {
            Name = name;
            Surname = surname;
            CardNumber = cardNumber;
            CVV = cVV;
            Balance = balance;
        }
    }
}
