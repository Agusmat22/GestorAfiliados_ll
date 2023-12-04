using Entidades;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rutaCsv = @"C:\Users\Lisandro\Downloads\csvPrueba.csv";

            GestorArchivos gestor = new GestorArchivos();
            GestorEmpresa empresa;
            int[] pos = { 5, 4, 7, 1, 8, 2, 3 };
            try
            {
                if(gestor.Leer(rutaCsv,pos))
                {
                    /*
                    Console.WriteLine("En principio, se pudo leer correctamente");
                    List<Paciente> pacientesLeidos = gestor.Pacientes;

                    empresa = new GestorEmpresa(pacientesLeidos);

                    
                    Console.WriteLine(empresa.ObtenerAfiliadosPorCredencial("9614078")[0]);
                    Console.WriteLine(empresa.ObtenerAfiliadosPorNombre("FAJARDO DEL VALLE")[0]);
                    Console.WriteLine(empresa.ObtenerAfiliadosPorDni("96140780")[0]);*/

                    

                    Paciente paciente = new Paciente();
                    paciente.Nombre = "mESSI";
                    paciente.Apellido = "jORGELIUZ";
                    paciente.Plan = "00";
                    paciente.Entidad = "PIRULIN";
                    paciente.Credencial = "45456454654";
                    paciente.Dni = "12123132";
                    paciente.Interno = "25";

                    gestor.Pacientes.Add(paciente);
                    gestor.Serializar();
                    gestor.Guardar();
                    Console.WriteLine("fin");

                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}