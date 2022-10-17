#nullable disable
using DAL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace QuizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        // GET: api/Question
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Question>>> GetQuestions()
        {
            var questions = await _questionRepository.GetQuestions();
            return Ok(questions);
        }

        // POST: api/Question/getanswers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("GetAnswers")]
        public async Task<ActionResult<Question>> RetrieveAnswer(int[] questionIds)
        {
            return Ok(await _questionRepository.RetrieveAnswer(questionIds));
        }
    }
}
