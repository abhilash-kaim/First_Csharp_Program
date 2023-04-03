using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //ReadLine() will hold the console and show the output
            /*int abhilash = 34;
            string feel=Console.ReadLine();
            string emo="";
            if (feel == "happy")
            {
                emo = ":)";
            }else if(feel == "sad")
            {
                emo = ":(";
            }
            else
            {
                emo = "nothing";
            }
            float temp = 27.5F;
            bool answer=false;

            Console.Write("Sup!? ");
            Console.WriteLine("My name is cricket! I am "+abhilash+" years old");
            Console.WriteLine("I am feeling "+feel+"! "+emo);
            Console.WriteLine("The temperature today is " + temp + "F");
            if (feel=="sad") {
                answer=false;
            }else if (feel == "happy")
            {
                answer=true;
            }
            Console.WriteLine(answer);*/
            //that below is typecasting
            /*there are two types of typecasting
             1. Implicit Casting
                char to int to long to float to double
             2. Explicit Casting
             */
            double a = 3.5;
            Console.WriteLine(a);
            int b = 3;
            double y = a;
            float z = 'b';
             float var = Convert.ToInt64(34.234);
            string x = "34 is amazing";
            string sx = "Random string";
            Console.WriteLine(var);

            //Console.WriteLine(b);
            //Console.WriteLine(y);
            //Console.WriteLine(z); 
            //Console.ReadLine();
        }
    }
}
