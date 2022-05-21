using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsola
{
    public class Persona
    {
        public string cedulaIdentidad { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }

        //Persona(string cedulaIdentidad, string nombre, string apellido, DateTime fechaNacimiento)
        //{
        //    this.cedulaIdentidad = cedulaIdentidad;
        //    this.nombre = nombre;
        //    this.apellido = apellido;
        //    this.fechaNacimiento = fechaNacimiento;
        //}

        public virtual void saludar() {
            Console.Write($"Hola me llamo {nombre} {apellido}\n");
        }
    }
}
