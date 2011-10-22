namespace ppt.core.Entities
{
    public class ContactDetails : AggregateRoot
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public PhoneNumber[] PhoneNumbers { get; set; }
        public EmailAddress[] EmailAddresses { get; set; }
        public ContactRole[] Roles { get; set; }
    }

    public enum ContactRole
    {
        ServiceUser,
        Instructor,
        Friend,
    }

    public class PhoneNumber
    {
        public string Number { get; set; }
        public PhoneNumberType Type { get; set; }
    }

    public class EmailAddress
    {
        public string Value { get; set; }
        public EmailAddressType Type { get; set; }
    }

    public enum EmailAddressType
    {
        Personal,
        Work,
        Other,
    }

    public enum PhoneNumberType
    {
        Mobile,
        Home,
        Work,
        Other,
    }
}
