using BusinessLogicLayer.ViewModels;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Abstracts
{
    public interface IAnecdoteService
    {
        AnecdoteViewModel Get(int id);
        AnecdoteViewModel Get(Expression<Func<Anecdote, bool>> predicate);

        List<AnecdoteListViewModel> GetPopular();
        List<AnecdoteListViewModel> GetNew();
        List<AnecdoteListViewModel> GetMostLiked();
        List<AnecdoteListViewModel> Search(string text);

        void Add(AnecdoteAddViewModel anectode);
        void Update(AnecdoteUpdateViewModel anectode);
        void Delete(int id);

    }
}
