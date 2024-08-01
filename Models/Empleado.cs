using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Empleado(string nombre, string apellido, int edad, string numeroDeIdentificacion, string cargo, double salario) : Persona(nombre, apellido, edad)
    {
        public Guid Id { get; set; }
        public string NumeroDeIdentificacion { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        //Metodo bonificacion del 10% de salario
        private double CalcularBonificacion(double salario){
            double bonificacion = salario * 10 / 100;
            return bonificacion;
        }

        public override void MostrarInformacionPersona(){
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Numero de identificacion: {NumeroDeIdentificacion}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salario: {Salario}");
            Console.WriteLine($"Bonificacion: {CalcularBonificacion(Salario)}");
        }
    }
}