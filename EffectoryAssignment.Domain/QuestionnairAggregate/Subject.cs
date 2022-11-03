namespace EffectoryAssignment.Domain.QuestionnairAggregate;

public class Subject : QuestionnaireItem
{
    public int SubjectId { get; init; }
    public override ItemType ItemType => ItemType.Subject;
    public Subject(int subjectId, IDictionary<string, string> texts, int orderNumber, IReadOnlyCollection<QuestionnaireItem>? questionnaireItems) : base(texts, orderNumber, questionnaireItems)
    {
        SubjectId = subjectId;
    }
}