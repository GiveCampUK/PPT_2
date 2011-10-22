using System;
using ppt.core.Entities;

namespace ppt.core.Requests
{
    public class InstructorRegistrationRequest
    {
        public InstructorType Type { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public int YearBeganTeaching { get; set; }
        public Qualification[] Qualifications { get; set; }
        public string BwyNumber { get; set; }
        public string CurrentTeaching { get; set; }
        public string YogaExperience { get; set; }
        public string PrisonExperience { get; set; }
        public string SeatedMeditationInstructionExperience { get; set; }

        public DateTime DateOfBirth { get; set; }
        public Sex Sex { get; set; }
        public string MeditationPersonalPractice { get; set; }
        public string ExperienceWithYoungPeople { get; set; }
        public string OtherRelevantExperience { get; set; }
        public string ReasonsForInterestInPrisonTeaching { get; set; }
        public string GeneralWorkExperience { get; set; }
        public bool HasCriminalRecord { get; set; }
        public string RelevantHealthIssues { get; set; }
        public string CurrentMedication { get; set; }
        
        public DateTime ApplicationDate { get; set; }
    }

    public class Qualification
    {
        public string Name { get; set; }
        public string School { get; set; }
        public DateTime DateQualified { get; set; }
        public string CourseLength { get; set; }
    }

    public enum Sex
    {
        Male,
        Female,
        Other,
    }
}
