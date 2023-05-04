using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPets
{
    public class Veterinario
    {
        public void Examinar (Animal animal){
            Console.WriteLine("Examinar o {0}", animal.Nome);
            animal.EmitirSom();
            Console.WriteLine("Exame Finalizado");
        }
    }
}