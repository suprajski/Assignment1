using System.ComponentModel.DataAnnotations;

namespace WebApplication.Shared.Models {
    public class Person {
    
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public int Height { get; set; }
        public string Sex { get; set; }

        public Person()
        {
        
        }
        public Person(int id, string firstName, string lastName, string hairColor, string eyeColor, int age, float weight, int height, string sex)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            HairColor = hairColor;
            EyeColor = eyeColor;
            Age = age;
            Weight = weight;
            Height = height;
            Sex = sex;
        }
    }


}