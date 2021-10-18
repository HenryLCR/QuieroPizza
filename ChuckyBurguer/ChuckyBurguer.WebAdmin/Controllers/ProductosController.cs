using ChuckyBurguer.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChuckyBurguer.WebAdmin.Controllers
{
    public class ProductosController : Controller
    {
        //variable
        ProductosBL _productosBL;
        //CategoriasBL _categoriasBL;

        //constructor
        public ProductosController()
        {
            _productosBL = new ProductosBL();
            //_categoriasBL = new CategoriasBL();
        }


        // GET: Productos
        public ActionResult Index()
        {
            var listadeProductos = _productosBL.ObtenerProductos();
            return View(listadeProductos);
        }


        // Get: Crear
        public ActionResult Crear()
        {
            var nuevoProducto = new Producto();

            return View(nuevoProducto);
        }

        [HttpPost] // [HttpPost] : Atributo //es lo que retorna
        public ActionResult Crear(Producto producto)
        {
            _productosBL.GuardarProducto(producto);

            return RedirectToAction("Index");
        }

        //Get: Editar
        public ActionResult Editar(int id)
        {
            var Producto = _productosBL.ObtenerProducto(id);
            return View(Producto);
        }

        [HttpPost]
        //POst
        public ActionResult Editar(Producto producto)
        {
            _productosBL.GuardarProducto(producto);

            return RedirectToAction("Index");
        }


        //Detalle
        public ActionResult Detalle(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);
            return View(producto);
        }


        //Eliminar
        public ActionResult Eliminar(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);
            return View(producto);
        }


        [HttpPost]
        public ActionResult Eliminar(Producto producto)
        {
            _productosBL.EliminarProducto(producto.Id);
            return RedirectToAction("Index");
        }
    }
}