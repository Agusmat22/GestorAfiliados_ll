using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IPrepaga
    {
        public string Entidad { get; set; }
        public string TipoPlan { get; set; }
        public string Credencial { get; set; }
        public string Interno { get; set; }
    }
}
