using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Models
{
    public class Actividad
    {
        public int ActividadId { get; set; }
        public TipoActividad Tipo { get; set; }
        public int HorarioInicio { get; set; }
        public int HorarioFinal { get; set; }

        public enum TipoActividad
        {
            Gimnasio,
            Spinning,
            Funcional,
            Natacion,
            Boxeo
        }

        /*
       public Actividad(int horarioInicio, int horarioFinal, TipoActividad tipo)
        {
            this.setHorarioInicio(horarioInicio);
            this.setHorarioFinal(horarioFinal);
            this.Tipo = tipo;
        }

        public TipoActividad getTipo()
        {
            return this.Tipo;
        }
        public int getHorarioInicio()
        {
            return this.HorarioInicio;
        }
        public int getHorarioFinal()
        {
            return this.HorarioFinal;
        }
        public void setHorarioInicio(int horario)
        {
            if (horario > 0 && horario < 24)
            {
                this.HorarioInicio = horario;
            }
        }
        public void setHorarioFinal(int horario)
        {
            if (horario > 0 && horario < 24)
            {
                this.HorarioFinal = horario;
            }
        }

        public string print()
        {
            return "Tipo de Actividad: " + this.Tipo + ". Horario de inicio: " + this.HorarioInicio + ". Horario de finalizacion: " + this.HorarioFinal + ".";
           
        }


        */
    }
}
