namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int valor = 20;
            var numero = "Pedro";
            Console.WriteLine("El nombre es: " + numero + " Y la edad es: " + valor);

            Console.WriteLine("El nombre es: {0} y la edad es: {1}", numero, valor);

            Console.WriteLine($"El nombre es: {numero} y la edad es: {valor}");

        }
    }
}
