using EffectoryAssignment.Domain.QuestionnairAggregate;
using EffectoryAssignment.Domain.SeedWork;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EffectoryAssignment.Infrastructure
{
    public class QuestionnaireItemJsonConverter : JsonConverter<QuestionnaireItem>
    {
        public override QuestionnaireItem Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            if (typeToConvert != typeof(QuestionnaireItem))
            {
                return (QuestionnaireItem)JsonSerializer.Deserialize(ref reader, typeToConvert, options);
            }

            using var jsonDocument = JsonDocument.ParseValue(ref reader);
            if (!jsonDocument.RootElement.TryGetProperty("itemType", out var typeProperty))
            {
                throw new JsonException();
            }
            var itemType = Enumeration.FromValue<ItemType>(typeProperty.GetInt32());
            QuestionnaireItem? baseClass = null;
            var jsonObject = jsonDocument.RootElement.GetRawText();

            if (itemType == ItemType.Subject)
            {
                baseClass = (Subject)JsonSerializer.Deserialize(jsonObject, typeof(Subject), options);
            }
            else if (itemType == ItemType.Question)
            {
                baseClass = (Question)JsonSerializer.Deserialize(jsonObject, typeof(Question), options);
            }
            else if (itemType == ItemType.Answer)
            {
                baseClass = (Answer)JsonSerializer.Deserialize(jsonObject, typeof(Answer), options);
            }
            else
            {
                throw new NotSupportedException();
            }

            return baseClass;
        }

        public override void Write(
            Utf8JsonWriter writer,
            QuestionnaireItem value,
            JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            if (value is Subject subject)
            {
                JsonSerializer.Serialize(writer, subject);
            }
            else if (value is Question question)
            {
                JsonSerializer.Serialize(writer, question);
            }
            else if (value is Answer answer)
            {
                JsonSerializer.Serialize(writer, answer);
            }
            else
            {
                throw new NotSupportedException();
            }

            writer.WriteEndObject();
        }
    }
}
