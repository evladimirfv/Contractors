using System.Collections.Generic;

using System;

namespace Contractors.Models
{

   

    public class OrdenDeTrabajo
    {



        // Properties

        public int Id
        {
            get;
            set;

        }

        public string Tipo
        {
            get;
            set;
        }

        public DateTime FechaSolicitud
        {
            get;
            set;
        }
        public string Descripcion
        {
            get;
            set;
        }

        public int IdClienteContratante
        {
            get;
            set;
        }
        
        public int IdProfesionalSeleccionado
        {
            get;
            set;
        }

        public float NumeroDeHorasLaboradas
        {
            get;
            set;
        }
        public float ValorPorHoraPactado
        {
            get;
            set;
        }

        public bool Iniciado
        {
            get;
            set;
        }
        public bool Finalizado
        {
            get;
            set;
        }

        public bool Cancelado
        {
            get;
            set;
        }
        public float CalificacionDadaACliente
        {
            get;
            set;
        }
        public float CalificacionDadaAProfesional
        {
            get;
            set;
        }
        


    }
    


    

}