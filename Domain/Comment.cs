using Domain.Abstractions;

namespace Domain
{
    public class Comment : IEntity<int>
    {
        public int Id { get; set; }
    }
}


