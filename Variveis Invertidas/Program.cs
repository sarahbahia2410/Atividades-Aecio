using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variveis_Invertidas
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;

            Console.WriteLine("Informe dois números, um para cada variável");
            Console.WriteLine("Para a variável A:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Para a variável B:");
            B = int.Parse(Console.ReadLine());
            A = A + B;     
            B = A - B;  
            A = A - B;
            Console.WriteLine("Vamos inverter as variáveis");
            Console.WriteLine("O novo valor da variável A:" +A);
            Console.WriteLine("O novo valor da variável B:" +B);
            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
        }
    }
}
