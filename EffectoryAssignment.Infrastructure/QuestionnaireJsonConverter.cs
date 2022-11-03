using EffectoryAssignment.Domain.QuestionnairAggregate;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EffectoryAssignment.Infrastructure
{
    public class QuestionnaireJsonConverter : JsonConverter<Questionnaire>
    {

        public override Questionnaire Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            if (!reader.Read()
                    || reader.TokenType != JsonTokenType.PropertyName
                    || reader.GetString() != "QuestionnaireItems")
            {
                throw new JsonException();
            }

            if (!reader.Read() || reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            var items = (Questionnaire)JsonSerializer.Deserialize(ref reader, typeof(List<QuestionnaireItem>));

            return items;
        }

        public override void Write(
            Utf8JsonWriter writer,
            Questionnaire value,
            JsonSerializerOptions options)
        {
            writer.WriteStartObject();


            JsonSerializer.Serialize(writer, value);


            writer.WriteEndObject();
        }
    }
}
