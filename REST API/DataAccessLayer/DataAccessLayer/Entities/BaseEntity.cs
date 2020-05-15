using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
