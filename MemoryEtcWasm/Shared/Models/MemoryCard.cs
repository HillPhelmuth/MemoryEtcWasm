using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryEtcWasm.Shared.Models
{
    public class MemoryCard
    {
        public string Face;
        public bool IsFlipped { get; set; }
        public MemoryCard(string face)
        {
            Face = face;
        }
    }
}
