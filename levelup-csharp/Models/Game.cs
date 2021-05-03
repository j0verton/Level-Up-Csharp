using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace levelup_csharp.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int GamerId { get; set; }
        public int NumberOfPlayers { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
