using DataAccessLayer.Abstracts;
using DataAccessLayer.Entities;
using DataAccessLayer.Insfrastructure;

namespace DataAccessLayer.Repositories
{
    public class DetailRepository : Repository<Detail>, IDetailRepository
    {
        public DetailRepository(IDbContext _context) : base(_context) { }

        private Detail detail;

        public void Liked(int id, int step)
        {
            detail = Get(id);
            detail.LikedCount += step;
            detail.LikedCount = (detail.LikedCount < 0) ? 0 : detail.LikedCount;
        }

        public void Saved(int id, int step)
        {
            detail = Get(id);
            detail.SavedCount += step;
            detail.SavedCount = (detail.SavedCount < 0) ? 0 : detail.SavedCount;
        }

        public void Shared(int id, int step)
        {
            detail = Get(id);
            detail.SharedCount += step;
            detail.SharedCount = (detail.SharedCount < 0) ? 0 : detail.SharedCount;
        }

        public void Showed(int id, int step)
        {
            detail = Get(id);
            detail.ShowedCount += step;
            detail.ShowedCount = (detail.ShowedCount < 0) ? 0 : detail.ShowedCount;
        }
    }
}
