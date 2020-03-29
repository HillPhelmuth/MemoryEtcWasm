using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryEtcWasm.Shared.Models
{
    public class MemoryBoard
    {
        public MemoryCard[] Board { get; set; }
        
        public MemoryBoard()
        {
            string[] pairs = new string[] {
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
            //string[] pairs = new string[] {
            //    @"images/ChaseCrawford.jpg",
            //    @"images/ChaseCrawford.jpg",
            //    @"images/IamSomerhalder.jpg",
            //    @"images/IamSomerhalder.jpg",
            //    @"images/KaiaGerber.jpg",
            //    @"images/KaiaGerber.jpg",
            //    @"images/KateMoss.jpg",
            //    @"images/KateMoss.jpg",
            //    @"images/LucasHood.jpg",
            //    @"images/LucasHood.jpg",
            //    @"images/MaggieQ.jpg",
            //    @"images/MaggieQ.jpg",
            //    @"images/MamieGummer.jpg",
            //    @"images/MamieGummer.jpg",
            //    @"images/PrinceHarry.jpg",
            //    @"images/PrinceHarry.jpg"
            //};
            Board = new MemoryCard[16];
            for (int i = 0; i < 16; i++)
            {
                Board[i] = new MemoryCard(pairs[i]);
            }
        }

    }
}
