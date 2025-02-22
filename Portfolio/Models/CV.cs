namespace Portfolio.Models
{
    public class CV
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<string> Skills { get; set; }
        public List<Education> EducationHistory { get; set; }
        public List<Experience> WorkExperience { get; set; }
    }

    public class Education
    {
        public string Degree { get; set; }
        public string Institution { get; set; }
        public string Year { get; set; }
    }

    public class Experience
    {
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
    }
}