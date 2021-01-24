using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        class MyDictonary<Tkey,Tvalue>
        {

            Tkey[] KArray;
            Tvalue[] VArray;
            Tkey[] TmpKArray;
            Tvalue[] TmpVArray;

            public MyDictonary()
            {
                KArray = new Tkey[0];
                VArray = new Tvalue[0];
            }


            public void Add(Tkey item1,Tvalue item2)
            {
                TmpKArray = KArray;
                TmpVArray = VArray;

                KArray = new Tkey[KArray.Length + 1];
                VArray = new Tvalue[VArray.Length + 1];

                for (int i = 0; i < TmpKArray.Length; i++)
                {
                    KArray[i] = TmpKArray[i];
                }
                for (int i = 0; i < TmpVArray.Length; i++)
                {
                    VArray[i] = TmpVArray[i];
                }
                KArray[KArray.Length - 1] = item1;
                VArray[VArray.Length - 1] = item2;
            }
            public Tkey[] item1
            {
                get { return KArray; }
            }

            public Tvalue[] item2
            {
                get { return VArray; }
            }
        }
        static void Main(string[] args)
        {
            MyDictonary<int, string> ogrenciler = new MyDictonary<int, string>();
            ogrenciler.Add(1,"Ahmet");
            ogrenciler.Add(2,"Mehmet");
            ogrenciler.Add(3,"Halit");
            ogrenciler.Add(4,"Süleyman");
            ogrenciler.Add(5,"Furkan");
            ogrenciler.Add(6,"Hikmet");
            ogrenciler.Add(7,"Murat");

            for (int i = 0; i < ogrenciler.item1.Length; i++)
            {
                Console.WriteLine("Öğrenci Numarası:"+ogrenciler.item1[i]+" Öğrenci'nin İsmi:"+ogrenciler.item2[i]);
            }

            Console.Read();
        }
    }
}
