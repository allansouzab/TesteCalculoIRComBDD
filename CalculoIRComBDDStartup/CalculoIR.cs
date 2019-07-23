using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIRComBDDStartup
{
    public class CalculoIR
    {
        const double BASE_SALARIO_ISENTO = 1903.98;
        const double BASE_SALARIO_SETE_E_MEIO = 2826.65;
        const double BASE_SALARIO_QUINZE = 3751.05;
        const double BASE_SALARIO_VINTE_E_DOIS_E_MEIO = 4664.68;
        const double BASE_SALARIO_VINTE_E_SETE_E_MEIO = 4664.68;

        const double SETE_E_MEIO = 7.5;
        const double QUINZE = 15;
        const double VINTE_E_DOIS_E_MEIO = 22.5;
        const double VINTE_E_SETE_E_MEIO = 27.5;
        const double PORCENTAGEM = 100;

        private double salario;

        public CalculoIR(double _salario)
        {
            salario = _salario;
        }

        public double CalcularSalario()
        {
            if(salario <= BASE_SALARIO_ISENTO)
            {
                return salario;
            }
            if (salario > BASE_SALARIO_ISENTO && salario <= BASE_SALARIO_SETE_E_MEIO)
            {
                return salario - (salario * (SETE_E_MEIO / PORCENTAGEM));
            }
            if (salario > BASE_SALARIO_SETE_E_MEIO && salario <= BASE_SALARIO_QUINZE)
            {
                return salario - (salario * (QUINZE / PORCENTAGEM));
            }
            if (salario > BASE_SALARIO_QUINZE && salario <= BASE_SALARIO_VINTE_E_DOIS_E_MEIO)
            {
                return salario - (salario * (VINTE_E_DOIS_E_MEIO / PORCENTAGEM));
            }
            if (salario > BASE_SALARIO_VINTE_E_SETE_E_MEIO)
            {
                return salario - (salario * (VINTE_E_SETE_E_MEIO / PORCENTAGEM));
            }
            return 0;
        }
    }
}
