using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GestorEmpresa
    {
        private List<Paciente> afiliados;

        public GestorEmpresa()
        {
            this.afiliados = new List<Paciente>();
        }

        public GestorEmpresa(List<Paciente> afiliados)
        {
            this.afiliados = afiliados;
        }

        public List<Paciente> Afiliados { get => afiliados; set => afiliados = value; }

        /// <summary>
        /// Obtiene una lista de todos los pacientes que coincidan con el nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public List<Paciente> ObtenerAfiliadosPorNombre(string nombre)
        {
            List<Paciente> encontrados = new List<Paciente>();

            if (nombre != string.Empty)
            {
                
                foreach (Paciente item in this.afiliados)
                {
                    if (GestorEmpresa.BuscarAfiliado(item,nombre))
                    {
                        encontrados.Add(item);
                    }
                }
            }

            return encontrados;
        }
        /// <summary>
        /// Busca todas las coincidencias con el numero de credencial
        /// </summary>
        /// <param name="numeroCredencial"></param>
        /// <returns></returns>
        public List<Paciente> ObtenerAfiliadosPorCredencial(string numeroCredencial)
        {
            return this.afiliados.Where(af => af.Equals(numeroCredencial) == true).ToList();
        }

        /// <summary>
        /// Busca todos los pacientes que coincidan con ese DNI
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public List<Paciente> ObtenerAfiliadosPorDni(string dni)
        {
            return afiliados.Where<Paciente>(af => af.Dni.Contains(dni) == true ).ToList();
            
        }

        private static bool BuscarAfiliado(Paciente af,GestorEmpresa gestorEmpresa)
        {

            foreach (Paciente item in gestorEmpresa.Afiliados)
            {
                if (item == af)
                {
                    return true;
                }
            }
            return false;

        }

        /// <summary>
        /// Busca un afiliado por su nombre
        /// </summary>
        /// <param name="af"></param>
        /// <param name="nombre"></param>
        /// <returns></returns>
        private static bool BuscarAfiliado(Paciente af,string nombre)
        {
            //divido el nombre ingresado por el usuario
            string[] nombreSpliteado = nombre.ToUpper().Split(' ');
            int cantidadCoincidencias = 0;

            foreach (string item in nombreSpliteado)
            {
                if (af.ToString().Contains(item))
                {
                    cantidadCoincidencias++;    
                }
                else
                {
                    break;
                }
            }

            //la cantidad de elementos del nombre ingresado debe ser igual al total de coincidencias.
            if (cantidadCoincidencias == nombreSpliteado.Length)
            {
                return true;
            }

            return false;   

        }

        public bool AgregarAfiliado(Paciente paciente)
        {
            if (!GestorEmpresa.BuscarAfiliado(paciente,this))
            {
                try
                {
                    //agrego el paciente a la list
                    this.Afiliados.Add(paciente);

                    GestorArchivos gestorArchivos = new GestorArchivos();
                    //guardo la lista en el gestor de archivo
                    gestorArchivos.Pacientes = this.Afiliados;
                    //serializo la lista
                    gestorArchivos.Serializar();
                    //lo guardo en un .json
                    gestorArchivos.Guardar();

                    return true;
                }
                catch(Exception)
                {
                    throw;
                }
                
            }

            return false;
        }
    }
}
