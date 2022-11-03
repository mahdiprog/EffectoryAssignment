using EffectoryAssignment.Application.Responses;
using EffectoryAssignment.Domain.Result;
using EffectoryAssignment.Domain.SeedWork;

namespace EffectoryAssignment.Application.Abstraction;

public interface IResultRepository : IRepository<Result>
{
    void Add(int userId, int questionId, int answerId, Department department);
    CalculatedResult GetResults(int questionId);
}