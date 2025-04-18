namespace PolimorfismoPorSobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = Sumar(1, 3);  //4
            string conactena = Sumar("Llora ", "la calecita"); //Llora la calecita          
        }

        public static int Sumar(int a, int b)
        { return a + b; }

        public static string Sumar(string a, string b)
        { return string.Concat(a, b); }
    }
}