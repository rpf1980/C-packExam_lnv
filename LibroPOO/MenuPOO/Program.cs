using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos clase Libro
            Libro libro = new Libro("El Quijote", "Cervantes", 1, 0);

            //Instanciamos otro libro con el constructor por defecto
            Libro libro2 = new Libro();

            Console.Write("Título: ");
            string strTitulo = Console.ReadLine();

            Console.Write("Autor: ");
            string strAutor = Console.ReadLine();

            Console.Write("Ejemplares: ");
            int numeroEjemplares = int.Parse(Console.ReadLine());

            Console.Write("Prestamos: ");
            int numeroPrestamos = int.Parse(Console.ReadLine());

            libro2.SetAutor(strAutor);
            libro2.SetTitulo(strTitulo);
            libro2.SetNejemplares(numeroEjemplares);
            libro2.SetPrestamo(numeroPrestamos);

            //Mostramos ambos libros
            Console.WriteLine(libro.ToString());
            Console.WriteLine("-----------------------");
            Console.WriteLine(libro2.ToString());

            Console.ReadKey();
        }
    }
}
