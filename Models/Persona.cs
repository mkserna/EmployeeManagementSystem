using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public byte Edad { get; set; }

        public Persona(string nombre, string apellido, byte edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }
        public void MostrarInformacionPersona(){
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Edad: {Edad}");
        }
    }
}