using RepoDb.Attributes;

namespace AlwaysTravel.DTO
{
    [Map("stage")]
    public class Stage : BaseEntity<int>
    {
        [Map("name")]
        public string Name { get; set; }
        [Map("date")]

        public DateTime Date { get; set; }
    }
}
