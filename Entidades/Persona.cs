namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;

        public Persona()
        {

        }

        
        protected Persona(string nombre,string apellido, string dni) 
        { 
            this.nombre = nombre;
            this.apellido = apellido;   
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }

        public override string ToString()
        {
            return $"{this.nombre} {this.apellido}".ToUpper();
        }

        public static bool operator ==(Persona p1,Persona p2)
        {
            return p1.dni == p2.dni;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
    }
}