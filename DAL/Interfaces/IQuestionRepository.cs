using DAL.Models;

namespace DAL.Interfaces
{
    public interface IQuestionRepository
    {
        Task<IEnumerable<object>> GetQuestions();
        Task<Question> GetQuestion(int id);
        Task<IEnumerable<object>> RetrieveAnswer(int[] questionIds);
    }
}
