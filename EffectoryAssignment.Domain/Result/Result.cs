using EffectoryAssignment.Domain.SeedWork;

namespace EffectoryAssignment.Domain.Result
{
    public class Result : IAggregateRoot
    {
        public int QuestionId { get; init; }
        public int AnswerId { get; init; }
        public int UserId { get; init; }
        public Department Department { get; init; }
        public Result(int questionId, int answerId, int userId, Department department)
        {
            QuestionId = questionId;
            AnswerId = answerId;
            UserId = userId;
            Department = department;
        }
    }
}
