namespace WebApplication.Shared.Models
{
    public class Adult : Person
    {
        public Job JobTitle { get; set; }

        public Adult()
        {
            JobTitle = new Job();
        }

        public Adult(int id, string firstName, string lastName, string hairColor, string eyeColor, int age,
            float weight, int height, string sex, Job jobTitle) : base(id, firstName, lastName, hairColor, eyeColor,
            age, weight, height, sex)
        {
            JobTitle = jobTitle;
        }
    }
}