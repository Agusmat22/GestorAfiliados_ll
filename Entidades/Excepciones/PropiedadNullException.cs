using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class PropiedadNullException:Exception
    {
        public PropiedadNullException(string message):base(message) 
        { 
        }

        public PropiedadNullException(string message,Exception ex) : base(message, ex)
        {
        }

    }
}
