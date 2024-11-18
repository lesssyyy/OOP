namespace QuizApi.DataHelper
{
    public static class InMemoryStorage
    {
        public static List<User> Users = new List<User>
        {
            new User { UserId = 1, Username = "teacher1", Password = "7913c3398c0ac34f4edbd4bc3ab2823a", Email = "teacher1@example.com" }, // Password: password
            new User { UserId = 2, Username = "teacher2", Password = "5f85743b1b58d1c67ef668e36393bbfe", Email = "teacher2@example.com" }  // Password: password123
        };

        public static List<Subject> Subjects = new List<Subject>
        {
            new Subject { SubjectId = 1, SubjectName = "Mathematics" },
            new Subject { SubjectId = 2, SubjectName = "Science" },
            new Subject { SubjectId = 3, SubjectName = "History" },
            new Subject { SubjectId = 4, SubjectName = "English" }
        };

        public static List<Category> Categories = new List<Category>
        {
            new Category { CategoryId = 1, CategoryName = "Multiple Choice" },
            new Category { CategoryId = 2, CategoryName = "Identification" },
            new Category { CategoryId = 3, CategoryName = "Essay" }
        };

        public static List<Question> Questions = new List<Question>
        {
            new Question
            {
                QuestionId = 1,
                CategoryId = 1,
                SubjectId = 1,
                QuestionText = "What is 2 + 2?"
            },
            new Question
            {
                QuestionId = 2,
                CategoryId = 2,
                SubjectId = 2,
                QuestionText = "Identify the chemical symbol for water."
            }
        };

        public static List<Option> Options = new List<Option>
        {
            new Option { OptionId = 1, QuestionId = 1, OptionText = "3" },
            new Option { OptionId = 2, QuestionId = 1, OptionText = "4" },
            new Option { OptionId = 3, QuestionId = 1, OptionText = "5" },
            new Option { OptionId = 4, QuestionId = 1, OptionText = "6" }
        };

        public static List<Answer> Answers = new List<Answer>
        {
            new Answer { AnswerId = 1, QuestionId = 1, CorrectOption = "4" },
            new Answer { AnswerId = 2, QuestionId = 2, CorrectOption = "H2O" }
        };
    }

    // Supporting Models
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Hashed Password
        public string Email { get; set; }
    }

    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class Question
    {
        public int QuestionId { get; set; }
        public int CategoryId { get; set; }
        public int SubjectId { get; set; }
        public string QuestionText { get; set; }
    }

    public class Option
    {
        public int OptionId { get; set; }
        public int QuestionId { get; set; }
        public string OptionText { get; set; }
    }

    public class Answer
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string CorrectOption { get; set; }
    }
}
