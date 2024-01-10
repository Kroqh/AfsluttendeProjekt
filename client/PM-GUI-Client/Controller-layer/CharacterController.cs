using Newtonsoft.Json;
using PM_GUI_Client.Model_layer;
using PM_GUI_Client.Service_layer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PM_GUI_Client.Controller_layer
{
    internal class CharacterController
    {
        private List<Character> characters = new();


        public void SortByWinrate()
        {
            int n = characters.Count;
            for (int i = 1; i < n; ++i)
            {
                Character character = characters[i];
                float sorter = characters[i].GetWinRate();
                int j = i - 1;

                while (j >= 0 && characters[j].GetWinRate() < sorter)
                {
                    characters[j + 1] = characters[j];
                    j--;
                }
                characters[j + 1] = character;
            }
        }
        public void SortByPickrate() 
        {
            int n = characters.Count;
            for (int i = 1; i < n; ++i)
            {
                Character character = characters[i];
                float sorter = characters[i].GetPickRate();
                int j = i - 1;

                while (j >= 0 && characters[j].GetPickRate() < sorter)
                {
                    characters[j + 1] = characters[j];
                    j--;
                }
                characters[j + 1] = character;
                
            }
        }
        public void SortByName()
        {
            int n = characters.Count;
            for (int i = 1; i < n; ++i)
            {
                Character character = characters[i];
                string sorter = characters[i].GetName();
                int j = i - 1;

                while (j >= 0 && String.Compare(characters[j].GetName(), sorter) > 0)
                {
                    characters[j + 1] = characters[j];
                    j--;
                }
                characters[j + 1] = character;

            }
        }
        public void SortByKills()
        {
            int n = characters.Count;
            for (int i = 1; i < n; ++i)
            {
                Character character = characters[i];
                float sorter = characters[i].GetAverageKills();
                int j = i - 1;

                while (j >= 0 && characters[j].GetAverageKills() < sorter)
                {
                    characters[j + 1] = characters[j];
                    j--;
                }
                characters[j + 1] = character;
            }
        }

        public List<string[]> GetCharacterDetails()
        {
            List<string[]> list = new();

            foreach (Character character in characters)
            {
                Debug.Print("Test");
                string[] details = new string[4];
                details[0] = character.GetName();
                details[1] = character.GetPickRate().ToString() + "%";
                details[2] = character.GetWinRate().ToString() + "%";
                details[3] = character.GetAverageKills().ToString();
                list.Add(details);
            }
            return list;
        }

        public async Task RefreshCharacterList()
        {
            string jsonData = await Connection.GetMatchesJSON();
            if (jsonData != "error")
            {
                characters = new();
                DocumentRoot root = JsonConvert.DeserializeObject<DocumentRoot>(jsonData);
                MatchesOverall.GetSingleton().SetTotalMatches(root.documents.Count);

                foreach (MatchWrapper match in root.documents) 
                {
                    foreach (PlayerWrapper player in match.GetPlayers())
                    {
                        Character characterFound = null;
                        foreach (Character character in characters)
                        {
                            if (character.GetName() == player.hero)
                            { 
                                characterFound = character;
                                break;
                            }
                        }
                        if (characterFound == null)
                        {
                            characterFound = new(player.hero);
                            characters.Add(characterFound);
                        }

                        characterFound.AddKills(int.Parse(player.kills));
                        characterFound.IncrementMatches();
                    }
                }
            }
            SortByName();
        }
    }
}
