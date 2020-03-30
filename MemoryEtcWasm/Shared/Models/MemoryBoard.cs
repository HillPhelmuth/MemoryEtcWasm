using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryEtcWasm.Shared.Models
{
    public class MemoryBoard
    {
        public MemoryCard[] Board { get; set; }


        public MemoryBoard(string difficulty)
        {
            Console.WriteLine("Difficulty set to: " + difficulty);
            switch (difficulty)
            {
                case "medium":
                    Pairs = mediumPairs;
                    break;
                case "hard":
                    Pairs = hardPairs;
                    break;
                default:
                    Pairs = easyPairs;
                    break;
            }
            var length = Pairs.Length;
            Console.WriteLine($"no. of cards (model class): {length}");
            Board = new MemoryCard[length];
            for (int i = 0; i < length; i++)
            {
                Board[i] = new MemoryCard(Pairs[i]);
                Console.WriteLine($"created card {i + 1}");
            }
        }
        private string[] Pairs { get; set; }

        private static readonly string[] easyPairs = new string[] {
            @"images/babypic.jpg",
            @"images/babypic.jpg",
            @"images/blue-angels.jpg",
            @"images/blue-angels.jpg",
            @"images/FancyBroodGum.jpg",
            @"images/FancyBroodGum.jpg",
            @"images/giraffe.jpg",
            @"images/giraffe.jpg",
            @"images/GirlAtGym.jpg",
            @"images/GirlAtGym.jpg",
            @"images/PipeSmoker.jpg",
            @"images/PipeSmoker.jpg",
            @"images/pragueNights.jpg",
            @"images/pragueNights.jpg",
            @"images/UglyFlower.jpg",
            @"images/UglyFlower.jpg"
        };
        private static readonly string[] mediumPairs = new string[]
        {
            @"images/babypic.jpg",
            @"images/babypic.jpg",
            @"images/blue-angels.jpg",
            @"images/blue-angels.jpg",
            @"images/FancyBroodGum.jpg",
            @"images/FancyBroodGum.jpg",
            @"images/giraffe.jpg",
            @"images/giraffe.jpg",
            @"images/GirlAtGym.jpg",
            @"images/GirlAtGym.jpg",
            @"images/PipeSmoker.jpg",
            @"images/PipeSmoker.jpg",
            @"images/pragueNights.jpg",
            @"images/pragueNights.jpg",
            @"images/UglyFlower.jpg",
            @"images/UglyFlower.jpg",
            @"images/EasterIsland.jpg",
            @"images/EasterIsland.jpg",
            @"images/world-mask.jpg",
            @"images/world-mask.jpg"
        };
        private static readonly string[] hardPairs = new string[]
        {
            @"images/babypic.jpg",
            @"images/babypic.jpg",
            @"images/blue-angels.jpg",
            @"images/blue-angels.jpg",
            @"images/FancyBroodGum.jpg",
            @"images/FancyBroodGum.jpg",
            @"images/giraffe.jpg",
            @"images/giraffe.jpg",
            @"images/GirlAtGym.jpg",
            @"images/GirlAtGym.jpg",
            @"images/PipeSmoker.jpg",
            @"images/PipeSmoker.jpg",
            @"images/pragueNights.jpg",
            @"images/pragueNights.jpg",
            @"images/UglyFlower.jpg",
            @"images/UglyFlower.jpg",
            @"images/EasterIsland.jpg",
            @"images/EasterIsland.jpg",
            @"images/world-mask.jpg",
            @"images/world-mask.jpg",
            @"images/Storm.jpg",
            @"images/Storm.jpg",
            @"images/shoppingCart.jpg",
            @"images/shoppingCart.jpg",
            @"images/SadClown.jpg",
            @"images/SadClown.jpg",
            @"images/rooster.jpg",
            @"images/rooster.jpg",
            @"images/rodent.jpg",
            @"images/rodent.jpg",
            @"images/CatFace.jpg",
            @"images/CatFace.jpg",
            @"images/Bread.jpg",
            @"images/Bread.jpg",
            @"images/Castle.jpg",
            @"images/Castle.jpg"
        };
    }

}
