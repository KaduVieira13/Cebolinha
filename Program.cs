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
            string RecebeTexto = textoDigitado.Replace("rr","l").Replace("rR","l").Replace("RR","L").Replace("Rr","L").Replace("r","l").Replace("R","L");
            Console.WriteLine(RecebeTexto);

        }
    }
}
