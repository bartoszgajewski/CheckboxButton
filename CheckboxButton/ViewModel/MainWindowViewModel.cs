using CheckboxButton.Commands;
using CheckboxButton.Model;
using System.Windows;
using System.Windows.Input;

namespace CheckboxButton.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly StanPrzycisku _stanPrzycisku;

        public bool CzyZaznaczono
        {
            get => _stanPrzycisku.CzyZaznaczono;
            set
            {
                if (_stanPrzycisku.CzyZaznaczono != value)
                {
                    _stanPrzycisku.CzyZaznaczono = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand PokazKomunikatCommand { get; }

        public MainWindowViewModel()
        {
            _stanPrzycisku = new StanPrzycisku
            {
                CzyZaznaczono = false
            };

            PokazKomunikatCommand = new RelayCommand(PokazKomunikat, CzyMoznaPokazacKomunikat);
        }

        private bool CzyMoznaPokazacKomunikat(object? parameter)
        {
            return CzyZaznaczono;
        }

        private void PokazKomunikat(object? parameter)
        {
            MessageBox.Show(_stanPrzycisku.PobierzKomunikat(), "Komunikat");
        }
    }
}