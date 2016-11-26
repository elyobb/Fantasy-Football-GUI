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
        // current year
        public string playerRushingYds { get; set; }
        public string playerRushingTDs { get; set; }
        public string playerReceptions { get; set; }
        public string playerRecYds { get; set; }
        public string playerRecTDs { get; set; }
        public string playerFumbles { get; set; }
        // last year
        public string playerRushingYdsLy { get; set; }
        public string playerRushingTDsLy { get; set; }
        public string playerReceptionsLy { get; set; }
        public string playerRecYdsLy { get; set; }
        public string playerRecTDsLy { get; set; }
        public string playerFumblesLy { get; set; }
        // next year
        public string playerRushingYdsNy { get; set; }
        public string playerRushingTDsNy { get; set; }
        public string playerReceptionsNy { get; set; }
        public string playerRecYdsNy { get; set; }
        public string playerRecTDsNy { get; set; }
        public string playerFumblesNy { get; set; }
    }
}
