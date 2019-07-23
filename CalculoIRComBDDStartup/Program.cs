using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIRComBDDStartup
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;

            Console.Write("Valor do salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-----------------------");

            var calculoIR= new CalculoIR(salario);

            var salarioIR = calculoIR.CalcularSalario();

            Console.WriteLine($"Seu salário após descontar IR: {salarioIR.ToString("C2")}");
            Console.WriteLine($"Valor descontado: {(salario - salarioIR).ToString("C2")}");

            Console.WriteLine("-----------------------");

            Console.ReadKey();
        }
    }
}
