using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WpfApplication1.Classes.Commands;

namespace WpfApplication1.Classes
{
    public class ViewModel_Commands : BindableBase
    {
        public ViewModel_Commands()
        {
            DefineEvents();

            RefreshCmd = new RelayCommand
            {
                Action = o => { },
                MayExecute = o => !isLoading,
                Label = "Refresh",
                Image = @"Pics\Refresh.png"
            };
            commands.Add(RefreshCmd);
        }

        public async Task ReloadAsync()
        {
            isLoading = true;
            displayedItems.Add(new Personne{Prenom="Lucky", Nom="Luke"});
            displayedItems.Add(new Personne { Prenom = "Jolly", Nom = "Jumper" });
            await Task.Delay(3000);
            isLoading = false;
        }

        private List<Personne> personnes;
        public List<Personne> Personnes
        {
            get { return personnes; }
            set { personnes = value; }
        }

        private ObservableCollection<Object> displayedItems = new ObservableCollection<object>();
        public ObservableCollection<Object> DisplayedItems
        {
            get { return displayedItems; }
            set { displayedItems = value; }
        }

        private bool isLoading;
        public bool IsLoading
        {
            get { return isLoading; }
            set
            {
                if (SetProperty(value, ref isLoading))
                    RefreshCmd.FireCanExecuteChanged();
            }
        }

        // Events
        private void DefineEvents()
        {

        }

        // Commandes
        public RelayCommand RefreshCmd { get; set; }
        public List<RelayCommand> commands = new List<RelayCommand>();
        public List<RelayCommand> Commands 
        {
            get { return commands; }
            set { commands = value; }
        }
    }
}
