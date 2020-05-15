using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.ViewModels
{
    public class AnecdoteListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Owner { get; set; }
        public string Date { get; set; }
    }

    public class AnecdoteViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Owner { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public int LikedCount { get; set; } = 0;
        public int SavedCount { get; set; } = 0;
        public int ShowedCount { get; set; } = 0;
        public int ShareCount { get; set; } = 0;
    }

    public class AnecdoteAddViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
    }

    public class AnecdoteUpdateViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Owner { get; set; }
        [Required]
        public string Content { get; set; }
        public bool Status { get; set; }
    }
}
