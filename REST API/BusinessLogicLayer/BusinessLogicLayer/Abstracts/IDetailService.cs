namespace BusinessLogicLayer.Abstracts
{
    public interface IDetailService
    {
        void Liked(int id, int step);
        void Saved(int id, int step);
        void Shared(int id, int step);
        void Showed(int id, int step);
    }
}
