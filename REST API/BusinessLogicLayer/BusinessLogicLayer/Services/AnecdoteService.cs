using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BusinessLogicLayer.Abstracts;
using BusinessLogicLayer.ViewModels;
using DataAccessLayer.Abstracts;
using DataAccessLayer.Entities;
using DataAccessLayer.UnitOfWork;

namespace BusinessLogicLayer.Services
{
    public class AnecdoteService : IAnecdoteService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IAnecdoteRepository repository;

        public AnecdoteService(IUnitOfWork _unitOfWork, IAnecdoteRepository _repository)
        {
            unitOfWork = _unitOfWork;
            repository = _repository;
        }

        public AnecdoteViewModel Get(int id)
        {
            return ModelMapping(repository.Get(id));
        }

        public AnecdoteViewModel Get(Expression<Func<Anecdote, bool>> predicate)
        {
            return ModelMapping(repository.Get(predicate));
        }

        public List<AnecdoteListViewModel> GetMostLiked()
        {
            return ListModelMapping(repository.GetMostLiked());
        }

        public List<AnecdoteListViewModel> GetNew()
        {
            return ListModelMapping(repository.GetNew());
        }

        public List<AnecdoteListViewModel> GetPopular()
        {
            return ListModelMapping(repository.GetPopular());
        }

        public List<AnecdoteListViewModel> Search(string text)
        {
            return ListModelMapping(repository.Search(text));
        }

        public void Add(AnecdoteAddViewModel model)
        {
            repository.Add(new Anecdote { Title = model.Title, Content = model.Content });
            Save();
        }

        public void Update(AnecdoteUpdateViewModel model)
        {
            repository.Update(new Anecdote { Id = model.Id, Title = model.Title, Content = model.Content, Owner = model.Owner, Status = model.Status });
            Save();
        }

        public void Delete(int id)
        {
            repository.Delete(id);
            Save();
        }

        private void Save()
        {
            unitOfWork.SaveChanges();
        }

        private AnecdoteViewModel ModelMapping(Anecdote anecdote)
        {
            return new AnecdoteViewModel { Id = anecdote.Id, Content = anecdote.Content, Date = anecdote.CreatedDate.ToShortDateString(), Owner = anecdote.Owner, Title = anecdote.Title, ShowedCount = anecdote.Detail.ShowedCount, LikedCount = anecdote.Detail.LikedCount, SavedCount = anecdote.Detail.SavedCount, ShareCount = anecdote.Detail.SharedCount, Status = anecdote.Status };
        }

        private List<AnecdoteListViewModel> ListModelMapping(IEnumerable<Anecdote> anecdotes)
        {
            List<AnecdoteListViewModel> model = new List<AnecdoteListViewModel>();
            foreach (var anectode in anecdotes)
            {
                model.Add(new AnecdoteListViewModel { Id = anectode.Id, Title = anectode.Title, Owner = anectode.Owner, Date = anectode.CreatedDate.ToShortDateString() });
            }
            return model;
        }
    }
}
