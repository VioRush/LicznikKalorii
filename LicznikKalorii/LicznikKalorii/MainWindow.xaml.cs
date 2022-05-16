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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LicznikKalorii
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation buttonAnimation = new DoubleAnimation();
            //buttonAnimation.TargetPropertyType = opacity;
            Powitanie.Text = "     Witaj w aplikacji do kontroli wagi MyWeightControlApp!";
            Powitanie.Opacity = 0.0;
            buttonAnimation.From = Powitanie.Opacity;
            buttonAnimation.To = 1.0;
            buttonAnimation.Duration = TimeSpan.FromSeconds(5);
            Powitanie.BeginAnimation(Button.OpacityProperty, buttonAnimation);

        }

        private static char płeć = 'K';
        public static int wiek = 40;
        private static int wzrost = 161;
        private static int waga = 50;
        private static float aktywność = (float)1.2;
        private static int cel = 0;

        public void Płeć(char p)
        {
            płeć = p;
        }

        public void Wiek(int w)
        {
            wiek = w;
        }

        public void Wzrost(int wz)
        {
            wzrost = wz;
        }

        public void Waga(int wa)
        {
            waga = wa;
        }

        public void Aktywność(int a)
        {
            if (a == 0)
            {
                aktywność = (float)1.2;
            }
            else if (a == 1)
            {
                aktywność = (float)1.35;
            }
            else if (a == 2)
            {
                aktywność = (float)1.55;
            }
            else if (a == 3)
            {
                aktywność = (float)1.75;
            }
            else if (a == 4)
            {
                aktywność = (float)2.05;
            }
            Console.WriteLine(a);
        }

        public void Cel(int c)
        {
            cel = c;
        }

        public int ZapotrzebowanieKaloryczne()
        {
            if (cel == 0)
            {
                return ((int)CPM() - 250);
            }

            else if (cel == 1)
            {
                return (int)CPM();
            }

            else
            {
                return ((int)CPM() + 250);
            }
        }

        public float BMR()
        {
            if (płeć == 'K')
            {
                return (((float)9.99 * waga) + ((float)6.25 * wzrost) - ((float)4.95 * wiek) - 161);
            }
            else      //plec == 'M'
            {
                return (((float)9.99 * waga) + ((float)6.25 * wzrost) - ((float)4.92 * wiek) + 5);
            }
        }

        public float CPM()
        {
            return BMR() * aktywność;
        }

        private void Button_Dalej_Click(object sender, RoutedEventArgs e)
        {

            if (textBoxWiek.Text.Length<1)
            {
                textBoxWiek.Background = Brushes.Red;
                textBoxWiek.ToolTip = "Niepoprawnie podano wiek! Pole jest wymagane!";
            }
            else if(textBoxWzrost.Text.Length < 1)
            {
                textBoxWzrost.Background = Brushes.Red;
                textBoxWzrost.ToolTip = "Niepoprawnie podano wzrost! Pole jest wymagane!";
            }
            else if (textBoxWaga.Text.Length < 1)
            {
                textBoxWaga.Background = Brushes.Red;
                textBoxWaga.ToolTip = "Niepoprawnie podano wagę! Pole jest wymagane!";
            }
            else
            {
                Płeć(Convert.ToChar(ComboBoxPlec.SelectedItem.ToString().Substring(0, 1)));
                Wiek(Convert.ToInt32(textBoxWiek.Text));
                Wzrost(Convert.ToInt32(textBoxWzrost.Text));
                Waga(Convert.ToInt32(textBoxWaga.Text));
                Aktywność(ComboBoxAktywnosc.SelectedIndex);
                Cel(ComboBoxCel.SelectedIndex);
                
                MenuWindow menu = new MenuWindow(this);
                menu.Show();
                Close();
            }
           
        }

        private void ComboBoxPlec_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();

            data.Add("Kobieta");
            data.Add("Mężczyzna");

            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = data;
            comboBox.SelectedIndex = 0;
        }

        private void ComboBoxAktywnosc_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();

            data.Add("Brak aktywnośći, praca siedząca");
            data.Add("Niska aktywność (praca siedząca i 1-2 treningi w tygodniu");
            data.Add("Średnia aktywność (praca siedząca i treningi 3-4 razy w tygodniu");
            data.Add("Wysoka aktywność (praca fizyczna i treningi 3-4 razy w tygodniu");
            data.Add("Bardzo wysoka aktywność (zawodowi sportowcy, osoby codziennie treninujące");

            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = data;
            comboBox.SelectedIndex = 0;
        }

        private void ComboBoxCel_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();

            data.Add("Zrzucenie kilogramów /schudnięcie");
            data.Add("Podtrzymywanie masy");
            data.Add("Zbudowanie masy");

            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = data;
            comboBox.SelectedIndex = 0;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            int result;

            if (!(int.TryParse(e.Text, out result) || e.Text == "."))
            {
                e.Handled = true;
            }
        }
    }
}
