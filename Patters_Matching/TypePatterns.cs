using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Patters_Matching
{
    class TypePatterns
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            factorial.execute();
        }

        public class Factorial
        {
            public void execute()
            {
                CalcularFactorial("5");
                CalcularFactorial(5);
            }

            public void CalcularFactorial(object o)
            {
                                
                if (o is null) return; // constant pattern
                if (!(o is int numero || o is string cadena && int.TryParse(cadena, out numero) )) return; //type pattern (int)

                int total = 1;
                for (int contador = 1; contador <= numero; contador++)
                {
                    total *= contador;
                }

                WriteLine($"El factorial de {numero} es {total}");
                
            }

        }

    }
}
