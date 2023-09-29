using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Clases
{
    internal class Ejercicios
    {
        //LOOGICA
        /*
        public int Intervalo(int numeroInicio, int numeroFinal)
        {
            if (numeroInicio >= 0)
            {
                for (int i=0; i < numeroFinal; i++)
                {
                    return Intervalo(numeroInicio - 1, i);
                }
            }
        }*/
        public void TablaMulti(int num, int numeroMulti)
        {
            if (numeroMulti <= 10)
            {
                int resultado = num * numeroMulti;
                Console.WriteLine($"{num} * {numeroMulti} = {resultado}");
                TablaMulti(num, numeroMulti + 1);
            }
        }

    }
}
