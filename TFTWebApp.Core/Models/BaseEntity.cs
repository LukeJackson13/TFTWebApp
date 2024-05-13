using System.ComponentModel.DataAnnotations;

namespace TFTWebApp.Core.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
    }
}
