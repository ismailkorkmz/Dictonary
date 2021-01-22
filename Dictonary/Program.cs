using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> isim = new MyDictionary<int, string>();
            isim.Add(1, "İsmail");
            isim.Add(2, "Rabia");
            isim.Add(3, "İhsan");
            isim.Add(4, "Burak");
            isim.Add(5, "Mert");
            isim.Add(6, "Müge");
            isim.Add(7, "Gönül");
            

            Console.WriteLine(isim.Count);


            foreach (var item in isim.value)
            {
                Console.WriteLine(item);
            }
            foreach (var item in isim.keys)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Hello World!");
        }
    }
}
