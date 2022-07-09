using RepoDb.Attributes;

namespace AlwaysTravel.DTO
{
    [Map("package")]
    public class Package : BaseEntity<int>
    {
        [Map("name")]

        public string Name { get; set; }
        [Map("stage_id")]

        public int StageId { get; set; }
    }
}
