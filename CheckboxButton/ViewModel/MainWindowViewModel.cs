using CheckboxButton.Command;
using CheckboxButton.Model;
using System.Windows;
using System.Windows.Input;

namespace CheckboxButton.ViewModels
{
    public class MainWindowViewModel : ViewModelBase        // Pośredniczy między widokiem a modelem
    {
        private readonly StanPrzycisku _stanPrzycisku;      // Trzymanie stanu przycisku

    public bool CzyZaznaczono                               // Bindowana właściwość z CheckBoxa w XAML ( zaznaczanie )
    {
        get { return _stanPrzycisku.CzyZaznaczono; }        // Pobiera wartość z Modelu
        set
        {
            _stanPrzycisku.CzyZaznaczono = value;           // Zapisuje nową wartość do modelu
            OnPropertyChanged();                            // Powiadamia widok o zmianie
        }
    }

        public ICommand PokazKomunikatCommand { get; }      // Komenda bindowana do przycisku Komunikat


        // Konstruktor ViewModelu
        public MainWindowViewModel()
        {

            // Tworzy model z domyślną wartoscią false
            _stanPrzycisku = new StanPrzycisku  
            {
                CzyZaznaczono = false
            };

            PokazKomunikatCommand = new RelayCommand(PokazKomunikat, CzyMoznaPokazac);  // Tworzymy komendę: PokazKomunikat, CzyMoznaPokazac
        }


        // DECYDUJE CZY PRZYCISK JEST AKTYWNY ( ze zmiennej CzyZaznaczono )
        private bool CzyMoznaPokazac(object? parameter)
        {
            return CzyZaznaczono;
        }

        // POKAZUJE MESSAGEBOX z tekstem aktualnej wartości CzyZaznacznono pobrany z modelu
        private void PokazKomunikat(object? parameter)
        {
            MessageBox.Show(_stanPrzycisku.PobierzKomunikat(), "Komunikat");
        }
    }
}