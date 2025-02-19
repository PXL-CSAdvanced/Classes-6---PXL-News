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
        List<Article> articles;
        int currentArticle;

        public MainWindow()
        {
            InitializeComponent();
            articles = new List<Article>();
            CreateArticles();
            currentArticle = 0;
            LoadArticle(articles[currentArticle]);
        }

        public void CreateArticles()
        {
            articles.Add(new Article("Beijing Streets Overrun By Hundreds Of Stray Olympians After End Of Games",
                "John Huston", 
                "BEIJING—Following the previous night’s closing ceremonies, Beijing city officials received numerous reports Monday that the streets were overrun with hundreds of stray Olympians that had been left behind after the 2022 Winter Games. “It’s tempting to go right up to them, but you have to remember that even though they may have had a home before, they are wild creatures now,” said local resident Kong Xiaodan, adding that she tried to shoo away a feral ski jumper she found huddled in a corner of her yard, but retreated back indoors when the international athlete’s filthy, mangy teammates came out of the shadows and hissed at her. “The city’s having trouble catching them because they’re all pretty fast and strong. One of the big Finnish ones was looking for food and overturned a dumpster in the alley behind my office. It’s a shame, because you know all they need is a bath and someone to love them. I wouldn’t mind adopting one myself—they’re pretty cute! I’ve already seen some of them breeding, though, so hopefully the authorities get them rounded up and euthanized as quickly as possible.” At press time, Kong had reportedly run over U.S. figure skater Brandon Frazier, whom she had not realized was sleeping under her car.",
                "images/bejing.png",
                new DateTime(2022, 02, 21)
                ));

            articles.Add(new Article(
                "Doctor Assures Family Of Dying Patient He Billing Everything He Can",
                "Allen James",
                "LEBANON, PA—Telling the man’s wife and adult children that the medical facility always strove to ensure no options were left on the table, a doctor reportedly conferred with the family of a dying patient Monday to let them know the hospital was billing everything it could. “Let me assure you that he is receiving the highest level of fees that we have available,” the doctor said to the weeping family of the cancer patient, before going over several options for further payments that he strongly recommended. “It’s risky, but there’s an experimental new charge with a very high rate of interest that we’d like to try. We want you to know that we’re leaving no stone unturned, and if one approach doesn’t work, we’ll bill something else. It could leave him with nothing, but in a grave situation like this, we’ve simply got to try.” At press time, sources confirmed the doctor had called the patient’s family into a side room to inform them that he was sorry, but there was nothing more they could bill.",
                "images/medical.png",
                new DateTime(2022, 02, 19)));

            articles.Add( new Article(
                "Journalist Worried He’s Becoming The Story In His Sponsored Air Purifier Review",
                "Olivia Addax",
                "NEW YORK—Struggling to remain detached from his subject matter, local journalist James Malvern was reportedly worried Tuesday that he was becoming the story in his sponsored air purifier review. “While I set out to write a simple recommendation of the Air Fine 2700 to our readers, I couldn’t help but start interrogating my own personal relationship to germs and dander,” said Malvern, explaining that he no longer felt any kind of objectivity was possible in his paid blog post, which had turned into a meditation on his subjective experience with the filtration product written in the style of such New Journalism luminaries as Truman Capote, Joan Didion, and Gay Talese. “I’m afraid I’m too close to all this now to be a neutral observer. The story is about more than just a machine that effectively removes up to 97% of airborne particles, including pollen and mold spores—it’s about who cleans up all the dust and decay the American empire leaves behind in its wake.” At press time, sources confirmed Malvern had submitted a 50,000-word draft and was immediately fired.",
                new DateTime(2022, 02, 15)));
        }

        public void LoadArticle(Article article)
        {
            TitelTextBlock.Text = article.Title;
            InhoudTextBox.Text = article.Content;
            if (String.IsNullOrEmpty(article.ImagePath))
            {
                InhoudTextBox.SetValue(Grid.ColumnSpanProperty, 2);
                ArtikelImage.Visibility = Visibility.Hidden;
            }
            else
            {
                InhoudTextBox.SetValue(Grid.ColumnSpanProperty, 1);
                ArtikelImage.Visibility = Visibility.Visible;
                ArtikelImage.Source = new BitmapImage(new Uri(article.ImagePath, UriKind.Relative));
            }
            JournalistTextBlock.Text = article.Journalist;
            DatumTextBlock.Text = article.DateOfPublication.ToShortDateString();
        }

        private void VolgendeButton_Click(object sender, RoutedEventArgs e)
        {
            currentArticle = (++currentArticle + articles.Count) % articles.Count;
            LoadArticle(articles[currentArticle]);
        }

        private void VorigeButton_Click(object sender, RoutedEventArgs e)
        {
            currentArticle = (--currentArticle + articles.Count) % articles.Count;
            LoadArticle(articles[currentArticle]);
        }
    }
}
