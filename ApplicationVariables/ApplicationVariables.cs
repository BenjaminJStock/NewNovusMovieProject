using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationVariables
{
    public class ApplicationVariables
    {
            public ApplicationVariables()
            { }

            public struct CsvPaths
            {
                public static string MoviesCSV = @"C:\Users\p10331589\Documents\Visual Studio 2012\Projects\NovusMovieProject2\NovusMovieProject\WebMovies\ExtendedTestData.csv";
                //public static string MoviesCSV = @"C:\Users\Recor\Documents\Visual Studio 2015\Projects\NovusMovieProject\WebMovies\ExtendedTestData.csv";
            }

            public struct SystemSettings
            {
                public struct Cache
                {
                    public static bool UseCache = true;
                    public static string FilmCacheName = @"Cache_Film";
                }
            }

            public struct SystemValues
            {
                public struct Buttons
                { 
                    public static string BtnResetID_ToLower = "btnreset";
                }

                public struct DropDownLists
                {
                    public static string DefaultValue = @"NOT SELECTED";
                    public static string DefaultText = @"<----- SELECT ----->";
                    public static bool UseBlankItem = true;

                    public struct Films
                    {
                        public static string ControlID = @"DropDownListFilms";
                        public static string DataTextField = @"FilmName";
                        public static string DataValueField = @"FilmID";
                    }

                    public struct Directors
                    {
                        public static string ControlID = @"DropDownListDirectors";
                        public static string DataTextField = @"PersonName";
                        public static string DataValueField = @"PersonID";
                    }

                    public struct Actors
                    {
                        public static string ControlID = @"DropDownListActors";
                        public static string DataTextField = @"PersonName";
                        public static string DataValueField = @"PersonID";
                    }
                }
            }

            public struct DataIDs
            {
                public struct CsvItems_Movies
                {
                    public static int FilmID = 0;
                    public static int FilmName = 1;
                    public static int ImdbRating = 2;
                    public static int FilmYear = 7;
                    public static int DirectorID = 3;
                    public static int DirectorName = 4;
                    public static int ActorID = 5;
                    public static int ActorName = 6;
                }
            }
        }

}
