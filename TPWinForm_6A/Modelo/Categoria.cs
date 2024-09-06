using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Categoria
    {

        public int Id { get;}
        public string Descripcion { get;}


        public Categoria(int id,string descripcion )
        {
            Id = id;
            Descripcion = descripcion;  
        }


    }
}
