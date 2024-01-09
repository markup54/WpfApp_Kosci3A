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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Kosci3A
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Image> imagesKosci { get; set; }
        List<Kosc>  Kosci { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            przygotujObrazy();
            przygotujKosci();
        }

        private void przygotujObrazy()
        {
            imagesKosci = new List<Image>();
            imagesKosci.Add(zdj1);
            imagesKosci.Add(zdj2);
            imagesKosci.Add(zdj3);
            imagesKosci.Add(zdj4);
            imagesKosci.Add(zdj5);
        }
        private void przygotujKosci()
        {
            Kosci = new List<Kosc>();
            for(int i = 0;i<5;i++)
            {
                Kosci.Add(new Kosc());
            }
        }

        private void Button_Rzut_Click(object sender, RoutedEventArgs e)
        {
            for(int i =0;i<Kosci.Count;i++) 
            {
                Kosci[i].RzucKoscia();
                imagesKosci[i].Source = Kosci[i].BitmapImage;
            }
            MessageBox.Show(sumaOczek().ToString());
            
        }
        private int sumaOczek()
        {
            int s = 0;
            foreach(Kosc kosc in Kosci)
            {
                s = s + kosc.Wartosc;
            }
            return s;
        }

        /*
         * 
         * Obliczenia
         * suma wszystkich oczek szansa
         * para 1 2 2 6 6 -> 12(suma oczek największej pary)
         * 2 pary
         * trójka
         * kareta (4 takie same)
         * poker (5 takich samych)
         * mały streat 1 2 3 4 5
         * duży streat 2 3 4 5 6
         * full (trójka i para)
         * 
         */

        private void Button_Blokuj_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            button.Opacity = 0.5;
            Image image = button.Content as Image;
            int indeks = imagesKosci.IndexOf(image);
            if(Kosci[indeks].Zablokowana == true)
            {
                Kosci[indeks].Zablokowana = false;
                button.Opacity = 1;
            }
            else
            {
                Kosci[indeks].Zablokowana = true;
                button.Opacity = 0.5;
            }
            
        }
    }
}
