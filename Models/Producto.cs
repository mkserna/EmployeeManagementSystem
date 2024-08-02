using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Producto
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int CantidadDisponible { get; set; }

        public Producto(string nombre, string descripcion, double precio, int cantidadDisponible)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            CantidadDisponible = cantidadDisponible;
        }
        public void MostrarInformacionProducto()
        {
            Administracion.MostrarTitulo("INFORMACION DEL PRODUCTO");
            Console.WriteLine($"Nombre: {Nombre}");
            Administracion.MostrarSeparador();
            Console.WriteLine($"Descripcion: {Descripcion}");
            Administracion.MostrarSeparador();
            Console.WriteLine($"Precio: {Precio}");
            Administracion.MostrarSeparador();
            Console.WriteLine($"Cantidad en stock: {CantidadDisponible}");
            Administracion.MostrarPie("FIN DEL PRODUCTO");
        }
    }
}