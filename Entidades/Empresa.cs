using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {
        private int[] posiciones;
        private string nombre;

        public Empresa(string nombre,int[] posiciones) 
        {
            this.posiciones = posiciones;
            this.nombre = nombre;
        }

        public int[] Posiciones { get => posiciones; set => posiciones = value; }
    }
}
