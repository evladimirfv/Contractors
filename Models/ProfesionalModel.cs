using System.Collections.Generic;

using System;

namespace Contractors.Models
{

 public enum ProfesionEnum{
        CARPINTERO,
        PLOMERO,
        CERRAJERO,
        JARDINERO,
        ELECTRICISTA
    }
    public class Profesional
    {
        private int id;
        private string nombre;
        private string profesion;
        private float rankingCalificacion;   // Calificación acumulada de trabajos realizados
        
      //  private List<OrdenDeTrabajo> historialOrdenesDeTrabajo;

      
      
      public int Id
      {
          get;
          set;

      }


        public string Nombre
        {
            get;
            set;

        }

        public string Profesion
        {
            get;
            set;

        }
        public double RankingCalificacion
        {
            get;
            set;

        }
        
//        public List<OrdenDeTrabajo> HistorialOrdenesDeTrabajo
//        {
//            get;
//            set;
//
//        }

    }  




}