using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LicznikKalorii
{
    /// <summary>
    /// Logika interakcji dla klasy Kalkulator.xaml
    /// </summary>
    public partial class Kalkulator : Window
    {
        protected MainWindow dane;
        public Kalkulator(MainWindow main)
        {
            InitializeComponent();
            dane = main;

            List<string> tabela = new List<string>();
            string[] linie = File.ReadAllLines("C:/Users/Asus/source/repos/LicznikKalorii/LicznikKalorii/TabelaKalorii.txt");
            char separator = ' ';

            foreach (string linia in linie)
            {
                string[] slowa = linia.Split(separator);
                tabela.Add(slowa[0]);
            }

            TabelaKaloryczna.ItemsSource = tabela;
        }

        private int Kalorie(string produkt)
        {
            string[] linie = File.ReadAllLines("C:/Users/Asus/source/repos/LicznikKalorii/LicznikKalorii/TabelaKalorii.txt");
            char separator = ' ';

            foreach (string linia in linie)
            {
                string[] slowa = linia.Split(separator);
                if (slowa[0] == produkt){
                    return Convert.ToInt32(slowa[slowa.Length - 1]);
                }
            }

            return -1;
        }

        private void Button_Oblicz_Click(object sender, RoutedEventArgs e)
        {
            if (IloscProduktu.Text.Length > 0)
            {
                string produkt = TabelaKaloryczna.SelectedItem.ToString();
                Wynik.Text = produkt;
                string ilosc = IloscProduktu.Text;
                int kal = Kalorie(produkt);
                WynikLabel.Visibility = Visibility.Visible;
                Wynik.Background = Brushes.White;
                if (kal < 0)
                {
                    Wynik.Text = "Nie udało się obliczyć ilość kalorii.";
                }
                else
                {
                    float wynik = (float)(kal * Convert.ToInt32(ilosc) / 100);
                    Wynik.Text = wynik.ToString() + "kkal";
                    DoubleAnimation Animation = new DoubleAnimation();
                    Animation.From = Wynik.FontSize;
                    Animation.To = 50;
                    Animation.Duration = TimeSpan.FromSeconds(2);
                    Wynik.BeginAnimation(TextBlock.FontSizeProperty, Animation);
                }
            }
        }

        private void Powrot_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow(dane);
            menu.Show();
            Close();
        }
    }
}
