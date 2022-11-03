using EffectoryAssignment.Application.Contracts;
using EffectoryAssignment.Domain.QuestionnairAggregate;
using X.PagedList;

namespace EffectoryAssignment.Application.Mapping
{
    public static class QuestionMapping
    {
        public static QuestionDto ToDto(this Question question)
        {
            return new QuestionDto
            {
                QuestionId = question.QuestionId,
                SubjectId = question.SubjectId,
                OrderNumber = question.OrderNumber,
                Texts = question.Texts,
                AnswerCategoryType = question.AnswerCategoryType
            };
        }
        public static IPagedList<QuestionDto> ToDto(this IPagedList<Question> question)
        {
            return new PagedList<QuestionDto>(question.Select(ToDto), question.PageNumber, question.PageSize);
        }
    }
}
