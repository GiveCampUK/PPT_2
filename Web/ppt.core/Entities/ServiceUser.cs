namespace ppt.core.Entities
{
    public class ServiceUser : AggregateRoot
    {
        public string ContactDetailsId { get; set; }
        public ServiceUserType Type { get; set; }
    }

    public enum ServiceUserType
    {
        Prisoner,
        ExPrisoner,
        OverseasPrisoner,
        Other,
    }
}
