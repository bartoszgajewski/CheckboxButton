using System;
using System.Collections.Generic;
using System.Text;

namespace CheckboxButton.Model
{
    public class StanPrzycisku
    {
        public bool CzyZaznaczono { get; set; }

        public string PobierzKomunikat()
        {
            return CzyZaznaczono.ToString();
        }
    }
}
