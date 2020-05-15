using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Anecdote : BaseEntity<int>
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Owner { get; set; } = "Temel";
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
        [Required]
        public bool Status { get; set; } = true;

        public virtual Detail Detail { get; set; }
    }
}
