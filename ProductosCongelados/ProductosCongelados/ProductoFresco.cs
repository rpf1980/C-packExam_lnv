using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosCongelados
{
    class ProductoFresco: Producto
    {
        //Constructor
        public ProductoFresco(string fechaCaducidad,
                              int numeroLote,
                              string fechaEnvasado,
                              string paisOrigen) : base(fechaCaducidad, 
                                                        numeroLote,
                                                        fechaEnvasado,
                                                        paisOrigen)
        {     }

        //Métodos
        public override string ToString()
        {
            return $"Fecha de caducidad:                {GetFechaCaducidad()}" +
                   $"Número de lote:                    {GetNumeroLote()}" +
                   $"Fecha de envasado:                 {GetFechaEnvasado()}" +
                   $"País de origen:                    {GetPaisOrigen()}";
        }
    }
}
