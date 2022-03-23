using System;

namespace codigos
{
    internal class Program
    { //Proyecto herencia 
        static void Main(string[] args)
        {
            Caballo pony = new Caballo();
            humano David = new humano();
            Gorila kong = new Gorila();

            pony.galopar();
            pony.respirar();
            pony.cuidarCrias();

            David.respirar();
            David.cuidarCrias();
            David.pensar();

            kong.respirar();
            kong.cuidarCrias();
            kong.trepar();
            
        }

    }
    class Mamiferos
    {
        public void respirar()
        {
            Console.WriteLine("respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("cuidar crias");
        }
    }

    class Caballo : Mamiferos
    {
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    class humano : Mamiferos
    {
        public void pensar()
        {
            Console.WriteLine("pienso");
        }
    }
    
    class Gorila : Mamiferos
    {
        public void trepar()
        {
            Console.WriteLine("trepar");
        }
    }

}
