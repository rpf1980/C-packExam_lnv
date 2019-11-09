using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPOO
{
    class Libro
    {
        //Atributos
        private string titulo;
        private string autor;
        private int ejemplares;
        private int prestados;

        //Constructores
        public Libro() { }

        public Libro(string titulo, string autor, int nEjemplares, int nPrestamos)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.ejemplares = nEjemplares;
            this.prestados = nPrestamos;
        }

        //Getter && Setter
        public string GetTitulo()
        {
            return this.titulo;
        }
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string GetAutor()
        {
            return this.autor;
        }
        public void SetAutor(string autor)
        {
            this.autor = autor;
        }
        public int GetNejemplares()
        {
            return this.ejemplares;
        }
        public void SetNejemplares(int nEjemplares)
        {
            this.ejemplares = nEjemplares;
        }
        public int GetPrestamo()
        {
            return this.prestados;
        }
        public void SetPrestamo(int nPrestamo)
        {
            this.prestados = nPrestamo;
        }

        //Métodos
        public bool Prestamo()
        {
            bool puedePrestar = false;
            int numeroEjemplaresDisponibles = GetNejemplares();

            if(numeroEjemplaresDisponibles != 0)
            {
                this.prestados++;
                puedePrestar = true;
            }

            return puedePrestar;
        }

        public bool Devolucion()
        {
            bool puedeDevolver = false;

            if(this.prestados > 0)
            {
                this.prestados--;
                puedeDevolver = true;
            }

            return puedeDevolver;
        }

        public override string ToString()
        {
            return $"Título:        {GetTitulo()}\n" +
                   $"Autor:         {GetAutor()}\n" +
                   $"Ejemplares:    {GetNejemplares()}\n" +
                   $"Prestados:     {GetPrestamo()}";
        }
    }
}
