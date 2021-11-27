using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {
        private GameSettings gameSettings;
        public Form1()
        {
            InitializeComponent();
            gameSettings = new GameSettings();
            UstawKontrolki();
            GenerujKarty();
        }

        //metoda uruchamiana na poczatku w celu ustawienia wartosci startowych, do uruchomienia przy starcie i ponownej grze
        private void UstawKontrolki()
        {
            panel1.Width = gameSettings.Kolumny * gameSettings.Bok;
            panel1.Height = gameSettings.Wiersze * gameSettings.Bok;

            Width = panel1.Width + 40;
            Height = panel1.Height + 110;

            //ustawienia labelow
            lblStartInfo.Text = $"Początek gry za {gameSettings.CzasPodgladu}";
            lblPunktyWartosc.Text = gameSettings.AktualnePunkty.ToString();
            lblCzasWartosc.Text = gameSettings.CzasGry.ToString();

            //pokazujemy label z odliczaniem, jak gra sie zacznie to go ukryjemy
            lblStartInfo.Visible = true;
        }

        public void GenerujKarty()
        {
            //pobieramy sciezki do obrazkow
            string[] memory = Directory.GetFiles(gameSettings.FolderObrazki);

            //ustawienie maksymalnej ilosci punktow na podstawie pobranych obrazkow
            gameSettings.MaxPunkty = memory.Length;

            //tworzymy liste na kafelki
            var card = new List<MemoryCard>();

            //dla kazdego obrazka generujemy kafelek
            foreach (string image in memory)
            {
                //tworzymy jego unikatowy identyfikator
                var id = Guid.NewGuid();

                //tworzymy pierwsza karte
                var card1 = new MemoryCard(id, gameSettings.PlikLogo, image);
                var card2 = new MemoryCard(id, gameSettings.PlikLogo, image);

                card.Add(card1);
                card.Add(card2);
            }

            //generator liczb pseudolosowych
            var random = new Random();

            //czyscicmy panel ze wszystkich kart
            panel1.Controls.Clear();

            //ustawiamy losowo kafelki

            for (int kolumna = 0; kolumna < gameSettings.Kolumny; kolumna++)
            {
                for (int wiersz = 0; wiersz < gameSettings.Wiersze; wiersz++)
                {
                    //losujemy index elementu z z listy , losujemy go poprzez numer indeksu
                    var index = random.Next(0, card.Count);

                    var button = card[index];

                    //dodajemy margines do kafelka
                    button.Margin = new Padding(2);

                    //ustawiamy pozycje 
                    button.Location = new Point(kolumna * gameSettings.Bok,
                        wiersz * gameSettings.Bok);

                    //ustawiamy wielkosc karty
                    button.Width = gameSettings.Bok;
                    button.Height = gameSettings.Bok;

                    //odkrywamy startowo karte
                    button.Odkryj();

                    //dodajemy kafelek do panelu
                    panel1.Controls.Add(button);

                    //usuwamy go z listy zeby nie zostal ponownie wylosowany 
                    card.Remove(button);
                }
            }
        }
    }
}
