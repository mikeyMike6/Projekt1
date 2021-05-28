using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt1.Forms;
using Projekt1.Models;
using Projekt1.Helpers;

namespace Projekt1.Forms.MenuMovie
{
    public partial class AddMovieDetails : Form
    {
        private int movieID;
        private MovieDetails movie;
        private string genre;
        private string country;
        private double money;
        private string company = null;
        private int time;
        private string language;
        
        private bool CheckIfMovieDetailsAreInBase()
        {
            var movieDetails = DbConnection.ReturnMovieDetails(movieID);
            if (movieDetails.Count() == 0) return false;
            return true;
        }
        private void GetDetailsTextBox()
        {
            var movies = DbConnection.ReturnMovieDetails(movieID).ToList();
            if (movies.Count > 0)
            {
                movie = (MovieDetails)movies[0];
                genreTextBox.Text = movie.Gatunek;
                countryTextBox.Text = movie.Kraj_produkcji;
                timeTextBox.Text = movie.Czas_trwania.ToString();
                companyTextBox.Text = movie.Wytwornia;
                budgetTextBox.Text = movie.Budzet.ToString();
                languageTextBox.Text = movie.Jezyk;
            }
            movieTitleTexBox.Text = GetMovieTitle();
        }
        public AddMovieDetails(int _movieID)
        {
            movieID = _movieID;
            InitializeComponent();
        }
        private string GetMovieTitle()
        {
            var movie = DbConnection.ReturnMovieList(movieID);
            return movie[0].Tytul_filmu;
        }
        private void AddMovieDetails_Load(object sender, EventArgs e)
        {
            GetDetailsTextBox();
        }

        private void addMovieDetailsButton_Click(object sender, EventArgs e)
        {
            if (CheckMovieDetails())
            {
                if (!CheckIfMovieDetailsAreInBase())
                {
                    if (DbConnection.AddMovieDetails(movieID, genre, country, language, time,
                     company, money))
                    {
                        MessageBox.Show("Dodano informacje o filmie");
                        this.Close();
                    }
                    else MessageBox.Show("Nie udalo się dodać informacji o filmie");
                }
                else
                {
                    if (DbConnection.EditMovieDetails(movieID, genre, country, language, time,
                        company, money))
                    {
                        MessageBox.Show("Zaktualizowano informacje o filmie");
                        this.Close();
                    }
                    else MessageBox.Show("Nie udalo się dodać informacji o filmie");
                }
            }
            else
            {
                MessageBox.Show("Niepoprawnie wprowadzone dane");
            }
        }
        private bool CheckMovieDetails()
        {
            bool successParse;
            if (budgetTextBox.Text != "")
            {
                successParse = Double.TryParse(budgetTextBox.Text, out double _money);
                if (!successParse) return false;
                money = _money;
            }
            if(companyTextBox.Text != "") company = companyTextBox.Text;
            successParse = Int32.TryParse(timeTextBox.Text, out int _time);
            if (!successParse) return false;
            time = _time;
            genre = genreTextBox.Text;
            country = countryTextBox.Text;
            company = companyTextBox.Text;
            language = languageTextBox.Text;
            return true;
        }
    }
}
