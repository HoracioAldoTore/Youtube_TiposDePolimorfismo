namespace PolimorfismoPorCoercion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            double b = 2.2;

            double mitad = MitadDe(a); //0.5
            mitad = MitadDe(b); //1.1
        }

        static double MitadDe(double dato)
        {
            return dato / 2;
        }
    }
}