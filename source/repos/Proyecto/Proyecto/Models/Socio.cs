using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Models
{
    public class Socio
    {
        public int SocioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Domicilio { get; set; }

        /*
        public Socio(string nombre, string apellido, int edad, string domicilio)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Domicilio = domicilio;
        }



        */
    }
}
