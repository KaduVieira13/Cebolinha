using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("|Digite uma frase|");
            Console.WriteLine("------------------");

            Console.WriteLine();
            string textoDigitado = Console.ReadLine();
            string RecebeTexto = textoDigitado.Replace("r", "l").Replace("R", "L").Replace("rr", "l").Replace("RR", "L");
            Console.WriteLine(RecebeTexto);
           

           
          
            

         
         

        }
    }
}
