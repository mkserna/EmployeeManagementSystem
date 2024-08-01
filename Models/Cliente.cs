using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Cliente(string nombre, string apellido, byte edad, string email, string telefono) : Persona(nombre, apellido, edad)
    {
        public string Email { get; set; }
        public string Telefono { get; set; }

        public override void MostrarInformacionPersona(){
            base.MostrarInformacionPersona();
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefono: {Telefono}");
        }
    }
}