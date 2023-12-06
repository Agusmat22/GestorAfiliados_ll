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
        private List<Empresa> empresas;
        public List<string> pacientesNoCargados;
        private string nombreArchivo;

        //EVENTO PARA USAR EL PROGRESSBAR
        //FALTA CREARLO

        public static string nombreArchivoEmpresas;
        public static string nombreArchivoAfiliados;

        static GestorArchivos()
        {
            GestorArchivos.nombreArchivoEmpresas = "empresas.json";
            GestorArchivos.nombreArchivoAfiliados = "afiliados.json";
        }
       
        public GestorArchivos() 
        { 
            this.pacientes = new List<Paciente>();
            this.pacientesNoCargados = new List<string>();
            this.nombreArchivo = "registros.json";
        }


        public List<Paciente> Pacientes { get => pacientes; set => pacientes = value; }


        public string DatosSerializados { get => datosSerializados; }
        public string NombreArchivo { get => nombreArchivo; set => nombreArchivo = value; }
        public List<Empresa> Empresas { get => empresas; set => empresas = value; }

        /*
        protected virtual void OnProgresoActualizado(int progreso)
        {
            OnProgresoDeCarga.Invoke(progreso);
        }*/

        /// <summary>
        /// Lee un archivo json y lo guarda en una propiedad de la clase, segun el tipo elegido
        /// </summary>
        /// <param name="tipo">Indicara el tipo de archivo que se leera, 'paciente' o 'empresa'</param>
        /// <exception cref="Exception"></exception>
        /// <returns></returns>
        public bool Leer(string tipo)
        {
            try
            {              

                if (File.Exists(this.NombreArchivo))
                {
                    using (StreamReader streamReader = new StreamReader(this.NombreArchivo))
                    {
                        string archivoLeido = streamReader.ReadToEnd();

                        if (tipo == "paciente")
                        {
                            this.Pacientes = JsonSerializer.Deserialize<List<Paciente>>(archivoLeido);
                        }
                        else if (tipo == "empresa")
                        {
                            this.Empresas = JsonSerializer.Deserialize<List<Empresa>>(archivoLeido);
                        }
                        
                    }

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch(Exception) 
            {
                throw;
            }

            

        }



        /// <summary>
        /// Lee un archivo CSV
        /// </summary>
        /// <exception cref="Exception"></exception>
        /// <param name="posiciones">En cada posicion contiene la posicion de las columnas requeridas</param>
        /// <returns></returns>
        public bool LeerAfiliados(string rutaCSV,int[] posiciones)
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
                                paciente.Plan = columnas[posiciones[(int)EColumnasCsv.tipoPlan]].Trim();
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
        /// </summary>
        ///<exception cref="Exception">Exception</exception>
        /// <returns></returns>
        public bool SerializarPacientes()
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

        public bool SerializarEmpresas()
        {
            try
            {
                if (this.Empresas is not null)
                {

                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;

                    this.datosSerializados = JsonSerializer.Serialize<List<Empresa>>(this.Empresas, options);
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="PropiedadNullException">Lanza una excepcion si la propiedad es null</exception>
        public void Guardar()
        {
            try
            {

                using (StreamWriter streamWriter = new StreamWriter(this.NombreArchivo,false))
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipoGuardado"></param>
        ///<exception cref="PropiedadNullException">Lanza una excepcion si la propiedad es null</exception>

        public void Guardar(bool tipoGuardado)
        {
            try
            {

                using (StreamWriter streamWriter = new StreamWriter(this.NombreArchivo, tipoGuardado))
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
            catch (PropiedadNullException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }


        }

        
    }
}
