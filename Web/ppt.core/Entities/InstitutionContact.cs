namespace ppt.core.Entities
{
    public class InstitutionContact : AggregateRoot
    {
        public string ContactDetailsId { get; set; }
        public InstitutionContactRole Role { get; set; }
    }

    public enum InstitutionContactRole
    {
        Chaplain,
        Librarian,
        Warden,
        MedicalOfficer,
        Other,
    }
}
