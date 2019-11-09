using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosCongelados
{
    class Producto
    {
        //Atributos
        private string fechaCaducidad;
        private int numeroLote;
        private string fechaEnvasado;
        private string paisOrigen;

        //Constructor
        public Producto(string fechaCaducidad, int numeroLote,
            string fechaEnvasado, string paisOrigen)
        {
            this.fechaCaducidad = fechaCaducidad;
            this.numeroLote = numeroLote;
            this.fechaEnvasado = fechaEnvasado;
            this.paisOrigen = paisOrigen;
        }

        //Getter && Setter
        public string GetFechaCaducidad()
        {
            return this.fechaCaducidad;
        }
        public void SetFechaCaducidad(string fechaCaducidad)
        {
            this.fechaCaducidad = fechaCaducidad;
        }

        public int GetNumeroLote()
        {
            return this.numeroLote;
        }
        public void SetNumeroLote(int numeroLote)
        {
            this.numeroLote = numeroLote;
        }

        public string GetFechaEnvasado()
        {
            return this.fechaEnvasado;
        }
        public void SetFechaEnvasado(string fechaEnvasado)
        {
            this.fechaEnvasado = fechaEnvasado;
        }

        public string GetPaisOrigen()
        {
            return this.paisOrigen;
        }
        public void SetPaisOrigen(string paisOrigen)
        {
            this.paisOrigen = paisOrigen;
        }

        public override string ToString()
        {
            return $"Fecha de caducidad:        {GetFechaCaducidad()}" +
                   $"Numero de lote:            {GetNumeroLote()}" +
                   $"Fecha de envasado:         {GetFechaEnvasado()}" +
                   $"País de origen:            {GetPaisOrigen()}";
        }
    }
}
