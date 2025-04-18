namespace PolimorfismoPorHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emleado emleadoX;
            emleadoX = new Emleado();           //Sueldo = 100
            emleadoX = new EmleadoContratado(); //Sueldo = 200
            emleadoX = new EmleadoPorHora();    //Sueldo = 300
        }
    }

    class Emleado
    {
        public virtual int Sueldo { get; } = 100;
    }

    class EmleadoContratado : Emleado
    {
        public override int Sueldo { get; } = 200;      
    }

    class EmleadoPorHora : Emleado
    {
        public override int Sueldo { get; } = 300;
    }
}