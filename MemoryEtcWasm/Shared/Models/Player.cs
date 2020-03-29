using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryEtcWasm.Shared.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int GamesWon { get; set; }
        public int Order { get; set; }
    }
}
