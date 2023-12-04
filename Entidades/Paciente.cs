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

       


        public string Entidad { get; set; }
        public string TipoPlan { get; set; }
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
