namespace StockControl.Models
{
    public class Articulo
    {
        public int Id { get; set; }        
        public string CodigoDeBarras { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public Proveedor Proveedor { get; set; }
        public int ProveedorId { get; set; }
    }
}