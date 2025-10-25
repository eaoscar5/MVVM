using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.ModelViewVM.ViewModels
{
    public class CommandsViewModel
    {
        public ClickCommand { get; } 

        public ICommand SearchCommand { get; }
        public string SearchData { get; set; }

        public CommandsViewModel()
        {
            ClickCommand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Titulo", "Mensaje!", "OK");
            });

            SearchCommand = new Command(() =>
            {
                var data = SearchData;

            });

        }

        private void Alert() 
        {
            
        }
    }
}
