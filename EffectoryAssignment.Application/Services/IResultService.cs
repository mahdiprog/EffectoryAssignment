using EffectoryAssignment.Application.Requests;
using EffectoryAssignment.Application.Responses;

namespace EffectoryAssignment.Application.Services;

public interface IResultService
{
    void AddResult(AddResultRequest request);
    CalculatedResult GetResults(int questionId);
}