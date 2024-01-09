using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfApp_Kosci3A
{
    public class Kosc
    {
        public int Wartosc { get; set; }
        public BitmapImage BitmapImage { get; set; }
        public bool Zablokowana { get; set; }

        public List<BitmapImage> BitmapImages { get; set; }

        private void przygotujObrazki()
        {
         
            BitmapImages = new List<BitmapImage>();
            BitmapImages.Add(new BitmapImage(new Uri("pusta.png",UriKind.Relative)));
           
            BitmapImages.Add(new BitmapImage(new Uri("kosc1.png",UriKind.Relative)));
            BitmapImages.Add(new BitmapImage(new Uri("kosc2.png",UriKind.Relative)));
            BitmapImages.Add(new BitmapImage(new Uri("kosc3.png",UriKind.Relative)));
            BitmapImages.Add(new BitmapImage(new Uri("kosc4.png",UriKind.Relative)));
            BitmapImages.Add(new BitmapImage(new Uri("kosc5.png", UriKind.Relative)));
            BitmapImages.Add(new BitmapImage(new Uri("kosc6.png", UriKind.Relative)));
        }

        public Kosc()
        {
            przygotujObrazki();
            Wartosc = 0;
            BitmapImage = BitmapImages[0];
            Zablokowana = false;
        }

        public void RzucKoscia()
        {
            if (Zablokowana == false)
            {
                Random random = new Random();
                Wartosc = random.Next(1, 7);
                BitmapImage = BitmapImages[Wartosc];
            }
        }
    }
}
