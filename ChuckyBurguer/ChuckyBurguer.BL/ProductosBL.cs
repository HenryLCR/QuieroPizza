using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckyBurguer.BL
{
    public class ProductosBL
    {
        //constructor
        Contexto _contexto;
        //propiedad
        public List<Producto> ListadeProductos { get; set; }
        //constructor
        public ProductosBL()
        {
            _contexto = new Contexto();
            ListadeProductos = new List<Producto>();
        }

        //funcion ue devuelve lista de productos
        public List<Producto> ObtenerProductos()
        {
            ListadeProductos = _contexto.Productos.ToList();
            return ListadeProductos;
        }


        //Esto es del Get: Crear
        public void GuardarProducto(Producto producto)
        {
            if (producto.Id == 0)
            {
                _contexto.Productos.Add(producto);
            }
            else
            {
                var productoExistente = _contexto.Productos.Find(producto.Id);

                productoExistente.Descripcion = producto.Descripcion;
                //productoExistente.CategoriaId = producto.CategoriaId;
                productoExistente.Precio = producto.Precio;
                
            }
            
            _contexto.SaveChanges();
        }

        // Esto es del Get: Editar
        public Producto ObtenerProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);
            return producto;
        }


        public void EliminarProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);
            _contexto.Productos.Remove(producto);
            _contexto.SaveChanges();
        }
    }
}
