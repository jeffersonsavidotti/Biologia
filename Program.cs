using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPets
{
class Program
{
    static void Main(String[] args)
    {
        // Animal 1
        Cachorro MyDog = new Cachorro();
        MyDog.Nome = "Scott";
        MyDog.Genero = "Macho";
        MyDog.Especie = "Caramelho Charmoso";
        MyDog.Idade = 10;
        MyDog.EmitirSom();

        Veterinario Vet = new Veterinario();
        Vet.Examinar(MyDog);

        // Animal 2

        Pintinho Pitico = new Pintinho();
        Pitico.Nome = "Pitico";
        Pitico.Genero = "Macho";
        Pitico.Especie = "Preto";
        Pitico.Idade = 1;
        Pitico.EmitirSom();

        Vet.Examinar(Pitico);

        // Animal 3

        Passarinho Coleiro = new Passarinho();
        Coleiro.Nome = "Broddock";
        Coleiro.Genero = "Macho";
        Coleiro.Especie = "Preto";
        Coleiro.Idade = 1;
        Coleiro.EmitirSom();

        Vet.Examinar(Coleiro);
    }
}
}