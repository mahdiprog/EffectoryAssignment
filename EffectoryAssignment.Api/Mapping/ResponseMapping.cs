using EffectoryAssignment.Api.Responses;
using EffectoryAssignment.Application.Contracts;
using EffectoryAssignment.Application.Responses;
using X.PagedList;

namespace EffectoryAssignment.Api.Mapping
{
    public static class ResponseMapping
    {
        public static GetQuestionsResponse ToApiResponse(this QuestionDto question)
        {
            return new GetQuestionsResponse
            {
                QuestionId = question.QuestionId,
                SubjectId = question.SubjectId,
                OrderNumber = question.OrderNumber,
                Texts = question.Texts,
                AnswerCategoryType = question.AnswerCategoryType
            };
        }
        public static IPagedList<GetQuestionsResponse> ToApiResponse(this IPagedList<QuestionDto> question)
        {
            return new PagedList<GetQuestionsResponse>(question.Select(ToApiResponse), question.PageNumber, question.PageSize);
        }
        public static GetResultsResponse ToApiResponse(this CalculatedResult question)
        {
            return new GetResultsResponse
            {
                QuestionId = question.QuestionId,
                AnswerId = question.AnswerId,
                Department = question.Department,
                Average = question.Average,
                Min = question.Min,
                Max = question.Max,
            };
        }
    }
}
