using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPets
{
    public abstract class Animal
    {
        public String Nome {get; set;}
        public String Genero {get; set;}
        public String Especie {get; set;}
        public int Idade {get; set;}
        public abstract void EmitirSom ();
    }
}