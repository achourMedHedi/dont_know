using Neo4j_For_The_Win.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Neo4j_For_The_Win.Contracts
{
    public interface IMoviesRepository
    {
        IEnumerable<object> GetMovies();
        IEnumerable GetTeams();
        //object GetMovies();
    }
}
