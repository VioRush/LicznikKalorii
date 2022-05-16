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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LicznikKalorii
{
    /// <summary>
    /// Logika interakcji dla klasy TabelaKalorii.xaml
    /// </summary>
    public partial class TabelaKalorii : Window
    {
        protected MainWindow dane;
        public TabelaKalorii(MainWindow main)
        {
            InitializeComponent();
            dane = main;

            List<string> tabela = new List<string>();
            string[] linie = File.ReadAllLines("C:/Users/Asus/source/repos/LicznikKalorii/LicznikKalorii/TabelaKalorii.txt");
            char separator = ' ';

            foreach (string linia in linie)
            {
                string[] slowa = linia.Split(separator);
                string produkt = "";
                for (int i = 0; i < slowa.Length - 1; i++)
                {
                    produkt += (slowa[i] + "  ");
                }
                tabela.Add(produkt + " " + slowa[slowa.Length - 1] + " kkal");
            }

            Tabela.ItemsSource = tabela;
        }

        private void Powrot_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow(dane);
            menu.Show();
            Close();
        }
    }
}
