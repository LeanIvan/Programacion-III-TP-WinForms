using System;
using System.Collections;
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
            List<Articulo> lista = new List<Articulo>();

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
                datos.setearParametro("IdMarca", articulo.IdMarca);
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

        public void Modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Descripcion = @descripcion, IdMarca = @idmarca, IdCategoria = @idcategoria, Precio = @precio where Id = @id");
            datos.setearParametro("@codigo", articulo.Codigo);
            datos.setearParametro("@descripcion", articulo.Descripcion);
            datos.setearParametro("@idmarca", articulo.IdMarca);
            datos.setearParametro("@idcategoria", articulo.IdCategoria);
            datos.setearParametro("@precio", articulo.Precio);
            datos.setearParametro("@id", articulo.Id);
            datos.ejecutarAccion();



            try
            {

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


        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE id = @id");
                datos.setearParametro("@id",id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //FILTRADO POR NOMBRE EXACTO , FALTA LO DEMAS , EN PROCESO...
        public List<Articulo> Filtrar(string busquedaNombre, string seleccionCategoria, string seleccionMarca)
        {   
            List<Articulo> listaFiltrada = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string Consulta = "select Id, Codigo, Nombre , Descripcion , IdMarca , IdCategoria , Precio FROM ARTICULOS WHERE Nombre like '" + busquedaNombre + "'";
                //RESTO DE LA CONSULTA , DA ERROR...
                //AND IdMarca = " + seleccionMarca + "AND IdCategoria=" + seleccionCategoria

                datos.setearConsulta(Consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];


                    listaFiltrada.Add(aux);
                }

                return listaFiltrada;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
