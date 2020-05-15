using DataAccessLayer.Entities;
using DataAccessLayer.Insfrastructure;
using System.Collections.Generic;

namespace DataAccessLayer.Abstracts
{
    public interface IAnecdoteRepository : IRepository<Anecdote>
    {
        IEnumerable<Anecdote> GetPopular();
        IEnumerable<Anecdote> GetMostLiked();
        IEnumerable<Anecdote> GetNew();
        IEnumerable<Anecdote> Search(string text);
    }
}
