using Test.Clases;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //INSTANCIAS

           /* Ejercicios intervalo = new Ejercicios();
            Console.WriteLine("Numero inicio");
            int numeroInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero final");
            int numeroFinal = int.Parse(Console.ReadLine());
            intervalo.Intervalo(numeroInicio, numeroFinal);*/

            Ejercicios multi =  new Ejercicios();
            Console.WriteLine("Ingresa un numero");
            int num = int.Parse(Console.ReadLine());
            multi.TablaMulti(num);
            



           
        }
    }
}