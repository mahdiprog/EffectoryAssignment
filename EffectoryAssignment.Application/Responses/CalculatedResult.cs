using EffectoryAssignment.Domain.Result;

namespace EffectoryAssignment.Application.Responses
{
    public class CalculatedResult
    {
        public int QuestionId { get; init; }
        public int AnswerId { get; init; }
        public Department Department { get; init; }
        public float Min { get; init; }
        public float Max { get; init; }
        public float Average { get; init; }
    }
}
