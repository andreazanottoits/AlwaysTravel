using RepoDb.Attributes;

namespace AlwaysTravel.DTO
{
    public class BaseEntity<T>
    {
        [Map("id")]
        public T Id { get; set; }
    }
}
