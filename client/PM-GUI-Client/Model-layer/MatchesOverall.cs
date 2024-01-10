using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_GUI_Client.Model_layer
{
    internal class MatchesOverall
    {
        private int totalMatches;
        private static MatchesOverall singleton;
        public static MatchesOverall GetSingleton()
        {
            singleton = singleton ?? (singleton = new MatchesOverall());
            return singleton;
        }
        public int GetTotalMatches()
        {
            return totalMatches;
        }
        public void SetTotalMatches(int total)
        {
            totalMatches = total;
        }
    }
}
