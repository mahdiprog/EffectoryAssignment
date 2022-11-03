using EffectoryAssignment.Application.Contracts;
using X.PagedList;

namespace EffectoryAssignment.Application.Services;

public interface IQuestionService
{
    IPagedList<QuestionDto> GetQuestions(PagingParameters pagingParameters, params int[] questionIds);
}