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
            
        }
    }
}
