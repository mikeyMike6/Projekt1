using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.Models
{
    public class Movie
    {
        public int id_filmu { get; set; }
        public string Tytul_filmu { get; set; }
        public override string ToString()
        {
            return id_filmu + ". " + Tytul_filmu;
        }
    }
}
