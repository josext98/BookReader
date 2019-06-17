using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace BookReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.TvBox.ItemsSource = new MovidData[]
           {
            new MovidData{Title="Movie 3", ImageData=LoadImage("Imagenes/instagram.png")},
            new MovidData{Title="Movie 3", ImageData=LoadImage("Imagenes/instagram.png")},
            new MovidData{Title="Movie 3", ImageData=LoadImage("Imagenes/instagram.png")},
            new MovidData{Title="Movie 3", ImageData=LoadImage("Imagenes/instagram.png")},
            new MovidData{Title="Movie 3", ImageData=LoadImage("Imagenes/instagram.png")},
           };

            this.BookT.ItemsSource = new MovieBook[]
          {
            new MovieBook{BookName="Sonido", BookPage = "360"},
            new MovieBook{BookName="El Libro", BookPage = "390"},
            new MovieBook{BookName="Arroz", BookPage = "400"},
            new MovieBook{BookName="Sonido", BookPage = "360"},
            new MovieBook{BookName="El Libro", BookPage = "390"},
            new MovieBook{BookName="Arroz", BookPage = "400"},
            new MovieBook{BookName="Sonido", BookPage = "360"},
            new MovieBook{BookName="El Libro", BookPage = "390"},
            new MovieBook{BookName="Arroz", BookPage = "400"},
          };
        }

        class MovidData
        {
           public String Title { get; set; }
           public BitmapImage ImageData { get; set; }
        }

        class MovieBook
        {
            public String BookName { get; set; }
            public String BookPage { get; set; }

        }
        private BitmapImage LoadImage(string filename)
        {
            return new BitmapImage(new Uri("pack://application:,,,/" + filename));
        }
    }
}
