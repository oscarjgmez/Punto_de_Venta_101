using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale
{
    public class CutSaleDataGrid
    {
        public int IdCorte { get; set; }
        public DateTime FechaDeCreación { get; set; }
    }

    public class ProductDataGrid
    {
        public int IdProducto { get; set; }
        public string CódigoBarras { get; set; }
        public string Nombre { get; set; }
        public float PrecioVenta { get; set; }
        public float Almacén { get; set; }
        public string Marca { get; set; }
        public string Familia { get; set; }
        public string Categoría { get; set; }
        public string SubCategoría { get; set; }
    }

    public class SaleDataGrid
    {
        public int IdVenta { get; set; }
        public float PrecioVenta { get; set; }
        public DateTime FechaDeVenta { get; set; }
    }
    public class ProdSaleDataGrid
    {
        public int IdProduct { get; set; }
        public string CódigoBarras { get; set; }
        public string Nombre { get; set; }
        public float PrecioVenta { get; set; }
        public int CantidadComprar { get; set; }
        public float Subtotal { get; set; }
    }
}
