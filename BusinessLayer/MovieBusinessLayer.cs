using System;
using System.Collections.Generic;
using mcl = MovieClassLayer.MovieClasses;
using mdl = MovieDataLayer.MovieDataLayer;

namespace MovieBusinessLayer
{
    public class MovieBusinessLayer : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
            }
            // free native resources if there are any.
        }

        //--------------------------------------------------------------------- FILMS
        public mcl.Films GetFilms(string csvPath)
        {
            using (mdl dl1 = new mdl())
            {
                return dl1.GetCsvData(csvPath);
            }
            //-- TODO: raise error if needed
        }

        public List<mcl.SimplisticFilm> GetDistinctSimplisticFilmsFromFilms(mcl.Films films)
        {
            return (films == null) ? null : films.ToListSimplisticFilm();
        }

        public mcl.Films GetFilmsSubset(string filmID, string directorID, string actorID, mcl.Films films)
        {
            return films.GetFilmsFilteredSubset(filmID, directorID, actorID);
        }

        //--------------------------------------------------------------------- DIRECTORS
        public List<mcl.Director> GetDistinctDirectorsFromFilms(mcl.Films films)
        {
            return (films == null) ? null : films.ToListDistinctDirector();
        }

        public List<mcl.Director> GetDistinctDirector(mcl.Films films, string directorID)
        {
            return films.GetDistinctDirector(directorID);
        }

        //--------------------------------------------------------------------- ACTORS

        public List<mcl.Actor> GetDistinctActorsFromFilms(mcl.Films films)
        {
            return (films == null) ? null : films.ToListDistinctActor();
        }

        public List<mcl.Actor> GetDistinctActor(mcl.Films films, string actorID)
        {
            return films.GetDistinctActor(actorID);
        }

    }
}
