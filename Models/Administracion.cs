using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Administracion
    {
        public static Empleado CrearEmpleado()
        {
            Console.Write($"Ingresa el nombre del empleado: "); string? nombre = Console.ReadLine();
            nombre = nombre.Trim();

            Console.Write($"Ingresa el apellido del empleado: "); string? apellido = Console.ReadLine();
            apellido = apellido.Trim();

            Console.Write($"Ingresa el numero de identificacion del empleado: "); string? numeroDeIdentificacion = Console.ReadLine();
            numeroDeIdentificacion = numeroDeIdentificacion.Trim();

            Console.Write($"Ingresa el edad del empleado: "); string? edad = Console.ReadLine();
            int edadInt = Convert.ToInt32(edad);

            Console.Write($"Ingresa el cargo del empleado: "); string? cargo = Console.ReadLine();
            cargo = cargo.Trim();

            Console.Write($"Ingresa el salario del empleado: "); string? salario = Console.ReadLine();
            double salarioDouble = Convert.ToDouble(salario);

            Empleado nuevoEmpleado = new Empleado(nombre, apellido, edadInt, numeroDeIdentificacion, cargo, salarioDouble);
            return nuevoEmpleado;
        }

        public static Cliente CrearCliente()
        {

            Console.Write($"Ingresa el nombre del cliente: "); string? nombre = Console.ReadLine();
            nombre = nombre.Trim();

            Console.Write($"Ingresa el apellido del cliente: "); string? apellido = Console.ReadLine();
            apellido = apellido.Trim();

            Console.Write($"Ingresa el edad del cliente: "); string? edad = Console.ReadLine();
            int edadInt = Convert.ToInt32(edad);

            Console.Write($"Ingresa el correo electronico del cliente: "); string? email = Console.ReadLine();
            email = email.Trim();

            Console.Write($"Ingresa el numerro de telefono del cliente: "); string? telefono = Console.ReadLine();
            telefono = telefono.Trim();

            Cliente nuevoCliete = new Cliente(nombre, apellido, edadInt, email, telefono);
            return nuevoCliete;
        }

        public static void MostrarTitulo(string titulo)
        {
            Console.Clear();
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(CentrarTexto(titulo, 50));
            Console.WriteLine(new string('=', 50));
        }

        public static void MostrarPie(string pie)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(CentrarTexto(pie, 50));
            Console.WriteLine(new string('-', 50));
        }

        public static void MostrarSeparador()
        {
            Console.WriteLine(new string('-', 50));
        }

        private static string CentrarTexto(string texto, int longitudTotal)
        {
            if (texto.Length >= longitudTotal)
                return texto;

            int espaciosIzquierda = (longitudTotal - texto.Length) / 2;
            int espaciosDerecha = longitudTotal - texto.Length - espaciosIzquierda;

            return new string(' ', espaciosIzquierda) + texto + new string(' ', espaciosDerecha);
        }
    }
}