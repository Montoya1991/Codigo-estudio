using System;

namespace codigos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElementos = LeerDatos();
            Console.WriteLine("Desde el Main");
            foreach (int i in arrayElementos)
            {
                Console.WriteLine(i);
            }
        }

        static int [] LeerDatos()
        {
            Console.WriteLine("Numero de elementos deseados en la arrays");
            string tamañoArray = Console.ReadLine();
            int numElemtos = int.Parse(tamañoArray);
            int [] datos = new int[numElemtos];

            for (int i = 0; i < numElemtos; i++)
            {
                Console.WriteLine("Introduce el dato para posicion : " + i);
                string valorCampo = Console.ReadLine();
                int datosElemento = int.Parse(valorCampo);
                datos[i] = datosElemento;
            }

            return datos;
        }
    }
}
