using EffectoryAssignment.Api.Requests;
using EffectoryAssignment.Application.Requests;
using X.PagedList;

namespace EffectoryAssignment.Api.Mapping
{
    public static class RequestMapping
    {
        public static AddResultRequest ToApplicationRequest(this SetAnswerRequest request)
        {
            return new AddResultRequest
            {
                UserId = request.UserId,
                Answers = request.Answers.Select(a => new AddResultItem
                {
                    AnswerId = a.AnswerId,
                    QuestionId = a.QuestionId,
                    Department = a.Department
                })
            };
        }
    }
}
