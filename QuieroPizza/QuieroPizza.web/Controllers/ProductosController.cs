using QuieroPizza.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1
            producto1.Descripcion = "Pizza 6 Queso";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza 2 Queso";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Pizza de Peperoni";

            var producto4 = new ProductoModel();
            producto4.Id = 4;
            producto4.Descripcion = "Pizza Mia";

            var producto5 = new ProductoModel();
            producto5.Id = 5;
            producto5.Descripcion = "Pizza Hawaiana";

            var listdeproductos = new List<ProductoModel>();
            listdeproductos.Add(producto1);
            listdeproductos.Add(producto2);
            listdeproductos.Add(producto3);
            listdeproductos.Add(producto4);
            listdeproductos.Add(producto5);

            return View(listdeproductos);
        }
    }
}