using dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio, M.Descripcion Marca, C.Descripcion Categoria from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdCategoria = C.Id and A.IdMarca = M.id;");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Codigo = (string)datos.Lector["Codigo"];
                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }
                datos.cerrarConexion();

                //Mostrar articulos con Marca o Categoría nulas
                datos.setearConsulta("select * from ARTICULOS where IdMarca is null or IdCategoria is null;");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Codigo = (string)datos.Lector["Codigo"];
                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = 0;
                    aux.Marca.Descripcion = " ";
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = 0;
                    aux.Categoria.Descripcion = " ";
                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];
                    lista.Add(aux);
                }
                datos.cerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void agregar(Articulo articuloNew)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @imagenUrl, @precio)");
                datos.setearParametro("@codigo", articuloNew.Codigo);
                datos.setearParametro("@nombre", articuloNew.Nombre);
                datos.setearParametro("@descripcion", articuloNew.Descripcion);
                datos.setearParametro("@idMarca", articuloNew.Marca.Id);
                datos.setearParametro("@idCategoria", articuloNew.Categoria.Id);
                datos.setearParametro("@imagenUrl", articuloNew.ImagenUrl);
                datos.setearParametro("@precio", articuloNew.Precio);

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
        public void modificar(Articulo articuloMod)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @imagenUrl, Precio = @precio where Id = @id");
                datos.setearParametro("@id", articuloMod.Id);
                datos.setearParametro("@codigo", articuloMod.Codigo);
                datos.setearParametro("@nombre", articuloMod.Nombre);
                datos.setearParametro("@descripcion", articuloMod.Descripcion);
                datos.setearParametro("@idMarca", articuloMod.Marca.Id);
                datos.setearParametro("@idCategoria", articuloMod.Categoria.Id);
                datos.setearParametro("@imagenUrl", articuloMod.ImagenUrl);
                datos.setearParametro("@precio", articuloMod.Precio);

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
        public void eliminar(int idArt)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where Id = @id");
                datos.setearParametro("@id", idArt);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Articulo> filtrar(Marca marc, Categoria cat, string minimo, string maximo)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> listaFiltrada = new List<Articulo>();
            string consulta = "SELECT A.Id, Codigo, Nombre, A.Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio, M.Descripcion Marca, C.Descripcion Categoria from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdCategoria = C.Id and A.IdMarca = M.id";
            string consultaMarcaCategoria = filtrarMarcaCategoria(marc, cat);
            string consultaPrecio = filtrarPorPrecio(minimo, maximo);
            
            try
            {
                datos.setearConsulta(consulta + consultaMarcaCategoria + consultaPrecio);
                datos.setearParametro("@idMarca", marc.Id);
                datos.setearParametro("@idCategoria", cat.Id);
                if (minimo.Length > 0)
                {
                    decimal minimoD = decimal.Parse(minimo);
                    datos.setearParametro("@minimo", minimoD);
                }
                if (maximo.Length > 0)
                {
                    decimal maximoD = decimal.Parse(maximo);
                    datos.setearParametro("@maximo", maximoD);
                }

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Codigo = (string)datos.Lector["Codigo"];
                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Marca = new Marca();
                    if (marc.Id != 0)
                        aux.Marca = marc;
                    else
                    {
                        aux.Marca.Id = (int)datos.Lector["IdMarca"];
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    }
                    aux.Categoria = new Categoria();
                    if (cat.Id != 0)
                        aux.Categoria = cat;
                    else
                    {
                        aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    }
                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];

                    listaFiltrada.Add(aux);
                }
                return listaFiltrada;
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

        public string filtrarMarcaCategoria(Marca marc, Categoria cat)
        {
            if (marc.Id == 0 && cat.Id == 0)
                return "";
            else if (marc.Id != 0 && cat.Id == 0)
                return " and M.id = @idMarca";
            else if (marc.Id == 0 && cat.Id != 0)
                return " and C.id = @idCategoria";
            else
                return " and M.id = @idMarca and C.id = @idCategoria";
        }
        public string filtrarPorPrecio(string minimo, string maximo)
        {
            if (maximo.Length == 0 && minimo.Length == 0)
                return ";";
            else if (maximo.Length == 0 && minimo.Length > 0)
                return " and A.Precio > @minimo;";
            else if (maximo.Length > 0 && minimo.Length == 0)
                return " and A.Precio < @maximo";
            else  
                return " and A.Precio > @minimo and A.Precio < @maximo";
        }
    }
}