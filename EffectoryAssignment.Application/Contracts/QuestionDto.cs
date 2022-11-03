using EffectoryAssignment.Domain.QuestionnairAggregate;

namespace EffectoryAssignment.Application.Contracts
{
    public record QuestionDto
    {
        public int QuestionId { get; init; }
        public int SubjectId { get; init; }
        public AnswerCategoryType AnswerCategoryType { get; init; }
        public int OrderNumber { get; init; }
        public IDictionary<string, string> Texts { get; init; }
    }
}
