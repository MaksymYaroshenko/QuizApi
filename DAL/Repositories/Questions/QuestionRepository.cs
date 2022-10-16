using DAL.DbConnection;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Questions
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly QuizDatabaseContext _db;

        public QuestionRepository(QuizDatabaseContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<object>> GetQuestions()
        {
            IEnumerable<object> questions = (IEnumerable<object>)await _db.Questions
                .Select(x => new
                {
                    QuestionId = x.QuestionId,
                    QuestionName = x.QuestionName,
                    QuestionImage = x.QuestionImage,
                    Options = new string[] { x.Option1, x.Option2, x.Option3, x.Option4 }
                })
                .OrderBy(y => Guid.NewGuid())
                .Take(5)
                .ToListAsync();
            return questions;
        }

        public async Task<Question> GetQuestion(int id)
        {
            return await _db.Questions.FindAsync(id);
        }

        public async Task<IEnumerable<object>> RetrieveAnswer(int[] questionIds)
        {
            return await (_db.Questions.Where(i => questionIds.Contains(i.QuestionId))
                .Select(x => new
                {
                    QuestionId = x.QuestionId,
                    QuestionName = x.QuestionName,
                    QuestionImage = x.QuestionImage,
                    Options = new string[] { x.Option1, x.Option2, x.Option3, x.Option4 },
                    Answer = x.Answer
                })).ToListAsync();
        }
    }
}
