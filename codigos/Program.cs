using System;

namespace codigos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array implicito 
            // cuando se crea un arreglo de esta manera el sistema toma como tipo string
            var datos = new[] { "juan", "Diaz", "España" };

            // cuando se crea un arreglo de esta manera el sistema toma como tipo double que acepta decimales
            var valores = new[] { 15, 28, 35, 75.5, 30.30 };

            // recorer un arreglo 

            //-------------------------------------------------------------------------------
            // arrays de tipos o clases anonimas 

            var personas = new[]
            {
                //El primero condiciona al resto a traer los mismos valores
                new {Nombre= "Juan", Edad=19},
                new {Nombre="Maria", Edad = 49},
                new {Nombre="Diana" , Edad = 35}
            };
            Console.WriteLine(personas[1]);

            //-----------------------------------------------------------------------------------
            // arrays de objetos 
            Empleados[] arrayEmpleados = new Empleados[2];
            arrayEmpleados[0] = new Empleados("Sara", 37);

            Empleados Ana = new Empleados("Ana", 27);
            arrayEmpleados[1] = Ana;

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(valores[i]);
            }
        }
    }
    class Empleados
    {
        public Empleados (string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        string nombre;
        int edad;   
    }
}
