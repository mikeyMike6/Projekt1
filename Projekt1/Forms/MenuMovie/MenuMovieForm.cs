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
using Projekt1.Forms.MenuMovie;
using Projekt1.Models;
using Projekt1.Helpers;

namespace Projekt1.Forms
{
    public partial class MenuMovieForm : Form
    {
        private List<Movie> movies;
        private List<Artist> artistList;
        private List<Cast> castList;
        private AddNewArtist addNewArist;
        private AddMovieDetails addMovieDetails;

        private void LoadMovieFromDatebase() => movies = DbConnection.ReturnMovieList(-1);
        private void RefreshMovieListBox()
        {
            movieListBox.Items.Clear(); 
            movies.ForEach(x => movieListBox.Items.Add(x)); 
        }

        public MenuMovieForm()
        {
            InitializeComponent();
        }



        private void addNewMovieButton_Click(object sender, EventArgs e)
        {
            var movieTitle = movieTitleTextBox.Text;
            if (movieTitle.Length > 3) 
            {
                DbConnection.AddNewMovie(movieTitle);
                movieTitleTextBox.Text = "";
                LoadMovieFromDatebase();
                RefreshMovieListBox();
            }
            else MessageBox.Show("Wprowadzony tytul jest za krótki");
        }

        private void MenuMovieForm_Load(object sender, EventArgs e)
        {
            RefreshDate();
        }
        private void RefreshDate()
        {
            LoadMovieFromDatebase();
            RefreshMovieListBox();
            RefreshArtistListBox();
        }
        private void ShowMovieDetails()
        {
            var movieTMP = DbConnection.ReturnMovieDetails(GetMovieID());
            movieDetalisListBox.Items.Clear();
            if (movieTMP.Count == 1)
            {
                var movieDetail = movieTMP[0].ToStrings().ToList();
                movieDetail.ForEach(x => movieDetalisListBox.Items.Add(x));
            }
            
        }
        private int GetMovieID()
        {
            var movie = (Movie)movieListBox.SelectedItem;
            if (movie == null) return -1;
            return movie.id_filmu;
        }
        private int GetActorID()
        {
            var actor = (Artist)artistListBox.SelectedItem;
            if (actor == null) return -1;
            return actor.id_artysty;
        }

        private void movieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GetMovieID() != 1)
            {
                ShowMovieDetails();
                ShowMovieCast();
            }
            if(movieListBox.SelectedIndex == -1)
            {
                addMovieDetailsButton.Enabled = false;
                deleteMovieButton.Enabled = false;
            }
            else
            {
                addMovieDetailsButton.Enabled = true;
                deleteMovieButton.Enabled = true;
            }
        }

        private void ShowMovieCast()
        {
            castList = DbConnection.ReturnCast(GetMovieID());
            var castQuery =
                from c in castList
                join a in artistList on c.id_artysty equals a.id_artysty
                join m in movies on c.id_filmu equals m.id_filmu
                select new { c.Rola, a.Imie, a.Nazwisko };
            castQuery = castQuery.ToList();
            CastListBox.Items.Clear();
            foreach (var item in castQuery)
            {
                var person = "'" + item.Imie + " " + item.Nazwisko + "' jako " + item.Rola;
                CastListBox.Items.Add(person);
            }
        }

        private void RefreshArtistListBox()
        {
            artistList = DbConnection.ReturnArtistList(-1);
            artistListBox.Items.Clear();
            foreach (var artist in artistList)
            {
                artistListBox.Items.Add(artist);
            }
        }

        private void AddRoleButton_Click(object sender, EventArgs e)
        {
            var actorID = GetActorID();
            var movieID = GetMovieID();

            if (actorID != -1 || movieID != -1 || roleTextBox.Text != "")
            {
                if (DbConnection.AddNewRole(movieID, actorID, roleTextBox.Text))
                {
                    MessageBox.Show("Dodano obsade");
                    roleTextBox.Text = "";
                    RefreshDate();
                }
            }
            else MessageBox.Show("Nieprawidłowe dane");
        }

        private void AddNewRole(string role, int artistID, int movieID)
        {
            if (DbConnection.AddNewRole(movieID, artistID, role)) MessageBox.Show("Dodano obsade");
            else MessageBox.Show("Wystapil problem podczas dodawania obsady");
            ShowMovieCast();
        }

        private void addMovieDetailsButton_Click(object sender, EventArgs e)
        {
            if (GetMovieID() != -1)
            {
                if (addMovieDetails == null)
                {
                    addMovieDetails = new AddMovieDetails(GetMovieID());
                    addMovieDetails.FormClosed += AddMovieDetailsClosed;
                }
                addMovieDetails.Show();
            }
        }

        private void AddMovieDetailsClosed(object sender, FormClosedEventArgs e)
        {
            addMovieDetails.FormClosed -= AddMovieDetailsClosed;
            addMovieDetails = null;
            RefreshDate();
        }

        private void addNewArtistButton_Click(object sender, EventArgs e)
        {
            if (addNewArist == null)
            {
                addNewArist = new AddNewArtist();
                addNewArist.FormClosed += AddNewArtistClosed;
            }
            addNewArist.Show();
        }

        private void AddNewArtistClosed(object sender, FormClosedEventArgs e)
        {
            addNewArist.FormClosed -= AddNewArtistClosed;
            addNewArist = null;
            RefreshDate();
        }

        private void deleteMovieButton_Click(object sender, EventArgs e)
        {
            if (DbConnection.DeleteMovie(GetMovieID())) MessageBox.Show("Usunięto wybraną pozycje");
            else MessageBox.Show("Wystapil problem przy usuwaniu pozycji");
            RefreshDate();
        }

        private void deleteArtistButton_Click(object sender, EventArgs e)
        {
            if (DbConnection.DeleteArtist(GetActorID())) MessageBox.Show("Usunięto wybraną pozycje");
            else MessageBox.Show("Wystapil problem przy usuwaniu pozycji");
            RefreshDate();
        }

        private void artistListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(artistListBox.SelectedIndex == -1)
            {
                deleteArtistButton.Enabled = false;
            }
            else
            {
                deleteArtistButton.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var movieTitle = movieTitleTextBox.Text;
            List<Movie> newMovieList = new List<Movie>();
            if(movieTitle != "")
            {
                var movieD = DbConnection.ReturnMovieList(movieTitle);
                if (movieD.Count() > 0)
                {
                    movieListBox.Items.Clear();
                    movieD.ForEach(x => movieListBox.Items.Add(x));

                }
            }
            else
            {
                RefreshDate();
            }
        }
    }
}
