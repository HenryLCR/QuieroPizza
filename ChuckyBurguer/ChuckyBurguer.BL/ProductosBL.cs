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
    }
}
