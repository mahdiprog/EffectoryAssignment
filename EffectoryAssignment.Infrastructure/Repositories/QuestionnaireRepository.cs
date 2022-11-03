using EffectoryAssignment.Application.Abstraction;
using EffectoryAssignment.Domain.QuestionnairAggregate;
using X.PagedList;

namespace EffectoryAssignment.Infrastructure.Repositories
{
    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        private readonly Questionnaire _questionnaire;

        public QuestionnaireRepository(Questionnaire questionnaire)
        {
            _questionnaire = questionnaire;
        }

        public IPagedList<Question> GetQuestions(int[] questionIds, int pageNo, int pageSize)
        {
            var questions = _questionnaire.QuestionnaireItems
                .Where(q => q is Question question && (!questionIds.Any() || questionIds.Contains(question.QuestionId)))
                .Cast<Question>()
                .Union(_questionnaire.QuestionnaireItems.Where(q => Equals(q.ItemType, ItemType.Subject))
                    .SelectMany(s => (s.QuestionnaireItems ?? Array.Empty<Question>())
                        .Where(q => q is Question question && (!questionIds.Any() || questionIds.Contains(question.QuestionId)))
                        .Cast<Question>())).ToPagedList(pageNo, pageSize);
            return questions;
        }
    }
}
