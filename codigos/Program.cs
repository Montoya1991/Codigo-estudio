using System;

namespace codigos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //primer manera de crear un arrays o matriz
            int[] Matriz1;
            Matriz1 = new int[4];

            // almacenar datos en la arrays
            Matriz1[0] = 15;
            Matriz1[1] = 25;
            Matriz1[2] = 8;
            Matriz1[3] = 7;

            // Segunda manera de crear una Matriz
            int[] Matriz2 = new int [3];

            // tercera manera de crear una Matriz
            int[] Matriz3 = {15,25,8,7 };

            //------------------------------------------------------
            // Ejemplo

            int[] edades;

            edades = new int[4];

            edades[0] = 15;
            edades[1] = 27;
            edades[2] = 19;
            edades[3] = 80;

            Console.WriteLine("se mostrara lo almacenado en el campo 2 :"+ edades[2]);

            //______________________________________
            //forma abreviada del ejemplo anterior

            int[] edades2 = { 15, 27, 19, 80 };

            Console.WriteLine(edades2[2]);
        }
    }
}
