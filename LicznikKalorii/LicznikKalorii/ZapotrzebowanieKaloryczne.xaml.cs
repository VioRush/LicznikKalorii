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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LicznikKalorii
{
    /// <summary>
    /// Logika interakcji dla klasy ZapotrzebowanieKaloryczne.xaml
    /// </summary>
    public partial class ZapotrzebowanieKaloryczne : Window
    {
        protected MainWindow dane;
        public ZapotrzebowanieKaloryczne(MainWindow main)
        {
            InitializeComponent();
            dane = main;
            textBlockZapotrzebowanie.Text = dane.ZapotrzebowanieKaloryczne().ToString() + "kkal";
            DoubleAnimation Animation = new DoubleAnimation();
            Animation.From = textBlockZapotrzebowanie.FontSize;
            Animation.To = 74;
            Animation.Duration = TimeSpan.FromSeconds(2);
            textBlockZapotrzebowanie.BeginAnimation(TextBlock.FontSizeProperty, Animation);
        }

        private void Powrot_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow(dane);
            menu.Show();
            Close();
        }
    }
}
