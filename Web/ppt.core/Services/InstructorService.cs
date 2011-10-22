using ppt.core.Entities;
using ppt.core.Requests;
using Raven.Client;

namespace ppt.core.Services
{
    public class InstructorService
    {
        private readonly IDocumentSession _session;

        public InstructorService(IDocumentSession session)
        {
            _session = session;
        }

        public void RegisterInstructor(InstructorRegistrationRequest instructor)
        {
            var Instructor = new Instructor
                                 {
                                     ClassIds = null,
                                     Type = InstructorType.Meditation
                                 };
        }
    }
}
