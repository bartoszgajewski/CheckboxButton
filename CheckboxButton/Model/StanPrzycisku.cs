using System;
using System.Collections.Generic;
using System.Text;

namespace CheckboxButton.Model
{
    public class StanPrzycisku // PRZECHOWYWANIE LOGIKI I DANYCH ZWIĄZANĄ ZE STANEM PRZYCISKIEM I CHECKBOXEM
    {
        public bool CzyZaznaczono { get; set; } // Przechowuje informację czy checkbox jest zaznaczony

        public string PobierzKomunikat()        // Zmienia wartość bool na string do wyświetlenia w MessageBox
        {
            return CzyZaznaczono.ToString();
        }
    }
}
