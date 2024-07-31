// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace EmployeeManagementSystem.Models
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             Empresa empresa = new Empresa();

//             bool continuar = true;
//             while (continuar)
//             {
//                 Console.WriteLine("------ Sistema de Gestión de Empleados ------");
//                 Console.WriteLine("1. Crear Empleado");
//                 Console.WriteLine("2. Modificar Empleado");
//                 Console.WriteLine("3. Eliminar Empleado");
//                 Console.WriteLine("4. Buscar Empleado");
//                 Console.WriteLine("5. Ver todos los empleados");
//                 Console.WriteLine("6. Ver empleados por cargo");
//                 Console.WriteLine("7. Salir");
//                 Console.Write("Ingrese su opción: ");
//                 Console.WriteLine("");
//                 int opcion = int.Parse(Console.ReadLine());
//                 switch (opcion)
//                 {
//                     case 1:
//                         empresa.AgregarEmpleado();
//                         break;
//                     case 2:
//                         empresa.ActualizarEmpleado();
//                         break;
//                     case 3:
//                         empresa.EliminarEmpleado();
//                         break;
//                     case 4:
//                         empresa.BuscarEmpleado();
//                         break;
//                     case 5:
//                         empresa.MostrarTodosLosEmpleados();
//                         break;
//                     case 6:
//                         empresa.MostrarEmpleadoPorCargo();
//                         break;
//                     case 7:
//                         continuar = false;
//                         break;
//                     default:
//                         Console.WriteLine("Opción no válida");
//                         break;
//                 }
//             }
//         }

//     }
// }