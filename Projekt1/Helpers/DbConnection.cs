using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt1.Models;

namespace Projekt1.Helpers
{
    public static class DbConnection
    {
        public static string getConnection()
        {
            return ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        }
        public static List<Artist> ReturnArtistList(string searchFor, string searchBy)
        {
            var commandText = "SELECT * FROM Artysci ";
            if (searchFor != null)
            {
                commandText += "WHERE " + searchBy + " @par";
                DapperHelper<Artist>.AddParameter("par", searchFor);
            }
            return DapperHelper<Artist>.ExecuteQuery(getConnection(), commandText).ToList();
        }
        public static List<Movie> ReturnMovieList(int movieID)
        {
            var commandText = "SELECT * FROM Filmy ";
            if(movieID >= 0)
            {
                commandText += "WHERE id_filmu = @id";
                DapperHelper<Movie>.AddParameter("id", movieID.ToString());
            }
            return DapperHelper<Movie>.ExecuteQuery(getConnection(), commandText).ToList();
        }
        public static List<MovieDetails> ReturnMovieDetails(int movieID)
        {
            var commandText = "SELECT * FROM Szczegoly_filmu WHERE id_filmu = @id";
            DapperHelper<MovieDetails>.AddParameter("id", movieID.ToString());
            return DapperHelper<MovieDetails>.ExecuteQuery(getConnection(), commandText).ToList();
        }
        public static List<Cast> ReturnCast(int movieID)
        {
            var commandText = "SELECT * FROM Obsada WHERE id_filmu = @id";
            DapperHelper<Cast>.AddParameter("id", movieID.ToString());
            return DapperHelper<Cast>.ExecuteQuery(getConnection(), commandText).ToList();
        }
        public static bool AddNewArtist(string fName, string lName, DateTime? dateBirth, string country)
        {
            var commandText = "INSERT INTO Artysci VALUES (@imieArtysty, @nazwiskoArtysty, null, null)";
            if (dateBirth != null)
            {
                var date = (DateTime)dateBirth;
                var dateString = Helper.ConverDate(date);
                DapperHelper<Artist>.AddParameter("data", dateString);
                commandText = "INSERT INTO Artysci VALUES (@imieArtysty, @nazwiskoArtysty, @data, null)";
            }
            if (country != null)
            {
                DapperHelper<Artist>.AddParameter("kraj", country);
                commandText = "INSERT INTO Artysci VALUES (@imieArtysty, @nazwiskoArtysty, null, @kraj)";
            }
            if (dateBirth != null && country != null)
            {
                commandText = "INSERT INTO Artysci VALUES (@imieArtysty, @nazwiskoArtysty, @data, @kraj)";
            }
            DapperHelper<Artist>.AddParameter("imieArtysty", fName);
            DapperHelper<Artist>.AddParameter("nazwiskoArtysty", lName);
            if (DapperHelper<Artist>.ExecuteNonQuery(getConnection(), commandText) > 0)
            {
                return true;
            }
            else return false;
        }
        public static bool AddNewMovie(string title)
        {
            var commandText = "INSERT INTO Filmy VALUES (@tytul)";
            DapperHelper<Movie>.AddParameter("tytul", title);
            if (DapperHelper<Movie>.ExecuteNonQuery(getConnection(), commandText) > 0) return true;
            return false;
        }
        public static bool AddNewRole(int movieID, int artistID, string role)
        {
            var commandText = "INSERT INTO Obsada VALUES (@idA, @idF, @rola)";
            DapperHelper<Cast>.AddParameter("idF", movieID.ToString());
            DapperHelper<Cast>.AddParameter("idA", artistID.ToString());
            DapperHelper<Cast>.AddParameter("rola", role);
            if (DapperHelper<Cast>.ExecuteNonQuery(getConnection(), commandText) > 0) return true;
            return false;
        }
        public static bool AddMovieDetails(int movieID, string genre, string country, string language, 
            int time, string company, double money)
        {
            var commandText = "INSERT INTO Szczegoly_filmu VALUES (@id, @gatunek, @kraj, @jezyk, @czas, null, null, null, null)";
            DapperHelper<MovieDetails>.AddParameter("id", movieID.ToString());
            DapperHelper<MovieDetails>.AddParameter("gatunek", genre);
            DapperHelper<MovieDetails>.AddParameter("kraj", country);
            DapperHelper<MovieDetails>.AddParameter("jezyk", language);
            DapperHelper<MovieDetails>.AddParameter("czas", time.ToString());
            var companyOk = company != "" || company != null;
            var budgetOk = money != 0; 
            if (companyOk)
            {
                commandText = "INSERT INTO Szczegoly_filmu VALUES (@id, @gatunek, @kraj, @jezyk, @czas, @wytwornia, null, null, null)";
                DapperHelper<MovieDetails>.AddParameter("wytwornia", company);
            }
            if(budgetOk)
            {
                commandText = "INSERT INTO Szczegoly_filmu VALUES (@id, @gatunek, @kraj, @jezyk, @czas, null, @budzet, null, null)";
                DapperHelper<MovieDetails>.AddParameter("budzet", money.ToString());
            }
            if (companyOk && budgetOk) commandText = "INSERT INTO Szczegoly_filmu VALUES (@id, @gatunek, @kraj, @jezyk, @czas, @wytwornia, @budzet, null, null)";

            if (DapperHelper<MovieDetails>.ExecuteNonQuery(getConnection(), commandText) > 0) return true;
            return false;
        }

        public static bool EditMovieDetails(int movieID, string genre, string country, string language,
            int time, string company, double money)
        {
            var commandText = "UPDATE Szczegoly_filmu SET Gatunek = @gatunek, Kraj_produkcji = @kraj, Jezyk = @jezyk, Czas_trwania = @czas ";
            DapperHelper<MovieDetails>.AddParameter("id", movieID.ToString());
            DapperHelper<MovieDetails>.AddParameter("gatunek", genre);
            DapperHelper<MovieDetails>.AddParameter("kraj", country);
            DapperHelper<MovieDetails>.AddParameter("jezyk", language);
            DapperHelper<MovieDetails>.AddParameter("czas", time.ToString());
            var companyOk = company != "" || company != null;
            var budgetOk = money != 0;
            if (companyOk)
            {
                commandText += ", Wytwornia = @wytwornia ";
                DapperHelper<MovieDetails>.AddParameter("wytwornia", company);
            }
            if (budgetOk)
            {
                commandText += ", Budzet = @budzet ";
                DapperHelper<MovieDetails>.AddParameter("budzet", money.ToString());
            }
            commandText += "WHERE id_filmu = @id";
            if (DapperHelper<MovieDetails>.ExecuteNonQuery(getConnection(), commandText) > 0) return true;
            return false;
        }

        public static bool DeleteMovie(int movieID)
        {
            var commandText = "EXEC usuwanieFilmu @id";
            DapperHelper<Movie>.AddParameter("id", movieID.ToString());
            if (DapperHelper<Movie>.ExecuteNonQuery(getConnection(), commandText) > 0) return true;
            return false;
        }
        public static bool DeleteArtist(int artistID)
        {
            var commandText = "EXEC usuwanieArtysty @id";
            DapperHelper<Artist>.AddParameter("id", artistID.ToString());
            if (DapperHelper<Artist>.ExecuteNonQuery(getConnection(), commandText) > 0) return true;
            return false;
        }
    }
}
