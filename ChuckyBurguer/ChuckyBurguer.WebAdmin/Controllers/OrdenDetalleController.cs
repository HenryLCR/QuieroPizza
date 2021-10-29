using ChuckyBurguer.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChuckyBurguer.WebAdmin.Controllers
{
    public class OrdenDetalleController : Controller
    {
        OrdenesBL _ordenBL;
        ProductosBL _productosBL;

        public OrdenDetalleController()
        {
            _ordenBL = new OrdenesBL();
            _productosBL = new ProductosBL();
        }

        // GET: OrdenDetalle
        public ActionResult Index(int id)
        {
            var orden = _ordenBL.ObtenerOrden(id);
            return View(orden);
        }

        //crear
        public ActionResult Crear(int id)
        {
            var nuevaOrdenDetalle = new OrdenDetalle();
            nuevaOrdenDetalle.OrdenId = id;

            var productos = _productosBL.ObtenerProductos();

            ViewBag.ProductoId = new SelectList(productos, "Id", "Nombre");

            return View(nuevaOrdenDetalle);
        }


    }
}