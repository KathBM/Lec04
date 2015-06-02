using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
           // {
             //   StreamReader streamReader = new StreamReader("Calculadora");
              //  Console.WriteLine(streamReader.ReadToEnd());
                //streamReader.Close();
            //}
            //catch(Exception ex)
            //{
              //  Console.WriteLine(ex.Message);
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine(ex.StackTrace);
            
            List<int> entrada = new List<int>();
            entrada.Add(4);
            entrada.Add(6);
            entrada.Add(20);
            entrada.Add(1);
            entrada.Add(11);
            entrada.Add(25);

            Calculadora laCalculadora = new Calculadora();

            List<int> salida =  laCalculadora.CalcularFibonacciDeLista(entrada);

            foreach (int i in salida)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
