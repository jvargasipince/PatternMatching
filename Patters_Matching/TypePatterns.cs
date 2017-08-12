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
                CalcularFactorial(4);
                CalcularFactorialIncluyendoCadena("5");

                //Compilar con control + F5
            }

            public void CalcularFactorial(object o)
            {
                
                //int.TryParse() => no es necesario validarlo de esta forma
                if (o is null) return; // constant pattern
                if (!(o is int numero)) return; //type pattern (int)

                int total = 1;
                for (int contador = 1; contador <= numero; contador++)
                {
                    total *= contador;
                }

                WriteLine($"El factorial de {numero} es {total}");
                //ReadLine();
            }

            public void CalcularFactorialIncluyendoCadena(object o)
            {

                //int.TryParse() => no es necesario validarlo de esta forma
                if (o is null) return;
                if (!(o is int numero || o is string cadena && int.TryParse(cadena, out numero))) return;

                int total = 1;
                for (int contador = 1; contador <= numero; contador++)
                {
                    total *= contador;
                }

                WriteLine($"El factorial de {numero} es {total}");
                //ReadLine();
            }

        }

    }
}
