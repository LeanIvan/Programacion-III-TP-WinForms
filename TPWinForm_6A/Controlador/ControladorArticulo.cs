using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;



namespace Controlador
{
    public class ControladorArticulo
    {

      public List<Articulo> Listar()
        {
            List<Articulo>lista = new List<Articulo>();

            AccesoDatos Ad = new AccesoDatos();

            Ad.setearConsulta("select Id, Codigo, Nombre , Descripcion , IdMarca , IdCategoria , Precio FROM ARTICULOS");
            Ad.ejecutarLectura();

            while (Ad.Lector.Read())
            {

                Articulo aux = new Articulo();
                aux.Id = (int)Ad.Lector["Id"];
                aux.Codigo = (string)Ad.Lector["Codigo"];
                aux.Nombre = (string)Ad.Lector["Nombre"];
                aux.Descripcion = (string)Ad.Lector["Descripcion"];
                aux.IdMarca = (int)Ad.Lector["IdMarca"];
                aux.IdCategoria = (int)Ad.Lector["IdCategoria"];
                aux.Precio = (decimal)Ad.Lector["Precio"];


                lista.Add(aux);
            }


            Ad.cerrarConexion();

            return lista; 

        }


        public void Insertar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {

                datos.setearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,Precio,IdCategoria,IdMarca) values (@Codigo,@Nombre,@Descripcion,@Precio,@IdCategoria,@IdMarca)");
                datos.setearParametro("Codigo", articulo.Codigo);
                datos.setearParametro("Nombre", articulo.Nombre);
                datos.setearParametro("Descripcion", articulo.Descripcion);
                datos.setearParametro("Precio", articulo.Precio);
                datos.setearParametro("IdCategoria", articulo.IdCategoria);
                datos.setearParametro("IdMarca", articulo.IdCategoria);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();

            }

        }


      


    }
}
