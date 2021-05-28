using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt1.Models;
using Projekt1.Helpers;

namespace Projekt1.Forms.MenuMovie
{
    public partial class AddNewArtist : Form
    {
        private string firstName;
        private string lastName;
        private List<Artist> artistList;
        private DateTime? artistBirthDate = null;
        private string artistCountry = null;
        public AddNewArtist()
        {
            InitializeComponent();
        }

        private void AddNewArtist_Load(object sender, EventArgs e)
        {
            RefreshArtistListBox();
        }
        private void RefreshArtistListBox()
        {
            artistList = DbConnection.ReturnArtistList(null, null);
            artistListBox.Items.Clear();
            foreach (var artist in artistList)
            {
                artistListBox.Items.Add(artist);
            }
        }
        

        private void artistListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addNewArtistButton_Click(object sender, EventArgs e)
        {
            var correctNames = Helper.CheckName(artistNameTextBox.Text, out firstName, out lastName);
            if (correctNames)
            {
                AddArtist();
                this.Close();
            }
        }

        private void AddArtist()
        {
            if (artistBirthDateTimePicker.Enabled) artistBirthDate = artistBirthDateTimePicker.Value;
            if (artistCountryOrginTextBox.Enabled) artistCountry = artistCountryOrginTextBox.Text;
            var success = DbConnection.AddNewArtist(firstName, lastName, artistBirthDate, artistCountry);
            if (success)
            {
                MessageBox.Show("Dodano artyste");
                RefreshArtistListBox();
            }
            else
            {
                MessageBox.Show("Dodawanie artysty zakończone niepowodzeniem");
            }
        }

        private void artistBrithDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            artistBirthDateTimePicker.Enabled = !artistBirthDateTimePicker.Enabled;
        }

        private void artistCountryOrginCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            artistCountryOrginTextBox.Enabled = !artistCountryOrginTextBox.Enabled;
        }
    }
}
