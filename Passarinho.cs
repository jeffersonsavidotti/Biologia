using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPets
{
    public class Passarinho:Animal
    {
        public override void EmitirSom(){
            Console.WriteLine("Tui Tui Zel Zel");
        }
    }
}