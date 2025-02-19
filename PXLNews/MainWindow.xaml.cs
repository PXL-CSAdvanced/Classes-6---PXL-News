using NewsClassLibrary;
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

namespace PXLNews
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            CreateArticles();
        }

        public void CreateArticles()
        {
            // TODO: Maak hier jouw artikels aan.
        }

        public void LoadArticle(Article article)
        {
            // TODO: Lees de eigenschappen van een Article uit en wijs ze toe aan de XAML elementen.
            // Indien er geen afbeelding is, dan verander je de ColumnSpanProperty naar 2 van InhoudTextBox.
            
        }

        private void VolgendeButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Zorg er voor dat je eeuwig vooruit in de lijst kan blijven navigeren van artikels.
        }

        private void VorigeButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Zorg er voor dat je eeuwig achteruit in de lijst kan blijven navigeren van artikels.
        }
    }
}
