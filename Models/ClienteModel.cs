using System.Collections.Generic;

using System;

namespace Contractors.Models
{

   

   
    public class Cliente
    {
        private string nombre;
        private string direccion;
        private List<OrdenDeTrabajo> historialTrabajosConcluidos;

        private List<OrdenDeTrabajo> trabajosActivosEnCurso;

        public String Nombre
        {
            get;
            set;

        }

        public String Direccion
        {
            get;
            set;

        }


        public List<OrdenDeTrabajo> HistorialTrabajosConcluidos
        {
            get;
            set;

        }

        public List<OrdenDeTrabajo> TrabajosActivosEnCurso
        {
            get;
            set;

        }



    }

}