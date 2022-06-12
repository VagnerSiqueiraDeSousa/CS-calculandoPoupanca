using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_calculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11, Calculando Poupança 2");

            double valorInvestido = 1000;
            int contadorMes = 1;


            for(int contador = 1; contador <= 12; contador++)
            {
                // valorInvestido = valorInvestido + valorInvestido * 0.0036;
                // valorInvestido = valorInvestido * 1.0036;
                valorInvestido *= 1.0036;
                Console.WriteLine("Após  " + contador + " Mes você terá R$: " + valorInvestido);
                
            }



            Console.ReadLine();
        }
    }
}
