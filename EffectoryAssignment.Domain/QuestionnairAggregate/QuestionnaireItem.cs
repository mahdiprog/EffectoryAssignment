namespace EffectoryAssignment.Domain.QuestionnairAggregate
{
    public abstract class QuestionnaireItem
    {
        public int OrderNumber { get; private set; }
        public IDictionary<string, string>? Texts { get; private set; }
        public abstract ItemType ItemType { get; }

        private List<QuestionnaireItem>? _questionnaireItems;
        public IReadOnlyCollection<QuestionnaireItem>? QuestionnaireItems => _questionnaireItems;

        public QuestionnaireItem(IDictionary<string, string>? texts, int orderNumber, IReadOnlyCollection<QuestionnaireItem>? questionnaireItems)
        {
            Texts = texts;
            OrderNumber = orderNumber;
            if (questionnaireItems != null)
                _questionnaireItems = questionnaireItems.ToList();
        }


        public void AddQuestionnaireItem(QuestionnaireItem questionnaireItem)
        {
            _questionnaireItems ??= new List<QuestionnaireItem>();
            _questionnaireItems.Add(questionnaireItem);
        }

        public void SetOrderNumber(int orderNumber)
        {
            OrderNumber = orderNumber;
        }

        public void SetText(string locale, string text)
        {
            if (Texts.ContainsKey(locale))
            {
                Texts[locale] = text;
            }
            else
            {
                Texts.Add(locale, text);
            }
        }
    }
}
