using PM_GUI_Client.Controller_layer;
using System.Diagnostics;

namespace PM_GUI_Client
{
    public partial class PMGUI : Form
    {
        private CharacterController characterController = new();
        public PMGUI()
        {
            InitializeComponent();
            sortPanel.Visible = false;
        }

        private void sortKillsBtn_Click(object sender, EventArgs e)
        {
            characterController.SortByKills();
            RefreshList();
        }

        private void sortNameBtn_Click(object sender, EventArgs e)
        {
            characterController.SortByName();
            RefreshList();
        }
        private void sortWinBtn_Click(object sender, EventArgs e)
        {
            characterController.SortByWinrate();
            RefreshList();
        }

        private void sortPickBtn_Click(object sender, EventArgs e)
        {
            characterController.SortByPickrate();
            RefreshList();
        }

        private async void refreshBtn_Click(object sender, EventArgs e)
        {
            
            await characterController.RefreshCharacterList();
            RefreshList();
            sortPanel.Visible = true;
        }

        private void RefreshList()
        {
            champList.Items.Clear();
            List<string[]> characterDetails = characterController.GetCharacterDetails();

            foreach (string[] item in characterDetails)
            {
                ListViewItem character = new ListViewItem(item[0]);
                character.SubItems.Add(item[1]);
                character.SubItems.Add(item[2]);
                character.SubItems.Add(item[3]);
                champList.Items.Add(character);
            }
        }
        
    }
}