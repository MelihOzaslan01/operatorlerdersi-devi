using System;
using System.Collections.Generic;
using System.Linq;



namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            global::System.Console.WriteLine("***** Atama ve İşlemli Atama *****");

            int x = 3;
            int y = 3;

            y = y + 2;
            global::System.Console.WriteLine(y);

            y += 2;
            global::System.Console.WriteLine(y);
            y /= 1;
            global::System.Console.WriteLine(y);
            x*=2;
            global::System.Console.WriteLine(x);

            global::System.Console.WriteLine(" ");



            global::System.Console.WriteLine("*****Mantıksal Operatörler ***** ");
            global::System.Console.WriteLine("|| , && , !");  

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                global::System.Console.WriteLine("Perfect!");



            if (isSuccess || isCompleted)
                global::System.Console.WriteLine("Great");



            if (isSuccess && !isCompleted)
                global::System.Console.WriteLine("Fine");

            global::System.Console.WriteLine(" ");


            global::System.Console.WriteLine("*****İlişkisel Operatörler *****");
            global::System.Console.WriteLine(" >, <, <=, >=, ==, !=");


            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            global::System.Console.WriteLine(sonuc);
            sonuc= a > b;
            global::System.Console.WriteLine(sonuc);
            sonuc = a >= b;
            global::System.Console.WriteLine(sonuc);
            sonuc=(a <= b);
            global::System.Console.WriteLine(sonuc);
            sonuc = (a == b) ;
            global::System.Console.WriteLine(sonuc);
            sonuc = (a != b);
            global::System.Console.WriteLine(sonuc);

            global::System.Console.WriteLine(" ");


            global::System.Console.WriteLine("***** Aritmetik Operatörler *****");
            global::System.Console.WriteLine("/ , * , +, - ");

            int sayi1 = 15;
            int sayi2 = 25;
            int sonuc1 = sayi1 / sayi2;
            global::System.Console.WriteLine(sonuc1);
            sonuc1= sayi1 + sayi2;
            global::System.Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            global::System.Console.WriteLine(sonuc1);
            sonuc1 = sayi2 - sayi1;
            global::System.Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            global::System.Console.WriteLine(sayi1);

            global::System.Console.WriteLine(" ");

            global::System.Console.WriteLine("***** % Mod ALır *****");
            int sonuc2 = 20 % 3;
            global::System.Console.WriteLine(sonuc2);





















        }

            


    }
    
}
