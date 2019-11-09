using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosCongelados
{
    class ProductoRefrigerado: Producto
    {      
        //Atributos
        private string codigoSupervision;
        private double temperaturaRecomendada;    

        //Constructor
        public ProductoRefrigerado(string fechaCaducidad,
                                   int numeroLote,
                                   string codigoSupervision,
                                   string fechaEnvasado,
                                   double temperaturaRecomendada, 
                                   string paisOrigen) : base (fechaCaducidad,
                                                              numeroLote,
                                                              fechaEnvasado,
                                                              paisOrigen)
        {
            this.codigoSupervision = codigoSupervision;
            this.temperaturaRecomendada = temperaturaRecomendada;
        }

        public string GetCodigoSupervision()
        {
            return this.codigoSupervision;
        }
        public void SetCodigoSupervision(string codigoSupervision)
        {
            this.codigoSupervision = codigoSupervision;
        }  

        public double GetTemperaturaRecomendada()
        {
            return this.temperaturaRecomendada;
        }
        public void SetTemperaturaRecomendada(double temperaturaRecomendada)
        {
            this.temperaturaRecomendada = temperaturaRecomendada;
        }      

        //Métodos
        public override string ToString()
        {
            return $"Fecha de caducidad:         {GetFechaCaducidad()}" +
                   $"Número de lote:             {GetNumeroLote()}" +
                   $"Código de supervisión:      {GetCodigoSupervision()}" +
                   $"Fecha de envasado:          {GetFechaEnvasado()}" +
                   $"Temperatura recomendada:    {GetTemperaturaRecomendada()}" +
                   $"País de origen:             {GetPaisOrigen()}";
        }
    }
}
