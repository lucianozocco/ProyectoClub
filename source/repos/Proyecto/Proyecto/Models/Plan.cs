using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Models
{
    public class Plan
    {
        public double Precio { get; set; }
        public int PlanId { get; set; }

        /*

        public Plan(double precio)
        {
            this.setPrecio(precio);
        }

        public void setPrecio(double precio)
        {
            if (precio > 0)
            {
                this.Precio = precio;
            } else
            {
                this.Precio = 0;
            }
        }

















        public string print()
        {
            return "Precio: " + this.Precio + ".";

        }

        */
    }
}
