using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    

    class Program
    {
        class Complejo
        {
            //Atributos
            private int real;
            private int imaginaria;

            //Constructores
            public Complejo() { }

            public Complejo(int real, int imaginaria)
            {
                this.real = real;
                this.imaginaria = imaginaria;
            }

            public int GetReal()
            {
                return this.real;
            }
            public void SetReal(int real)
            {
                this.real = real;
            }

            public int GetImaginaria()
            {
                return this.imaginaria;
            }
            public void SetImaginaria(int imaginaria)
            {
                this.imaginaria = imaginaria;
            }

            public string mostrar()
            {
                return $"{GetReal()} + {GetImaginaria()}i";
            }

            public Complejo Sumar(Complejo objeto1, Complejo objeto2)
            {
                Complejo complejoSumaResultado = new Complejo();

                int realResultado = objeto1.GetReal() + objeto2.GetReal();
                int imaginarioResultado = objeto1.GetImaginaria() + objeto2.GetImaginaria();

                //Asignamos los resultados al nuevo objeto, el que vamos a devolver
                complejoSumaResultado.SetReal(realResultado);
                complejoSumaResultado.SetImaginaria(imaginarioResultado);

                return complejoSumaResultado;
            }

            public Complejo Multiplicar(Complejo objeto, Complejo objeto2)
            {
                Complejo complejoSumaResultado = new Complejo();

                int a = objeto.GetReal() * objeto2.GetReal();
                int b = objeto.GetReal() * objeto2.GetImaginaria();
                int c = objeto.GetImaginaria() * objeto2.GetReal();
                int d = objeto.GetImaginaria() * objeto2.GetImaginaria();

                int res1 = a - d;
                int res2 = b + c;

                //Asignamos los resultados al nuevo objeto, el que vamos a devolver
                complejoSumaResultado.SetReal(res1);
                complejoSumaResultado.SetImaginaria(res2);

                return complejoSumaResultado;
            }

        }

        static void Main(string[] args)
        {
            Complejo c = new Complejo();

            //Pedimos datos al usuario
            Console.Write("Escribe parte entera real del primer elemento Complejo = ");
            int real1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Escribe parte entera imaginaria del primer elemento Complejo = ");
            int imaginaria1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Escribe parte entera real del segundo elemento Complejo = ");
            int real2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Escribe parte entera imaginaria del segundo elemento Complejo = ");
            int imaginaria2 = int.Parse(Console.ReadLine());


            //Test de la SUMA
            Complejo objeto1 = new Complejo(real1, imaginaria1);
            Complejo objeto2 = new Complejo(real2, imaginaria2);
            Complejo resultado1 = c.Sumar(objeto1, objeto2);

            string resSuma = resultado1.mostrar();
            Console.WriteLine(resSuma);


            //Test de la MULTIPLICACIÓN
            Complejo objeto3 = new Complejo(real1, imaginaria1);
            Complejo objeto4 = new Complejo(real2, imaginaria2);
            Complejo resultado2 = c.Multiplicar(objeto1, objeto2);

            string resMulti = resultado2.mostrar();
            Console.WriteLine(resMulti);


            Console.ReadKey();
        }
        
    }
}
