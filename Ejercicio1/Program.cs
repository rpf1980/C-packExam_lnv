using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        //Métodos aparte

        static int CuentaVocales(string c)
        {
            int contador = 0;
            string vocales = "aeiouAEIOUáéíóüÁÉÍÓÜ";
            int i, j;

            for (i = 0; i < c.Length; i++)
            {
                for (j = 0; j < vocales.Length; j++)
                {
                    if (c[i] == vocales[i])
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }
        static bool TieneVocalesDiferentes4(string palabra)
        {
            bool vocales;

            if (CuentaVocales(palabra) >= 4)
            {
                vocales = true;
            }
            else
            {
                vocales = false;
            }
            return vocales;
        }

        static void InfoFraseLeida(string frase)
        {
            //Informamos de cuántas palabras tiene la frase introducida
            string[] arrayFrase = frase.Split(' ');
            string vocales = "aeiou";
            string palabra = "";
            int contador = 0;

            for (int i = 0; i < arrayFrase.Length; i++)
            {
                palabra = arrayFrase[i];
                if(TieneVocalesDiferentes4(palabra))
                {
                    contador++;
                }
            }

            Console.WriteLine($"La frase tiene {arrayFrase.Length} palabras");
            Console.WriteLine($"Tiene {contador} palabras con mas de 4 vocales");

        }

        static void Main(string[] args)
        {
            //Leemos la frase
            Console.WriteLine("Escribe una frase: ");
            string frase = Console.ReadLine();

            //Aquí llamamos a la función creada InfoFraseLeida
            InfoFraseLeida(frase);

            Console.ReadKey();
        }
        
    }
}
