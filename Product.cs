using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Task - 2
//Asagidaki member-lerden ibaret Product class-i yaradin:
//Name - mehsulun adi
//Price - mehsulun qiymeti
//Count - mehsulun sayi
//TotalIncome - bu mehsulun satislarindan elde olunan umumi gelir
//Sell() - mehsulun satisi metodu.Bu metod Product-dan bir eded satilmasini ifade edir.Satis bas verdikde say azalir (productin sayi sifirdisa satis bas vere bilmez)
//income artir Name fieldininn value-su teyin olunmamsis bir product obyekti yaradila bilinmemelidir.
//Asagidaki memberlerden ibared Milk class - i yaradin ve Productdan miras verin:
//Volume - Bu xususiyyet Milkin hecmini ifade edir(Litr olaraq)
//FatRate - Bu xususiyyet sudun yagliliq faizini ifade edir(sudun nece faiz yagli oldugunu)
namespace OOPProductTask
{
        class Product
        {
            string Name;
            double Price;
            int Count;
            double TotalIncome = 1;


            public Product(string name)
            {
                Name = name;
            }
            public Product(string name, double price, int count) : this(name)
            {
                Price = price;
                Count = count;
            }

            public void Sell(int count)
            {

                if (!(count > Count))
                {
                    TotalIncome = Price * count;
                    Count = Count - count;
                Console.WriteLine($"{Name} Mehsulunun 1 Ededi {Price} Manatdir,Anbarda {Count} ededdir {TotalIncome} manat qazanc elde olunmusdur");

                }
                else
                {
                    Console.WriteLine("Mehsul anbarda bitmisdir");
                }

            }
            public string Info()
            {
                return $"{Name} Mehsulunun 1 Ededi {Price} Manatdir,Anbarda {Count} ededdir";
            }
        }
}







