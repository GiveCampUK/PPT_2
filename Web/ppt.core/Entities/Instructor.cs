namespace ppt.core.Entities
{
    public class Instructor : AggregateRoot
    {
        public string ContactDetailsId { get; set; }
        public string[] ClassIds { get; set; }
        public bool IsCurrent { get; set; }
        public InstructorType Type { get; set; }
    }

    public enum InstructorType
    {
        Yoga,
        Meditation,
    }

    public enum InstructorStatus
    {
        Applied,
        Approved,
        Active,
        Dormant,
    }
}
