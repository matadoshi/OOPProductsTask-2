using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProductTask
{
    
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
        class Milk : Product
        {
            double Volume;
            double FatRate;

            public Milk(string name, double price, int count, double volume, double fatrate) : base(name, price, count)
            {

                Volume = volume;
                FatRate = fatrate;

            }
            public string Info()
            {
                Console.Write(base.Info());
                return $", {Volume} litr hecminde, {FatRate} yagliligindadir.";
            }


        }
}


