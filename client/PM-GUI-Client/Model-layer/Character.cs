using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_GUI_Client.Model_layer
{
    internal class Character
    {
        private string characterName;
        private int wins;
        private int kills;
        private int totalMatches;

        public void IncrementMatches() 
        {
            totalMatches++;
        }
        public void AddKills(int kills)
        {
            this.kills += kills;
            if (kills == 35)  wins++;
        }

        public Character(string characterName)
        {
            this.characterName = characterName;
        }

        public string GetName() 
        {
            return characterName;
        }
        public float GetWinRate()
        {
            return MathF.Round(((float)wins / (float)totalMatches)*100,2);
        }
        public float GetPickRate()
        {
            Debug.Print(MatchesOverall.GetSingleton().GetTotalMatches().ToString());
            return MathF.Round(((float)totalMatches / (float)MatchesOverall.GetSingleton().GetTotalMatches()) * 100, 2);
        }
        public float GetAverageKills()
        {
            return MathF.Round((float)kills / (float)totalMatches,2);
        }


    }
}
