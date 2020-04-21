using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppzo_zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            //tworze obiekt daty
            OpisDaty data = new OpisDaty(1, 1, 1990);
            //drukuje na ekran stworzony obiekt
            Console.WriteLine(data.ShowData());
            //dodaje tydzien, a potem odejmuje tydzien
            data.addWeek();
            Console.WriteLine(data.ShowData());
            data.subWeek();
            Console.WriteLine(data.ShowData());
            Console.WriteLine("---------");
            //tworze nowy obiekt na pograniczu konca miesiąca i roku
            OpisDaty newData = new OpisDaty(27, 12, 1990);
            Console.WriteLine(newData.ShowData());
            Console.WriteLine("AddWeek");
            newData.addWeek();
            Console.WriteLine(newData.ShowData());
            Console.WriteLine("SubWeek");
            newData.subWeek();
            Console.WriteLine(newData.ShowData());
            Console.WriteLine("---------");
            //tworze obiekt niepoprawny
            OpisDaty errorDate = new OpisDaty(45, 13, 200);
            errorDate.ShowData();


            Console.ReadLine();
        }

        
    }
}
