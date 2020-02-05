using System.Collections.Generic;

namespace StockControl.Models
{
    public class Proveedor
    {
        public int Id { get; set; }        
        public string Descripcion { get; set; }
        public ICollection<Articulo> Articulos { get; set; }
    }
}