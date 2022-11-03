using EffectoryAssignment.Domain.Result;

namespace EffectoryAssignment.Api.Requests
{
    public record SetAnswerRequest
    {
        public int UserId { get; init; }
        public IEnumerable<SetAnswerRequestItem> Answers { get; init; }
    }
    public record SetAnswerRequestItem
    {
        public int AnswerId { get; init; }
        public int QuestionId { get; init; }

        public Department Department { get; init; }
    }
}
