using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Football_Draft.Models
{
    public class PlayerModel
    {
        public string playerName { get; set; }
        public string playerPassYds { get; set; }
        public string playerPassTDs { get; set; }
        public string playerInts { get; set; }
        public string playerRushingTds { get; set; }
        public string playerRushingYds { get; set; }
        public string playerCarries { get; set; }
        public string playerFumbles { get; set; }
        public string playerPts { get; set; }
    }
}
