using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckyBurguer.BL
{
    public class DatosdeInicio: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "admin";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");

            var nuevoUsuario1 = new Usuario();
            nuevoUsuario1.Nombre = "Henry";
            nuevoUsuario1.Contrasena = Encriptar.CodificarContrasena("195");

            var nuevoUsuario2 = new Usuario();
            nuevoUsuario2.Nombre = "Allan";
            nuevoUsuario2.Contrasena = Encriptar.CodificarContrasena("181");

            var nuevoUsuario3 = new Usuario();
            nuevoUsuario3.Nombre = "Billy";
            nuevoUsuario3.Contrasena = Encriptar.CodificarContrasena("201");

            contexto.Usuarios.Add(nuevoUsuario);
            contexto.Usuarios.Add(nuevoUsuario1);
            contexto.Usuarios.Add(nuevoUsuario2);
            contexto.Usuarios.Add(nuevoUsuario3);

            base.Seed(contexto);
        }
    }
}
