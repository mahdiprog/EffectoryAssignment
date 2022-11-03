using EffectoryAssignment.Domain.SeedWork;

namespace EffectoryAssignment.Domain.Result;

public class Department : Enumeration
{
    public static Department Marketing = new(1, nameof(Department).ToLowerInvariant());
    public static Department Sales = new(2, nameof(Sales).ToLowerInvariant());
    public static Department Development = new(3, nameof(Development).ToLowerInvariant());
    public static Department Reception = new(4, nameof(Reception).ToLowerInvariant());

    public Department(int id, string name) : base(id, name)
    {
    }

}

