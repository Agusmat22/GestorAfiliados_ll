using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona, IPrepaga
    {
        
        public Paciente() : base()
        { 
        
        }

        public Paciente(string nombre,string apellido,string dni,string entidad,string plan,string credencial,string interno) 
            : base(nombre,apellido,dni)
        {
            this.Entidad = entidad;
            this.Plan = plan;
            this.Credencial = credencial;
            this.Interno = interno;
        }




        public string Entidad { get; set; }
        public string Plan { get; set; }
        public string Credencial { get; set; }
        public string Interno { get; set; }

        /// <summary>
        /// Compara por coincidencia un afiliado con un numero de afiliado
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {   //COMPARAR CON REGEX POR COINCIDENCIA Y NO POR IGUAL
            return obj is not null && obj is string numero && Regex.IsMatch(this.Credencial, $"{numero}");
        }


        
        
    }
}
