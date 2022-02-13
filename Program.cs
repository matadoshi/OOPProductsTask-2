using System;
namespace OOPProductTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Product biscolata = new Product("biscolata",1.2,10);
            Console.WriteLine(biscolata.Info());
            Milk palsud = new Milk("Palsud",1.5,3,2,2.5);
            Console.WriteLine(palsud.Info());
            palsud.Sell(1);


        }
        
        




    }
}
