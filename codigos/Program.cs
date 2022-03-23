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
            string respuesta = Console.ReadLine();
            int numElemtos = int.Parse(respuesta);
            int [] datos = new int[numElemtos];

            for (int i = 0; i < numElemtos; i++)
            {
                Console.WriteLine("Introduce el dato para posicion : " + i);
                respuesta = Console.ReadLine();
                int datosElemento = int.Parse(respuesta);
                datos[i] = datosElemento;
            }

            return datos;
        }
    }
}
