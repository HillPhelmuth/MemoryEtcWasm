using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryEtcWasm.Shared.ExtensionMethods
{
    public static class Shuffler
    {
        private static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> cards)
        {
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }
    }
}
