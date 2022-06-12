using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoeDeTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oi Vagner, vamos praticar um pouco de tipos numeros");

            float pontoFlutuante = 3.14f;
            Console.WriteLine(pontoFlutuante);

            double salario = 5270.50;
            int valor = (int) salario;
            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;
            Console.WriteLine(total);

            int idade = 3 * 10;
            Console.WriteLine(idade);


            Console.WriteLine("Fim do Programa pressione enter para Sair ...");
            Console.ReadLine();
        }
    }
}
