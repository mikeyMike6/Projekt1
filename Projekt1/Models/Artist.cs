using Projekt1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.Models
{
    public class Artist
    {
        public int id_artysty { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime? Data_urodzenia { get; set; }
        public string Kraj_pochodzenia { get; set; }
        public override string ToString()
        {
            var text = Imie + " " + Nazwisko + " (" + Kraj_pochodzenia + ") ";
            if (Data_urodzenia != null) text += Helper.ConverDate((DateTime)Data_urodzenia);
            return text;
        }
    }
}
