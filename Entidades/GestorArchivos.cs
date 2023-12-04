using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Guarda la posicion donde se encontrara cada columna dentro de la lista de posiciones registrada por la empresa
    /// </summary>
    public enum EColumnasCsv
    {
        nombre = 0,
        apellido= 1,
        dni= 2,
        entidad= 3,
        tipoPlan= 4,
        numeroAfiliado= 5,
        interno= 6,
    }



    public class GestorArchivos
    {
        private string datosSerializados;
        private List<Paciente> pacientes;
        public List<string> pacientesNoCargados;
        public static string nombreArchivo;

        static GestorArchivos()
        {
            GestorArchivos.nombreArchivo = "registros.json";
        }
        

        public GestorArchivos() 
        { 
            this.pacientes = new List<Paciente>();
            this.pacientesNoCargados = new List<string>();
        }


        public List<Paciente> Pacientes { get => pacientes; set => pacientes = value; }
        public string DatosSerializados { get => datosSerializados; }

        /// <summary>
        /// Lee un archivo json
        /// </summary>
        /// <exception cref="Exception"></exception>
        /// <returns></returns>
        public void Leer()
        {
            try
            {              

                if (File.Exists(GestorArchivos.nombreArchivo))
                {
                    using (StreamReader streamReader = new StreamReader(GestorArchivos.nombreArchivo))
                    {
                        string archivoLeido = streamReader.ReadToEnd();
                        this.Pacientes = JsonSerializer.Deserialize<List<Paciente>>(archivoLeido);
                    }
                }
                else
                {
                    throw new Exception("Error, los pacientes no se encuentran cargados.\nDebe dirigirse a configuracion y seleccionar el archivo CSV");
                }

            }
            catch(Exception) 
            {
                throw;
            }

        }

        /// <summary>
        /// Lee un archivo CSV
        /// <exception cref="Exception"></exception>
        /// </summary>
        /// <param name="posiciones">En cada posicion contiene la posicion de las columnas requeridas</param>
        /// <returns></returns>
        public bool Leer(string rutaCSV,int[] posiciones)
        {
            try
            {
                if (rutaCSV is not null)
                {
                    using (StreamReader streamReader = new StreamReader(rutaCSV,Encoding.UTF8))
                    {
                        List<Paciente> registroObtenidos = new List<Paciente>();

                        bool flag = true;

                        //itero hasta que no haya mas por leer
                        while (!streamReader.EndOfStream)
                        {
                            //leo la linea
                            string linea = streamReader.ReadLine();
                            if (linea is not null)
                            {
                                if (flag) //para saltearme la primera linea del CSV
                                {
                                    flag = false;
                                    continue;
                                }

                                //valores de cada columna
                                string[] columnas = linea.Split(';');

                                if (columnas.Length < 7)
                                {
                                    this.pacientesNoCargados.Add(linea);
                                    continue;
                                }

                                Paciente paciente = new Paciente();
                            
                                paciente.Nombre = columnas[posiciones[(int)EColumnasCsv.nombre]].Trim();
                                paciente.Apellido = columnas[posiciones[(int)EColumnasCsv.apellido]].Trim();
                                paciente.TipoPlan = columnas[posiciones[(int)EColumnasCsv.tipoPlan]].Trim();
                                paciente.Entidad = columnas[posiciones[(int)EColumnasCsv.entidad]].Trim();
                                paciente.Credencial = columnas[posiciones[(int)EColumnasCsv.numeroAfiliado]].Trim();
                                paciente.Dni = columnas[posiciones[(int)EColumnasCsv.dni]].Trim();
                                paciente.Interno = columnas[posiciones[(int)EColumnasCsv.interno]].Trim();

                                //agrego el paciente a la lista de pacientes
                                this.Pacientes.Add(paciente);
                                

                            }
                            else
                            {
                                break;
                            }
                        }

                        return true;
                    }

                }

            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }

        /// <summary>
        /// Serializa los registros
        /// <exception cref="Exception"></exception>
        /// </summary>
        /// <returns></returns>
        public bool Serializar()
        {
            try
            {
                if (this.Pacientes is not null)
                {

                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;

                    this.datosSerializados = JsonSerializer.Serialize<List<Paciente>>(this.Pacientes,options);
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }

        public void Guardar()
        {
            try
            {

                using (StreamWriter streamWriter = new StreamWriter(GestorArchivos.nombreArchivo,false))
                {
                    if (this.DatosSerializados is not null)
                    {
                        streamWriter.WriteLine(this.DatosSerializados);                     
                    }
                    else
                    {
                        throw new PropiedadNullException("Error al guardar, la propiedad DatosSerializados se encuentra vacia");
                    }
                }
            }
            catch(PropiedadNullException)
            {
                throw;
            }
            catch(Exception)
            {
                throw;
            }

            
        }
    }
}
