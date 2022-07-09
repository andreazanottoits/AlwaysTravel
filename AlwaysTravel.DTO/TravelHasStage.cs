using RepoDb.Attributes;

namespace AlwaysTravel.DTO
{
    [Map("travel_has_stage")]

    public class TravelHasStage : BaseEntity<int>
    {
        [Map("travel_id")]

        public int TravelId { get; set; }
        [Map("stage_id")]

        public int StageId { get; set; }
    }
}
