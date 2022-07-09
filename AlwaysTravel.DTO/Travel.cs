

using RepoDb.Attributes;

namespace AlwaysTravel.DTO
{
    [Map("travel")]
    public class Travel : BaseEntity<int>
    {
        [Map("name")]
        public string Name { get; set; }
        [Map("startDate")]

        public DateTime StartDate { get; set; }
        [Map("endDate")]

        public DateTime EndDate { get; set; }
    }
}
