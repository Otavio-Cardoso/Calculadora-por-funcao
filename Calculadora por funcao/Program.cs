using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_por_funcao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma;

            soma = Calcular(30, 20, "+");
            Console.WriteLine(soma);
            Console.ReadKey();

        }
        static public int Calcular(int numero1, int numero2, string operacao)
        {
            int resultado = 0;
            if (operacao == "+")
            {
                resultado = numero1 + numero2;
            }
            else if (operacao == "*")
            {
                resultado = numero1 * numero2;
            }
            else if (operacao == "/")
            {
                resultado = numero1 / numero2;
            }
            else if (operacao == "-")
            {
                resultado = numero1 - numero2;
            }

            return resultado;
        }
    
    }
}
