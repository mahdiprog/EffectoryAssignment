namespace EffectoryAssignment.Domain.QuestionnairAggregate;

public class Question : QuestionnaireItem
{
    public int QuestionId { get; init; }
    public int SubjectId { get; init; }
    public AnswerCategoryType AnswerCategoryType { get; private set; }
    public override ItemType ItemType => ItemType.Question;
    public Question(int questionId, int subjectId, IDictionary<string, string> texts, int orderNumber, AnswerCategoryType answerCategoryType, IReadOnlyCollection<QuestionnaireItem>? questionnaireItems) : base(texts, orderNumber, questionnaireItems)
    {
        SubjectId = subjectId;
        AnswerCategoryType = answerCategoryType;
        QuestionId = questionId;
    }
}