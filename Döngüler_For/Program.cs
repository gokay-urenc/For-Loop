using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler_For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int sayac = 1; sayac <= 10; sayac++)
            {
                Console.WriteLine("Hello World.");
            }
            Console.ReadKey();
        }
    }
}
/* Döngü, belirli bir koşul gerçekleşene kadar süren ve bu süreç içerisinde bir takım işlemleri tekrarlı olarak gerçekleştiren nesnelerdir.
   Döngüler: For, While, Do - While, Foreach
   For'un bir başlangıç değeri, bir bitiş değeri ve bir artış miktarı vardır.
   (for <başlangıç değeri>; <bitiş değeri (koşul)>; artış - azalış miktarı)
   {
       <Döngünün koşulu sağlandığı (true) olduğu sürece çalışacak kodlar.>
   }
*/