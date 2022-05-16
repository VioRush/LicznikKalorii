using System;
using System.Collections.Generic;
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
    /// Logika interakcji dla klasy MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        protected MainWindow dane;

        public MenuWindow(MainWindow main)
        {
            InitializeComponent();
            dane = main;
        }

        private void Kalkulator_Click(object sender, RoutedEventArgs e)
        {
            Kalkulator kalkulator= new Kalkulator(dane);
            kalkulator.Show();
            Close();
        }

        private void ZapotrzebowanieKaloryczne_Click(object sender, RoutedEventArgs e)
        {
            ZapotrzebowanieKaloryczne zk = new ZapotrzebowanieKaloryczne(dane);
            zk.Show();
            Close();
        }

        private void BMR_Click(object sender, RoutedEventArgs e)
        {
            BMR bmr = new BMR(dane);
            bmr.Show();
            Close();
        }

        private void CPM_Click(object sender, RoutedEventArgs e)
        {
            CPM cpm = new CPM(dane);
            cpm.Show();
            Close();
        }

        private void Tabela_Click(object sender, RoutedEventArgs e)
        {
            TabelaKalorii tabela = new TabelaKalorii(dane);
            tabela.Show();
            Close();
        }

        private void Wyjscie_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Powrot_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
