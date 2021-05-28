using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.Models
{
    public class MovieDetails
    {
        public int id_filmu { get; set; }
        public string Gatunek { get; set; }
        public string Kraj_produkcji { get; set; }
        public string Jezyk { get; set; }
        public int Czas_trwania { get; set; }
        public string Wytwornia { get; set; }
        public double Budzet { get; set; }
        public int Prequel { get; set; }
        public int Sequel { get; set; }

        public string[] ToStrings()
        {
            string[] movieDetails = new string[6];
            movieDetails[0] = "Gatunek: " + Gatunek;
            movieDetails[1] = "Kraj produkcji: " + Kraj_produkcji;
            movieDetails[2] = "Jezyk: " + Jezyk;
            movieDetails[3] = "Czas trwania: " + Czas_trwania;
            movieDetails[4] = "Wytwórnia: " + Wytwornia;
            movieDetails[5] = "Budżet: " + Budzet;
            return movieDetails;
        }
    }
}
