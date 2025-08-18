using System.Security.Cryptography.X509Certificates;

namespace MedicareLabs
{
    internal class Program
    {
        const int PAC = 15;
        const int PRU = 8;

        static void Main(string[] args)
        {
            
            int[,] Resultados = new int[PAC, PRU];
            int[] MinimoPrueba = new int[PRU] { 5, 10, 10, 20, 30, 40, 30, 50 };
            int[] MaximoPrueba = new int[PRU] { 20, 30, 40, 70, 80, 90, 120, 150 };
           

            Console.WriteLine("MedicareLabs");

            IngresarResultadosPruebas(Resultados);
            ContarPAcientesValorAbsoluto(Resultados, MaximoPrueba);
            CalcularPromedioPruebaEspecifica(Resultados);
            BuscarValorMinimoMAximoPacientes(Resultados);
            PorcentajeResultadosAnormales(Resultados);

        }

        public static void IngresarResultadosPruebas(int[,] Resultados)
        {
            int resultadosAnalisis;

            for (int i=0; i < PAC; i++)
            {
                Console.Write($"Paciente: {i + 1}");
                for (int j = 0; j < PRU; i++)
                {
                    do
                    {
                        Console.Write($"Ingrese el resultado de la resultadosAnalisis {j+1}");
                        resultadosAnalisis = Convert.ToInt32( Console.ReadLine() );
                    } while (resultadosAnalisis < 0);
                    Resultados[i,j] = resultadosAnalisis;
                }
            }
            Console.ReadKey();
            for (int i=0; i < PAC; i++)
            {
                Console.Write($"Paciente: {i + 1}");
                for(int j = 0; j < PRU; j++)
                {
                    Console.WriteLine($"Prueba: {j + 1}: {Resultados[i,j]}");
                }
            }
        }
        
       

        public static void ContarPAcientesValorAbsoluto(int[,] Resultados, int[] MaximoPrueba)
        {

        }
        public static void CalcularPromedioPruebaEspecifica(int[,] Resultados)
        {

        }
        public static void BuscarValorMinimoMAximoPacientes(int[,] Resultados)
        {

        }
        public static void PorcentajeResultadosAnormales(int[,] Resultados)
        {

        }
    }
}
