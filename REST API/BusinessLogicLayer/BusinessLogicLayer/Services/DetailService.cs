using BusinessLogicLayer.Abstracts;
using DataAccessLayer.Abstracts;
using DataAccessLayer.UnitOfWork;

namespace BusinessLogicLayer.Services
{
    public class DetailService : IDetailService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IDetailRepository repository;

        public DetailService(IUnitOfWork _unitOfWork, IDetailRepository _repository)
        {
            unitOfWork = _unitOfWork;
            repository = _repository;
        }

        public void Liked(int id, int step)
        {
            repository.Liked(id, step);
            Save();
        }

        public void Saved(int id, int step)
        {
            repository.Saved(id, step);
            Save();
        }

        public void Shared(int id, int step)
        {
            repository.Shared(id, step);
            Save();
        }

        public void Showed(int id, int step)
        {
            repository.Showed(id, step);
            Save();
        }

        private void Save()
        {
            unitOfWork.SaveChanges();
        }
    }
}
