using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsClassLibrary
{
    public class Article
    {
        public string Title { get; set; }
        public string Journalist { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateOfPublication { get; set; }

        public Article(string titel, string journalist, string inhoud, string imagePath, DateTime datumVanPublicatie)
        {
            Title = titel;
            Journalist = journalist;
            Content = inhoud;
            ImagePath = imagePath;
            DateOfPublication = datumVanPublicatie;
        }

        public Article(string titel, string journalist, string inhoud, DateTime datumVanPublicatie) : 
            this(titel, journalist, inhoud, null, datumVanPublicatie)
        {

        }
    }
}
