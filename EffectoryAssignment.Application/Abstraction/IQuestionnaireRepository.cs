using EffectoryAssignment.Domain.QuestionnairAggregate;
using EffectoryAssignment.Domain.SeedWork;
using X.PagedList;

namespace EffectoryAssignment.Application.Abstraction;

public interface IQuestionnaireRepository : IRepository<Questionnaire>
{
    IPagedList<Question> GetQuestions(int[] questionIds, int pageNo, int pageSize);
}