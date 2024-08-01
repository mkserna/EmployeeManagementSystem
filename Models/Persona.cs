using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public abstract class Persona
    {
        protected Guid Id { get; set; }
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected int Edad { get; set; }

        public string GetNombre() => Nombre;
        public string GetApellido() => Apellido;  
        public int GetEdad() => Edad;

        public string SetNombre(string nombre) => Nombre = nombre;
        public string SetApellido(string apellido) => Apellido = apellido;
        public int SetEdad(int edad) => Edad = edad;

        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }
        public abstract void MostrarInformacionPersona();
    }
}