using EffectoryAssignment.Application.Abstraction;
using EffectoryAssignment.Application.Responses;
using EffectoryAssignment.Domain.Result;

namespace EffectoryAssignment.Infrastructure.Repositories
{
    public class ResultRepository : IResultRepository
    {
        public void Add(int userId, int questionId, int answerId, Department department)
        {
            throw new NotImplementedException();
        }

        public CalculatedResult GetResults(int questionId)
        {
            throw new NotImplementedException();
        }
    }
}
