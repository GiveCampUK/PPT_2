namespace ppt.core.Entities
{
    public class Correspondence : AggregateRoot
    {
        public string ServiceUserId { get; set; }
        public string SenderContactDetailsId { get; set; }
    }
}
