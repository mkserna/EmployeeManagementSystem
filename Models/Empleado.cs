using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Empleado
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroDeIdentificacion { get; set; }
        public byte Edad { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public Empleado(string nombre, string apellido, string numeroDeIdentificacion, byte edad, string cargo, double salario)
        {
            Nombre = nombre;
            Apellido = apellido;
            NumeroDeIdentificacion = numeroDeIdentificacion;
            Edad = edad;
            Cargo = cargo;
            Salario = salario;
        }

        //Metodo bonificacion del 10% de salario
        private double CalcularBonificacion(double salario){
            double bonificacion = salario * 10 / 100;
            return bonificacion;
        }

        public void MostrarInformacionEmpleado(){
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Numero de identificacion: {NumeroDeIdentificacion}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salario: {Salario}");
            Console.WriteLine($"Bonificacion: {CalcularBonificacion(Salario)}");
        }
    }
}