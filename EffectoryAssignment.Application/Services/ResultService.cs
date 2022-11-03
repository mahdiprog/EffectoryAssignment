using EffectoryAssignment.Application.Abstraction;
using EffectoryAssignment.Application.Requests;
using EffectoryAssignment.Application.Responses;

namespace EffectoryAssignment.Application.Services
{

    public class ResultService : IResultService
    {
        private readonly IResultRepository _userAnswerRepository;

        public ResultService(IResultRepository userAnswerRepository)
        {
            _userAnswerRepository = userAnswerRepository;
        }

        public void AddResult(AddResultRequest request)
        {
            foreach (var answer in request.Answers)
            {
                _userAnswerRepository.Add(request.UserId, answer.QuestionId, answer.AnswerId, answer.Department);
            }

        }

        public CalculatedResult GetResults(int questionId)
        {
            return _userAnswerRepository.GetResults(questionId);
        }
    }
}
