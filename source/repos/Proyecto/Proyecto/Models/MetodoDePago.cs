using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Models
{
    public class Class1
    {

        public String Nombre { get; set; }
        public int MetodoId { get; set; }
        public Boolean EsPremium { get; set; }
        public TipoMetodo tipo { get; set; }

        public enum TipoMetodo
        {
            TarjetaCredito,
            ConvenioEmpresa,
            MercadoPago,
            TarjetaDebito,
            Efectivo
        }

        /*
        public MetodoDePago(String nombre, int metodoId, Boolean esPremium, TipoMetodo tipo)
        {
            this.SetNombre(nombre);
            this.SetMetodoId(metodoId);
            this.SetEsPremium(esPremium);
            this.SetMetodoTipo(tipo);
        }
      
        public void setNombre(String nombre)
        {
            this.Nombre = nombre;
        }

        public void SetNombre(String nombre)
        {
            this.Nombre = nombre;
        }

        public void SetMetodoTipo(TipoMetodo tipo)
        {
            this.tipo = tipo;
        }

        public void SetMetodoId(int id)
        {
            this.MetodoId = id;
        }

        public void SetEsPremium(Boolean esPremium)
        {
            this.EsPremium = esPremium;
        }

        */

    }
}
