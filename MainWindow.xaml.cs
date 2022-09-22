using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
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
using System.Windows.Threading;

namespace Inspiring_Quotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        List<string> _quotes;
        List<string> _authors;
        List<string> _images;

        private void setupData()
        {
            _quotes = new List<string> {
                "Inspiring Quotes",
                "Die with memories, not dreams",
                "Mastering others is strength. Mastering yourself is true power",
                "I don’t need it to be easy, I need it to be worth it",
                "Everything you’ve ever wanted is on the other side of fear",
                "I will remember and recover but that doesn’t mean I will forget",
                "Be so good they can’t ignore you",
                "Don’t tell people your plans. Show them your results",
                "Good things happen to those who hustle",
                "Whatever the mind can conceive and believe, the mind can achieve",
                "You must be the change you wish to see in the world",
            };

            _images = new List<string> {
                "/images/img0.jpg",
                "/images/img1.jpg",
                "/images/img2.jpg",
                "/images/img3.jpg",
                "/images/img4.jpg",
                "/images/img5.jpg",
                "/images/img6.jpg",
                "/images/img7.jpg",
                "/images/img8.jpg",
                "/images/img9.jpg",
                "/images/img10.jpg",
            };

            _authors = new List<string>
            {
                "",
                "Collection",
                "Lao Tzu",
                "Lil Wayne",
                "George Addair",
                "Collection",
                "Steve Martin",
                "Collection",
                "Abraham Lincoln",
                "Anais Nin",
                "Bobby Orr",
            };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            setupData();

            string quoteInit = _quotes[0];
            quote.Text = quoteInit;

            string authorInit = _authors[0];
            author.Text = authorInit;

            var bitmap = new BitmapImage(new Uri(_images[0], UriKind.Relative));
            image.Source = bitmap;
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            nextQuote();
        }

        private void nextQuote()
        {
            int index = new Random().Next(1, _quotes.Count);

            string quoteNext = _quotes[index];
            quote.Text = quoteNext;

            string authorNext = _authors[index];
            author.Text = "~ " + authorNext + " ~";

            var bitmap = new BitmapImage(new Uri(_images[index], UriKind.Relative));
            image.Source = bitmap;
        }    
    }
}
