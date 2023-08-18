namespace ConsoleApp4
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            LeoBank leobank = new("Ferid", "Mursaqulov", "4312421452134434",345,400, 0, 0);
            //Console.WriteLine(leobank.Increase(200));
            //Console.WriteLine(leobank.Extract(300));

            Unibank unibank = new("Ferid", "Mursaqulov", "4312421452134434", 345, 400, 1.5m, 0);
            //Console.WriteLine(unibank.Increase(100));
            //Console.WriteLine(unibank.Extract(300));
            AccessBank access = new("Ferid", "Mursaqulov", "4312421452134434", 345, 400, 1.6m, 0.3m);
            //Console.WriteLine(access.Increase(100));
            //Console.WriteLine(access.Extract(400));
            PashaBank pashaBank = new("Ferid", "Mursaqulov", "4312421452134434", 345, 400, 1.1m, 0.6m);
            //Console.WriteLine(pashaBank.Increase(100));
            //Console.WriteLine(pashaBank.Extract(398));
        }
    }
}