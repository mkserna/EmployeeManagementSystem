using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Venta
    {
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public int Cantidad { get; set; }
        public List<Producto> Productos { get; set; }

        public Venta(int cantidad)
        {
            Cantidad = cantidad;
            Productos = new List<Producto>();
        }

        public void AgregarProducto()
        {
            Administracion.MostrarTitulo("AGREGANDO PRODUCTO");
            Console.WriteLine("Ingresa el nombre del producto: "); string? nombre = Console.ReadLine();
            nombre = nombre.Trim();
            Administracion.MostrarSeparador();

            Console.WriteLine("Ingresa la descripcion del producto: "); string? descripcion = Console.ReadLine();
            descripcion = descripcion.Trim();
            Administracion.MostrarSeparador();

            Console.WriteLine("Ingresa el precio del producto: "); string? precio = Console.ReadLine();
            double precioDouble = Convert.ToDouble(precio);
            Administracion.MostrarSeparador();

            Console.WriteLine("Ingresa la cantidad disponible del producto: "); string? cantidadDisponible = Console.ReadLine();
            int cantidadDisponibleInt = Convert.ToInt32(cantidadDisponible);
            Administracion.MostrarSeparador();

            Producto nuevoProducto = new Producto(nombre, descripcion, precioDouble, cantidadDisponibleInt);
            Productos.Add(nuevoProducto);
            Administracion.MostrarPie("PRODUCTO AGREGADO CON EXITO");
        }
        public void ActualizarProducto()
        {
            Administracion.MostrarTitulo("ACTUALIZANDO PRODUCTO");
            Console.WriteLine("Ingresa el nombre del producto que desea actualizar: "); string? nombre = Console.ReadLine();
            nombre = nombre.Trim();

            Producto producto = Productos.First(x => x.Nombre == nombre);

            if (producto != null)
            {
                Console.WriteLine($"Ingresa el nombre del producto o presiona Intro para mantener el mismo ({producto.Nombre}): "); string? nombreActualizado = Console.ReadLine();
                nombreActualizado = nombreActualizado.Trim();
                Administracion.MostrarSeparador();

                Console.WriteLine($"Ingresa la descripcion del producto o presiona Intro para mantener el mismo ({producto.Descripcion}): "); string? descripcion = Console.ReadLine();
                descripcion = descripcion.Trim();
                Administracion.MostrarSeparador();

                Console.WriteLine($"Ingresa el precio del producto o presiona Intro para mantener el mismo (${producto.Precio}): "); string? precio = Console.ReadLine();
                double precioDouble = Convert.ToDouble(precio);
                Administracion.MostrarSeparador();

                Console.WriteLine($"Ingresa la cantidad disponible del producto o presiona Intro para mantener el mismo ({producto.CantidadDisponible}): "); string? cantidadDisponible = Console.ReadLine();
                int cantidadDisponibleInt = Convert.ToInt32(cantidadDisponible);
                Administracion.MostrarSeparador();

                producto.Nombre = string.IsNullOrEmpty(nombreActualizado) ? producto.Nombre : nombreActualizado;
                producto.Descripcion = string.IsNullOrEmpty(descripcion) ? producto.Descripcion : descripcion;
                producto.Precio = precioDouble == 0 ? producto.Precio : precioDouble;
                producto.CantidadDisponible = cantidadDisponibleInt == 0 ? producto.CantidadDisponible : cantidadDisponibleInt;
                Administracion.MostrarTitulo("ACTUALIZACION REALIZADA");

            }
            else
            {
                Administracion.MostrarPie("PRODUCTO NO ENCONTRADO");
            }
        }
        public void MostrarProducros()
        {
            Administracion.MostrarTitulo("MOSTRAR PRODUCTOS");
            foreach (Producto producto in Productos)
            {
                producto.MostrarInformacionProducto();
            }
        }
        public void EliminarProducto()
        {
            Administracion.MostrarTitulo("ELIMINANDO PRODUCTO");
            Console.WriteLine("Ingresa el nombre del producto que desea eliminar: "); string? nombre = Console.ReadLine();
            nombre = nombre.Trim();

            Producto producto = Productos.First(x => x.Nombre == nombre);

            if (producto != null)
            {
                Productos.Remove(producto);
                Administracion.MostrarPie("PRODUCTO ELIMINADO CON EXITO");

            }
            else
            {
                Administracion.MostrarPie("PRODUCTO NO ENCONTRADO");
            }
        }
        public void BuscarProducto()
        {
            Administracion.MostrarTitulo("BUSCAR PRODUCTO");
            Console.WriteLine("Ingresa el nombre del producto que desea buscar: "); string? nombre = Console.ReadLine();
            nombre = nombre.Trim();
            if (Productos.Exists(p => p.Nombre == nombre))
            {
                Producto producto = Productos.First(p => p.Nombre == nombre);
                producto.MostrarInformacionProducto();
            }
            else
            {
                Administracion.MostrarPie("PRODUCTO NO ENCONTRADO");
            }
        }
        public void VerFactura()
        {

        }
    }
}