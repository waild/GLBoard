using Domain.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Post : IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

    }
}


