using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_GUI_Client.Model_layer
{
    internal class MatchWrapper //Wrapper class til at deserialse json, ugly but needed
    {
        public string _id { get; set; }
        public string match_id { get; set; }
        public PlayerWrapper player0 { get; set; }
        public PlayerWrapper player1 { get; set; }
        public PlayerWrapper player2 { get; set; }
        public PlayerWrapper player3 { get; set; }
        public PlayerWrapper player4 { get; set; }
        public PlayerWrapper player5 { get; set; }
        public PlayerWrapper player6 { get; set; }
        public PlayerWrapper player7 { get; set; }
        public PlayerWrapper player8 { get; set; }
        public PlayerWrapper player9 { get; set; }

        public List<PlayerWrapper> GetPlayers()
        {
            List<PlayerWrapper> list = new List<PlayerWrapper>();
            if (player0 != null)
            {
                list.Add(player0);
            }
            if (player1 != null)
            {
                list.Add(player1);
            }
            if (player2 != null)
            {
                list.Add(player2);
            }
            if (player3 != null)
            {
                list.Add(player3);
            }
            if (player4 != null)
            {
                list.Add(player4);
            }
            if (player5 != null)
            {
                list.Add(player5);
            }
            if (player6 != null)
            {
                list.Add(player6);
            }
            if (player7 != null)
            {
                list.Add(player7);
            }
            if (player8 != null)
            {
                list.Add(player8);
            }
            if (player9 != null)
            {
                list.Add(player9);
            }

            return list;
        }
    }
}
