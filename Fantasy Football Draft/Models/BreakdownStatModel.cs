using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Football_Draft.Models
{
    public class BreakdownStatModel
    {
        public string playerName { get; set; }
        public string playerRushingYds { get; set; }
        public string playerRushingTDs { get; set; }
        public string playerReceptions { get; set; }
        public string playerRecYds { get; set; }
        public string playerRecTDs { get; set; }
        public string playerFumbles { get; set; }
        public string playerPts { get; set; }
    }
}
