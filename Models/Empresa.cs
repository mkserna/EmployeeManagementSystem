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
            var nuevoEmpleado = Administracion.CrearEmpleado();
            Empleados.Add(nuevoEmpleado);
            Console.WriteLine("Empleado agregado con exito");
        }
        public void EliminarEmpleadoIdentificacion(){
            Console.WriteLine($"");
            Console.Write("------ ELIMINANDO EMPLEADO ------");
            Console.Write($"Ingrese el numero de identificacion del empleado a eliminar: "); string? numeroDeIdentificacion = Console.ReadLine();
            numeroDeIdentificacion = numeroDeIdentificacion.Trim();

            if (numeroDeIdentificacion != null)
            {
                Empleado empleado = Empleados.Find(x => x.NumeroDeIdentificacion == numeroDeIdentificacion);
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
                Console.Write($"Ingresa el nombre del empleado o presione enter para mantener el mismo ({empleado.GetNombre()}): "); string? nombre = Console.ReadLine();
                nombre = nombre.Trim();

                Console.Write($"Ingresa el apellido del empleado o presione enter para mantener el mismo ({empleado.GetApellido()}): "); string? apellido = Console.ReadLine();
                apellido = apellido.Trim();

                Console.Write($"Ingresa el numero de identificacion del empleado o presione enter para mantener el mismo ({empleado.NumeroDeIdentificacion}): "); string? numeroDeIdentificacionActualizar = Console.ReadLine();
                numeroDeIdentificacion = numeroDeIdentificacion.Trim();

                Console.Write($"Ingresa la edad del empleado o presione enter para mantener el mismo ({empleado.GetEdad()}): "); string? edad = Console.ReadLine();
                int edadInt = Convert.ToInt32(edad);

                Console.Write($"Ingresa el cargo del empleado o presione enter para mantener el mismo ({empleado.Cargo}): "); string? cargo = Console.ReadLine();
                cargo = cargo.Trim();

                Console.Write($"Ingresa el salario del empleado o presione enter para mantener el mismo ({empleado.Salario}): "); string? salario = Console.ReadLine();
                double salarioDouble = Convert.ToDouble(salario);

                empleado.SetNombre(string.IsNullOrEmpty(nombre) ? empleado.GetNombre() : nombre);

                empleado.SetApellido(string.IsNullOrEmpty(apellido) ? empleado.GetApellido() : apellido);

                empleado.NumeroDeIdentificacion = string.IsNullOrEmpty(numeroDeIdentificacionActualizar) ? empleado.NumeroDeIdentificacion : numeroDeIdentificacionActualizar;

                empleado.SetEdad(edadInt);

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
            var nuevoCliete = Administracion.CrearCliente();
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
                Cliente cliente = Clientes.Find((x) => x.GetNombre() == nombreEliminar && x.GetApellido() == apellidoEliminar);
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