using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class GameSettings
    {
        //ustawienia gry
        public int CzasGry;
        public int CzasPodgladu;
        public int MaxPunkty;
        public int Wiersze;
        public int Kolumny;
        public int Bok;
        public int AktualnePunkty;

        public string PlikLogo = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\logo.jpg";
        public string FolderObrazki = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\memory";

        public GameSettings()
        {
            UstawStartowe();
        }

        //metoda ustawiajaca wartosci startowe
        private void UstawStartowe()
        {
            CzasPodgladu = 5;
            CzasGry = 60;
            MaxPunkty = 0;

            Wiersze = 4;
            Kolumny = 6;
            // co nam daje 24 kafelki = 12 zdjec
            Bok = 150;
            AktualnePunkty = 0;
        }
    }
}
