using DataAccessLayer.Entities;
using DataAccessLayer.Insfrastructure;

namespace DataAccessLayer.Abstracts
{
    public interface IDetailRepository: IRepository<Detail>
    {
        void Liked(int id, int step);
        void Saved(int id, int step);
        void Shared(int id, int step);
        void Showed(int id, int step);
    }
}
