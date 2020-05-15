using DataAccessLayer.Abstracts;
using DataAccessLayer.Entities;
using DataAccessLayer.Insfrastructure;
using Shared.Exceptions;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class AnecdoteDetail
    {
        public Anecdote Anectode { get; set; }
        public Detail Detail { get; set; }
    }

    public class AnecdoteRepository : Repository<Anecdote>, IAnecdoteRepository
    {
        public AnecdoteRepository(IDbContext _context) : base(_context) { }

        private IQueryable<AnecdoteDetail> Query
        {
            get
            {
                var detailList = context.Set<Detail>();
                var result = from a in dbSet
                             join d in detailList
                             on a.Id equals d.Id
                             select new AnecdoteDetail { Anectode = a, Detail = d };
                return result;
            }
        }

        private bool IsNotExist(Anecdote anectode)
        {
            Anecdote _anectode = Get(x => x.Title == anectode.Title);
            if (_anectode != null)
            {
                throw new AnecdoteException(string.Format("Entity has already been added with this title '{0}'", anectode.Title), System.Net.HttpStatusCode.NotFound);
            }
            return true;
        }

        public override void Add(Anecdote entity)
        {
            if (IsNotExist(entity))
            {
                entity.Detail = new Detail();
                base.Add(entity);
            }
        }

        public override void Delete(int id)
        {
            Anecdote anectode = Get(id);
            anectode.Status = false;
        }

        public override void Update(Anecdote entity)
        {
            if (IsNotExist(entity))
            {
                Anecdote anectode = Get(entity.Id);
                anectode.Title = entity.Title;
                anectode.Owner = entity.Owner;
                anectode.Status = entity.Status;
                anectode.Content = entity.Content;
            }
        }

        public IEnumerable<Anecdote> GetMostLiked()
        {
            return TakeAnectode(Query.OrderByDescending(x => x.Detail.LikedCount));
        }

        public IEnumerable<Anecdote> GetNew()
        {
            return TakeAnectode(Query.OrderByDescending(x => x.Anectode.CreatedDate));
        }

        public IEnumerable<Anecdote> GetPopular()
        {
            return TakeAnectode(Query.OrderByDescending(x => x.Detail.ShowedCount));
        }

        public IEnumerable<Anecdote> Search(string text)
        {
            return TakeAnectode(Query.Where(x => x.Anectode.Title.StartsWith(text)));
        }

        private IEnumerable<Anecdote> TakeAnectode(IQueryable<AnecdoteDetail> anectodeDetails)
        {
            return anectodeDetails.Where(x => x.Anectode.Status == true).Take(TakedItemCount).Select(x => x.Anectode).AsEnumerable();
        }
    }
}
