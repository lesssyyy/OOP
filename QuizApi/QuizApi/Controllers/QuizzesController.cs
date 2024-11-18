using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizApi.Models;

namespace QuizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]  // Ensure authentication is required for all actions in this controller
    public class QuizzesController : ControllerBase
    {
        private static List<Quiz> quizzes = new List<Quiz>
        {
            new Quiz { Id = 1, Title = "Math Basics", Category = "Mathematics", Difficulty = 1, QuestionText = "What is 2 + 2?", Answer = "4" },
            new Quiz { Id = 2, Title = "Science Quiz", Category = "Science", Difficulty = 2, QuestionText = "What planet is closest to the Sun?", Answer = "Mercury" },
            new Quiz { Id = 3, Title = "Geography Basics", Category = "Geography", Difficulty = 1, QuestionText = "What is the capital of France?", Answer = "Paris" },
            new Quiz { Id = 4, Title = "History Quiz", Category = "History", Difficulty = 3, QuestionText = "Who was the first President of the United States?", Answer = "George Washington" },
            new Quiz { Id = 5, Title = "Advanced Math", Category = "Mathematics", Difficulty = 4, QuestionText = "What is the integral of sin(x)?", Answer = "-cos(x)" },
            new Quiz { Id = 6, Title = "Physics Challenge", Category = "Science", Difficulty = 5, QuestionText = "What is the speed of light in a vacuum?", Answer = "299,792,458 meters per second" },
            new Quiz { Id = 7, Title = "World Capitals", Category = "Geography", Difficulty = 2, QuestionText = "What is the capital of Australia?", Answer = "Canberra" },
            new Quiz { Id = 8, Title = "Chemistry Quiz", Category = "Science", Difficulty = 3, QuestionText = "What is the chemical symbol for Gold?", Answer = "Au" },
            new Quiz { Id = 9, Title = "Art History", Category = "Art", Difficulty = 2, QuestionText = "Who painted the Mona Lisa?", Answer = "Leonardo da Vinci" },
            new Quiz { Id = 10, Title = "Programming Basics", Category = "Technology", Difficulty = 1, QuestionText = "Which language is used for web development?", Answer = "JavaScript" }
        };

        // GET: api/quizzes
        [HttpGet]
        public IEnumerable<Quiz> GetQuizzes()
        {
            return quizzes;
        }

        // GET: api/quizzes/{id}
        [HttpGet("{id}")]
        public ActionResult<Quiz> GetQuiz(int id)
        {
            var quiz = quizzes.Find(q => q.Id == id);
            if (quiz == null)
                return NotFound();
            return quiz;
        }

        // POST: api/quizzes
        [HttpPost]
        public ActionResult<Quiz> PostQuiz(Quiz quiz)
        {
            quiz.Id = quizzes.Count + 1;
            quizzes.Add(quiz);
            return CreatedAtAction(nameof(GetQuiz), new { id = quiz.Id }, quiz);
        }

        // PUT: api/quizzes/{id}
        [HttpPut("{id}")]
        public IActionResult PutQuiz(int id, Quiz updatedQuiz)
        {
            var quiz = quizzes.Find(q => q.Id == id);
            if (quiz == null)
                return NotFound();

            quiz.Title = updatedQuiz.Title;
            quiz.Category = updatedQuiz.Category;
            quiz.Difficulty = updatedQuiz.Difficulty;
            quiz.QuestionText = updatedQuiz.QuestionText;
            quiz.Answer = updatedQuiz.Answer;

            return NoContent();
        }

        // DELETE: api/quizzes/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteQuiz(int id)
        {
            var quiz = quizzes.Find(q => q.Id == id);
            if (quiz == null)
                return NotFound();

            quizzes.Remove(quiz);
            return NoContent();
        }
    }
}
