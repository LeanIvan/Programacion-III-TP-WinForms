namespace Modelo
{

    public class Articulo
    {

        public int Id { get; }
        public string Nombre { get; }
        public string Descripcion { get; }
        public int IdCategoria { get; }
        public int IdMarca { get; }

        private decimal precio;
        public decimal Precio
        {
            get { return precio; }
            private set
            {
                if (value >= 0)
                {
                    precio = value;
                }
            }
        }

      
        public Articulo(int id, string nombre, string descripcion, int idCategoria, int idMarca, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            IdCategoria = idCategoria;
            IdMarca = idMarca;
            Precio = precio; 
        }
    }

}
