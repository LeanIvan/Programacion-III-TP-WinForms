namespace Modelo
{

    public class Articulo
    {

        public int Id { get; set;}
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }
        public int IdMarca { get; set; }
        public decimal Precio { get; set; }
    
        //public decimal Precio
        //{
        //    get { return precio; }
        //    private set
        //    {
        //        if (value >= 0)
        //        {
        //            precio = value;
        //        }
        //    }
        //}




        //public Articulo(int id, string codigo, string nombre, string descripcion, int idCategoria, int idMarca, decimal precio)
        //{
        //    Id = id;
        //    Codigo = codigo;
        //    Nombre = nombre;
        //    Descripcion = descripcion;
        //    IdCategoria = idCategoria;
        //    IdMarca = idMarca;
        //    Precio = precio;
        //}
    }

}
