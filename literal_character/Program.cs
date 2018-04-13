using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace literal_character
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = -100;
            uint myUVar = 1000; // Unsigned integer أبحث في دروس متعمقة أخرى عن


            float myFVar = 1.5F; // أبحث عنه بتعمق في دروس أخرى
                                 // لا يقبل العشري ألا مع وجود حرف F

            double myDVar = 100.5; // أبحث عنه بتعمق في دروس أخرى
            decimal myDecVar = 100.5M; // أبحث عنه بتعمق في دروس أخرى 
                                      // لا يقبل العشري إلا مع وجود حرف M
            
            // الطريقة الجديده للطباعة جاءت مع أخر تحديث للسي شارب 
            //-------------
            Console.WriteLine($"int is {myVar} value\nUnsigned int is {myUVar}\nThe float is {myFVar}\nThe double is {myDVar}\nThe decimal is {myDecVar}");
            //-------------

            Console.ReadKey();
            Console.WriteLine("int = {0} unsigned int = {1}", myVar, myUVar);
            Console.ReadKey();

            Console.Write("hellow = {0} Hi = {1}",myVar,myUVar); // تأكد لماذا تعمل رايت عمل الرايت لاين بدون مشاكل
            Console.ReadKey();
        }
    }
}
