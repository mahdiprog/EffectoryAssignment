using EffectoryAssignment.Application.Abstraction;
using EffectoryAssignment.Application.Contracts;
using EffectoryAssignment.Application.Mapping;
using X.PagedList;

namespace EffectoryAssignment.Application.Services
{

    public class QuestionService : IQuestionService
    {
        private readonly IQuestionnaireRepository _questionnaireRepository;

        public QuestionService(IQuestionnaireRepository questionnaireRepository)
        {
            _questionnaireRepository = questionnaireRepository;
        }

        public IPagedList<QuestionDto> GetQuestions(PagingParameters pagingParameters, params int[] questionIds)
        {
            return _questionnaireRepository.GetQuestions(questionIds, pagingParameters.PageNo,
                pagingParameters.PageSize).ToDto();
        }
    }
}
