using EffectoryAssignment.Application.Abstraction;
using EffectoryAssignment.Application.Services;
using EffectoryAssignment.Domain.QuestionnairAggregate;
using EffectoryAssignment.Infrastructure;
using EffectoryAssignment.Infrastructure.Repositories;
using System.Text.Json;

namespace EffectoryAssignment.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services.AddSingleton(_ =>
            {
                string fileName = "questionnaire.json";
                string jsonString = File.ReadAllText(fileName);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    Converters =
                    {
                        new QuestionnaireItemJsonConverter()
                    }
                };
                return JsonSerializer.Deserialize<Questionnaire>(jsonString, options)!;
            });

            services.AddScoped<IQuestionnaireRepository, QuestionnaireRepository>(provider =>
            {
                var questionnaire = provider.GetService<Questionnaire>();
                return new QuestionnaireRepository(questionnaire);
            });

            services.AddScoped<IResultRepository, ResultRepository>();

            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IResultService, ResultService>();

            return services;
        }
    }
}
