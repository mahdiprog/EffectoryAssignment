using EffectoryAssignment.Domain.Result;

namespace EffectoryAssignment.Application.Requests
{
    public record AddResultRequest
    {
        public int UserId { get; init; }
        public IEnumerable<AddResultItem> Answers { get; init; }
    }

    public record AddResultItem
    {
        public int QuestionId { get; init; }
        public int AnswerId { get; init; }
        public Department Department { get; init; }
    }
}
