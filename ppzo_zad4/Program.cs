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

            OpisDaty data = new OpisDaty(1, 1, 1990);
            Console.WriteLine(data.ShowData());

            data.addWeek();

            Console.WriteLine(data.ShowData());

            Console.WriteLine("Koniec roku");
            OpisDaty newData = new OpisDaty(27, 12, 1990);
            Console.WriteLine(newData.ShowData());
            Console.WriteLine("AddWeek");
            newData.addWeek();
            Console.WriteLine(newData.ShowData());
            Console.WriteLine("SubWeek");
            newData.subWeek();
            Console.WriteLine(newData.ShowData());


            OpisDaty errorDate = new OpisDaty(45, 13, 200);
            errorDate.ShowData();
            Console.ReadLine();
        }

        
    }
}
