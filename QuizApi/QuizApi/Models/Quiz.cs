namespace QuizApi.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public int Difficulty { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }
    }
}
