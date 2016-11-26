using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Football_Draft.Models
{
    public class QbBreakdownStatModel
    {
        public string playerName { get; set; }
        // current year
        public string playerPassingYds { get; set; }
        public string playerPassingTDs { get; set; }
        public string playerInts { get; set; }
        public string playerRushingTds { get; set; }
        public string playerRushingYds { get; set; }
        public string playerFumbles { get; set; }
        // last yr
        public string playerPassingYdsLy { get; set; }
        public string playerPassingTDsLy { get; set; }
        public string playerIntsLy { get; set; }
        public string playerRushingTdsLy { get; set; }
        public string playerRushingYdsLy { get; set; }
        public string playerFumblesLy { get; set; }
        // next yr
        public string playerPassingYdsNy { get; set; }
        public string playerPassingTDsNy { get; set; }
        public string playerIntsNy { get; set; }
        public string playerRushingTdsNy { get; set; }
        public string playerRushingYdsNy { get; set; }
        public string playerFumblesNy { get; set; }
    }
}
