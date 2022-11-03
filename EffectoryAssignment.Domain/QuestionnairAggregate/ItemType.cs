using EffectoryAssignment.Domain.SeedWork;

namespace EffectoryAssignment.Domain.QuestionnairAggregate;

public class ItemType : Enumeration
{
    public static ItemType Subject = new(0, nameof(Subject).ToLowerInvariant());
    public static ItemType Question = new(1, nameof(Question).ToLowerInvariant());
    public static ItemType Answer = new(2, nameof(Answer).ToLowerInvariant());

    public ItemType(int id, string name) : base(id, name)
    {
    }

}

