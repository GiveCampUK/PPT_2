namespace PPT.Web.Code.Domain
{
    public class Contact
    {
        public virtual int Id { get; set; }
        public virtual string Forename { get; set; }
        public virtual string Surname { get; set; }
        public virtual string EmailAddress { get; set; }
    }
}