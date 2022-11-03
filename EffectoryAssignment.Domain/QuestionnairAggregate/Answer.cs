namespace EffectoryAssignment.Domain.QuestionnairAggregate;

public class Answer : QuestionnaireItem
{
    public int QuestionId { get; init; }
    public int? AnswerId { get; init; }
    public AnswerType AnswerType { get; init; }
    public override ItemType ItemType => ItemType.Answer;
    public Answer(int? answerId, int questionId, IDictionary<string, string>? texts, int orderNumber, AnswerType answerType, IReadOnlyCollection<QuestionnaireItem>? questionnaireItems) : base(texts, orderNumber, questionnaireItems)
    {
        QuestionId = questionId;
        AnswerType = answerType;
        AnswerId = answerId;
    }
}