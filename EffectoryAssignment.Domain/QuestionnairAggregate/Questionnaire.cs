using EffectoryAssignment.Domain.SeedWork;

namespace EffectoryAssignment.Domain.QuestionnairAggregate
{
    public class Questionnaire : IAggregateRoot
    {
        public int QuestionnaireId { get; init; }
        private readonly List<QuestionnaireItem> _questionnaireItems;

        public Questionnaire(int questionnaireId, IReadOnlyCollection<QuestionnaireItem>? questionnaireItems)
        {
            QuestionnaireId = questionnaireId;
            _questionnaireItems = questionnaireItems != null ? questionnaireItems.ToList() : new();
        }

        public IReadOnlyCollection<QuestionnaireItem> QuestionnaireItems => _questionnaireItems;

        public void AddQuestionnaireItem(QuestionnaireItem questionnaireItem)
        {
            _questionnaireItems.Add(questionnaireItem);
        }
    }
}
