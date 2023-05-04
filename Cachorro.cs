using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPets
{
    public class Cachorro:Animal
    {
        public override void EmitirSom(){
            Console.WriteLine("Auuuuuu Auuuuu!");
        }
    }
}