using System;

namespace NewsLibraryNet
{
    public class Artikel
    {
        public string Titel { get; set; }
        public string Journalist { get; set; }
        public string Inhoud { get; set; }
        public DateTime DatumPublicatie { get; set; }
        public string ImagePath { get; set; }
    }
}
