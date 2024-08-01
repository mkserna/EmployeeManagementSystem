using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Cliente(string nombre, string apellido, int edad, string email, string telefono) : Persona(nombre, apellido, edad)
    {
        public string Email { get; set; }
        public string Telefono { get; set; }

        public override void MostrarInformacionPersona(){
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefono: {Telefono}");
        }
    }
}