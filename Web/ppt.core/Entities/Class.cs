using System;

namespace ppt.core.Entities
{
    public class Class
    {
        public string InstitutionId { get; set; }
        public string[] InstructorIds { get; set; }
        public string[] ServiceUserIds { get; set; }
        public DateTime StartDate { get; set; }
    }
}
