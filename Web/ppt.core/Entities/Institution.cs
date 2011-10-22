namespace ppt.core.Entities
{
    public class Instiution : AggregateRoot
    {
        public string Name { get; set; }
        public InstitutionType Type { get; set; }
        public string[] ContactIds { get; set; }
    }

    public enum InstitutionType
    {
        HMP,
        YoungOffendersInstitute,
        SecureMentalInstitute,
        BailHostel,
        Training,
        ImmigrationRemovalCentre,
        Other,
    }
}
