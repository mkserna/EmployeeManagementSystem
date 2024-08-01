using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Empleado> Empleados { get; set; }
        public List<Cliente> Clientes { get; set; }

        public Empresa(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        public void AgregarEmpleado()
        {

            Console.Write($"Ingresa el nombre del empleado: "); string? nombre = Console.ReadLine();
            nombre = nombre.Trim();

            Console.Write($"Ingresa el apellido del empleado: "); string? apellido = Console.ReadLine();
            apellido = apellido.Trim();

            Console.Write($"Ingresa el numero de identificacion del empleado: "); string? numeroDeIdentificacion = Console.ReadLine();
            numeroDeIdentificacion = numeroDeIdentificacion.Trim();

            Console.Write($"Ingresa el edad del empleado: "); string? edad = Console.ReadLine();
            byte edadByte = Convert.ToByte(edad);

            Console.Write($"Ingresa el cargo del empleado: "); string? cargo = Console.ReadLine();
            cargo = cargo.Trim();

            Console.Write($"Ingresa el salario del empleado: "); string? salario = Console.ReadLine();
            double salarioDouble = Convert.ToDouble(salario);

            Empleado nuevoEmpleado = new Empleado(nombre, apellido, edadByte, numeroDeIdentificacion, cargo, salarioDouble);

            Empleados.Add(nuevoEmpleado);
            Console.WriteLine("Empleado agregado con exito");
        }
        public void EliminarEmpleadoNombre()
        {
            Console.WriteLine($"");
            Console.Write("------ ELIMINANDO EMPLEADO ------");
            Console.Write($"Ingrese el nombre del empleado a eliminar: "); string? nombreEliminar = Console.ReadLine();
            nombreEliminar = nombreEliminar.Trim();
            Console.Write($"Ingrese el apellido del empleado a eliminar: "); string? apellidoEliminar = Console.ReadLine();
            apellidoEliminar = apellidoEliminar.Trim();

            if ((nombreEliminar != null) && (apellidoEliminar != null))
            {
                Empleado empleado = Empleados.Find((x) => x.Nombre == nombreEliminar && x.Apellido == apellidoEliminar);
                Empleados.Remove(empleado);
                Console.WriteLine("");
                Console.WriteLine("Empleado eliminado con exito");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("El empleado no existe");
            }
        }
        public void MostrarTodosLosEmpleados()
        {
            Console.WriteLine($"");
            Console.Write("------ MOSTRANDO TODOS LOS EMPLEADOS ------");
            Console.WriteLine($"");

            foreach (Empleado empleado in Empleados)
            {
                empleado.MostrarInformacionPersona();
                Console.WriteLine($"-------------------------------------");
            }
        }
        public void ActualizarEmpleado()
        {
            Console.WriteLine($"");
            Console.Write("------ ACTUALIZANDO EMPLEADO ------");
            Console.Write("Ingresa el numero de identificacion del empleado: "); string? numeroDeIdentificacion = Console.ReadLine();
            numeroDeIdentificacion = numeroDeIdentificacion.Trim();

            Empleado empleado = Empleados.Find(x => x.NumeroDeIdentificacion == numeroDeIdentificacion);

            if (empleado != null)
            {
                Console.Write($"Ingresa el nombre del empleado o presione enter para mantener el mismo ({empleado}): "); string? nombre = Console.ReadLine();
                nombre = nombre.Trim();

                Console.Write($"Ingresa el apellido del empleado o presione enter para mantener el mismo ({empleado}): "); string? apellido = Console.ReadLine();
                apellido = apellido.Trim();

                Console.Write($"Ingresa el numero de identificacion del empleado o presione enter para mantener el mismo ({empleado}): "); string? numeroDeIdentificacionActualizar = Console.ReadLine();
                numeroDeIdentificacion = numeroDeIdentificacion.Trim();

                Console.Write($"Ingresa la edad del empleado o presione enter para mantener el mismo ({empleado}): "); string? edad = Console.ReadLine();
                byte edadByte = Convert.ToByte(edad);

                Console.Write($"Ingresa el cargo del empleado o presione enter para mantener el mismo ({empleado}): "); string? cargo = Console.ReadLine();
                cargo = cargo.Trim();

                Console.Write($"Ingresa el salario del empleado o presione enter para mantener el mismo ({empleado}): "); string? salario = Console.ReadLine();
                double salarioDouble = Convert.ToDouble(salario);

                empleado.Nombre = string.IsNullOrEmpty(nombre) ? empleado.Nombre : nombre;
                empleado.Apellido = string.IsNullOrEmpty(apellido) ? empleado.Apellido : apellido;
                empleado.NumeroDeIdentificacion = string.IsNullOrEmpty(numeroDeIdentificacionActualizar) ? empleado.NumeroDeIdentificacion : numeroDeIdentificacionActualizar;
                empleado.Edad = edadByte;
                empleado.Cargo = string.IsNullOrEmpty(cargo) ? empleado.Cargo : cargo;
                empleado.Salario = salarioDouble;

                Console.WriteLine("");
                Console.WriteLine("Empleado actualizado con exito");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("El empleado no existe");
            }

        }
        public void BuscarEmpleado()
        {
            Console.WriteLine($"");
            Console.Write("------ BUSCANDO EMPLEADO ------");
            Console.WriteLine("Ingresa el numero de identificacion del empleado a buscar: "); 
            string? numeroDeIdentificacion = Console.ReadLine();
            numeroDeIdentificacion = numeroDeIdentificacion.Trim();

            Empleado empleado = Empleados.Find(x => x.NumeroDeIdentificacion == numeroDeIdentificacion);

            if (empleado != null)
            {
                empleado.MostrarInformacionPersona();
                Console.WriteLine($"-------------------------------------");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("El empleado no existe");
            }
        }
        public void MostrarEmpleadoPorCargo()
        {
            Console.WriteLine($"");
            Console.Write("------ BUSCANDO EMPLEADO POR CARGO ------");
            Console.WriteLine($"Ingresa el nombre del cargo a buscar: "); string? cargo = Console.ReadLine();
            cargo = cargo.Trim();

            Empleado empleado = Empleados.Find(x => x.Cargo == cargo);

            if (empleado != null)
            {
                empleado.MostrarInformacionPersona();
                Console.WriteLine($"-------------------------------------");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("El empleado no existe");
            }
        }

        public void AgregarCliente()
        {

            Console.Write($"Ingresa el nombre del cliente: "); string? nombre = Console.ReadLine();
            nombre = nombre.Trim();

            Console.Write($"Ingresa el apellido del cliente: "); string? apellido = Console.ReadLine();
            apellido = apellido.Trim();

            Console.Write($"Ingresa el numero de identificacion del cliente: "); string? numeroDeIdentificacion = Console.ReadLine();
            numeroDeIdentificacion = numeroDeIdentificacion.Trim();

            Console.Write($"Ingresa el edad del cliente: "); string? edad = Console.ReadLine();
            byte edadByte = Convert.ToByte(edad);

            Console.Write($"Ingresa el correo del cliente: "); string? email = Console.ReadLine();
            email = email.Trim();

            Console.Write($"Ingresa el edad del cliente: "); string? telefono = Console.ReadLine();
            telefono = telefono.Trim();

            Cliente nuevoCliete = new Cliente(nombre, apellido, edadByte, email, telefono);

            Clientes.Add(nuevoCliete);
            Console.WriteLine("Cliente agregado con exito");
        }

        public void EliminarClienteNombre()
        {
            Console.WriteLine($"");
            Console.Write("------ ELIMINANDO CLIENTE ------");
            Console.Write($"Ingrese el nombre del cliente a eliminar: "); string? nombreEliminar = Console.ReadLine();
            nombreEliminar = nombreEliminar.Trim();
            Console.Write($"Ingrese el apellido del empleado a eliminar: "); string? apellidoEliminar = Console.ReadLine();
            apellidoEliminar = apellidoEliminar.Trim();

            if ((nombreEliminar != null) && (apellidoEliminar != null))
            {
                Cliente cliente = Clientes.Find((x) => x.Nombre == nombreEliminar && x.Apellido == apellidoEliminar);
                Clientes.Remove(cliente);
                Console.WriteLine("");
                Console.WriteLine("Cliente eliminado con exito");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("El cliente no existe");
            }
        }

        public void MostrarTodosLosClientes()
        {
            Console.WriteLine($"");
            Console.Write("------ MOSTRANDO TODOS LOS CLIENTES ------");
            Console.WriteLine($"");

            foreach (Cliente cliente in Clientes)
            {
                cliente.MostrarInformacionPersona();
                Console.WriteLine($"-------------------------------------");
            }
        }

    }
}