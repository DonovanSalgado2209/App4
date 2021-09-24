using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App4.ViewModels
{
    public class CountViewModel : BaseViewModel
    {
        int _contador;
        int _buttonClickCommand;

        public CountViewModel()
        {
            _contador = 0;
            ICommand _buttoClickComnmands;
            string _countConverted;

        }

        public int Contador { get => _contador;
            set
            {
                if (value == _contador) return;
                _contador = value;
                OnPropertyChanged();
            }
            }
        public string CountConverted
        {
            get => $"Has dado clic {_contador} veces";
        }
        public ICommand ButtonClickCommand
        {
            get
            {
                if (_buttonClickCommand == null)

                    _buttonClickCommand = new Command(ButtonClickAction);
                _buttonClickCommand++;

            }
        }
    }
}
