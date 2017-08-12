using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Patters_Matching
{
    class ConditionalSwitchCase
    {
        static void Main(string[] args)
        {

            Planilla planilla = new Planilla();
            planilla.execute();

            Write(Environment.NewLine);
            planilla.SwitchDemo(DateTime.Today);

            Write(Environment.NewLine);
            planilla.SwitchDemo("AS");

            Write(Environment.NewLine);
            planilla.SwitchDemo(10);
        }
    }

    public class Planilla
    {
        public void execute()
        {
            Empleado empleado = new ArquitectoSw();
            empleado.Nombre = "Jorge Vargas";
            empleado.AñosExperiencia = 8;
            (empleado as ArquitectoSw).Proyecto = "Migración a Azure";
            (empleado as ArquitectoSw).PersonasACargo = 5;
            (empleado as Developer).Lenguaje = "C#, Angular, TypeScript";
            (empleado as Developer).Nivel = "Senior";

            switch (empleado)
            {
                case ArquitectoSw arq:
                    Write($" El empleado {arq.Nombre} ");
                    Write(Environment.NewLine);
                    Write($" Con {arq.AñosExperiencia} años de experiencia ");
                    Write(Environment.NewLine);
                    Write($" Pertenece al proyecto {arq.Proyecto} ");
                    Write(Environment.NewLine);
                    Write($" Con {arq.PersonasACargo} personas a cargo ");
                    Write(Environment.NewLine);
                    Write($" Maneja los lenguajes {arq.Lenguage} ");
                    Write(Environment.NewLine);
                    Write($" A un nivel de {arq.Nivel}");
                    break;

                case Developer dev:
                    Write($" El empleado {dev.Nombre}");
                    Write(Environment.NewLine);
                    Write($"Con {dev.AñosExperiencia} años de experiencia");
                    Write(Environment.NewLine);
                    Write($"Maneja los lenguajes {dev.Lenguage}");
                    Write(Environment.NewLine);
                    Write($"A un nivel de {dev.Nivel}");
                    break;

                case Empleado emp:
                    Write($" El empleado {emp.Nombre}");
                    Write(Environment.NewLine);
                    Write($" Con {emp.AñosExperiencia} años de experiencia");
                    Write(Environment.NewLine);
                    Write($" No es developer ni arquitecto");
                    break;
            }

        }

        public void SwitchDemo(object c)
        {

            switch (c)
            {
                case string texto:
                    Write($" El valor {texto} es una cadena");
                    break;

                case int entero:
                    Write($" El valor {entero} es una entero");
                    break;

                case DateTime date:
                    Write($" El valor {date} es una fecha");
                    break;
            }


        }     
    }

    public class Empleado
    {
        public string Nombre { get; set; }
        public int AñosExperiencia { get; set; }
    }

    public class Developer : Empleado
    {
        public string Nivel { get; set; }
        public string Lenguaje { get; set; }
    }

    public  class ArquitectoSw : Developer
    {
        public string Proyecto;
        public int PersonasACargo;

    }
}
