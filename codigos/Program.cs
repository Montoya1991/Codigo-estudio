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
            foreach (var dato in valores)
            {
                Console.WriteLine(dato);
            }

                // recorrer la posiciones del arreglo y mostrarlas

                // con la propiedad length se recorre la totalidad del array si se desconoce su tamaño
                for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

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
            

            //-----------------------------------------------------------------------------------
            // arrays de objetos 
            Empleados[] arrayEmpleados = new Empleados[3];
            arrayEmpleados[0] = new Empleados("Sara", 37);

            Empleados Ana = new Empleados("Ana", 27);
            arrayEmpleados[1] = Ana;

            arrayEmpleados[2] = new Empleados("Manuel", 51); 

            // se crea un bucle for que recorra todo el arreglo y mostrando la posicion y el contenido del metodo getInfo

            foreach(Empleados variable in arrayEmpleados)
            {
                Console.WriteLine(variable.getInfo());
            }


            //for (int i = 0; i < arrayEmpleados.Length; i++)
            //{
            //    Console.WriteLine(arrayEmpleados[i].getInfo());
            //}
        }
    }
    class Empleados
    {
        public Empleados (string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        
        // se crea un metodo publico que traiga los valores de nombre y edad 
        public string getInfo()
        {
            return "Nombre del empelado: " + nombre + " Edad: "+ edad;
        }

        private string nombre;
        private int edad;   
    }
}
