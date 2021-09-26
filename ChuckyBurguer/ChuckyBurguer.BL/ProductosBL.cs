using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckyBurguer.BL
{
    public class ProductosBL
    {
        //funcion ue devuelve lista de productos
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Hamburguesa Doble Carne";
            producto1.Precio = 250;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Chucky Burguer Economico";
            producto2.Precio = 125;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Burguer Roja";
            producto3.Precio = 245; 

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return listadeProductos;
        }
    }
}
