using EffectoryAssignment.Api.Mapping;
using EffectoryAssignment.Api.Requests;
using EffectoryAssignment.Api.Responses;
using EffectoryAssignment.Application.Contracts;
using EffectoryAssignment.Application.Mapping;
using EffectoryAssignment.Application.Services;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace EffectoryAssignment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionsController : ControllerBase
    {
        private readonly ILogger<QuestionsController> _logger;
        private readonly IQuestionService _questionService;
        private readonly IResultService _resultService;

        public QuestionsController(ILogger<QuestionsController> logger, IQuestionService questionService, IResultService resultService)
        {
            _logger = logger;
            _questionService = questionService;
            _resultService = resultService;
        }

        [HttpGet]
        public IPagedList<GetQuestionsResponse> GetQuestions([FromQuery] PagingParameters pagingParameters, [FromQuery] int[] questionIds)
        {
            return _questionService.GetQuestions(pagingParameters, questionIds).ToApiResponse();
        }
        [HttpPost]
        public IActionResult SetAnswer([FromBody] SetAnswerRequest request)
        {
            _resultService.AddResult(request.ToApplicationRequest());
            return Ok();
        }

        [HttpGet("{questionId}")]

        public GetResultsResponse GetResults(int questionId)
        {
            return _resultService.GetResults(questionId).ToApiResponse();
        }
    }
}