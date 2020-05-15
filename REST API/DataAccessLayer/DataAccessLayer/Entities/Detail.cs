namespace DataAccessLayer.Entities
{
    public class Detail : BaseEntity<int>
    {
        public int LikedCount { get; set; }
        public int SavedCount { get; set; }
        public int SharedCount { get; set; }
        public int ShowedCount { get; set; }

        public virtual Anecdote Anectode { get; set; }
        //public int AnecdoteId { get; set; }
    }
}