using DAL.Models;

namespace DAL.Interfaces
{
    public interface IQuestionRepository
    {
        Task<IEnumerable<object>> GetQuestions();
        Task<IEnumerable<object>> RetrieveAnswer(int[] questionIds);
    }
}
