using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.No = 4;
            pokemon.Name = "Charmander";
            pokemon.Height = 2.0f;
            pokemon.Weight = 18.7f;
            pokemon.Category = "Lizard";
            pokemon.Abilities = "Blaze";
            pokemon.Gender = "M";
            /// Output Pokemon
            Console.WriteLine("編號:#{0}, 名字:{1}", pokemon.No.ToString("000"), pokemon.Name);
            Console.WriteLine("身高:{0}公尺, 體重:{1}磅, 類別:{2}, 能力:{3}, 性別:{4}", pokemon.Height, pokemon.Weight, pokemon.Category, pokemon.Abilities, pokemon.Gender);
            Console.WriteLine();
        }
    }
}