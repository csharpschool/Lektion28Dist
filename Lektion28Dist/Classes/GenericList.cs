using Lektion28Dist.Interfaces;

namespace Lektion28Dist.Classes;

public class GenericList<T> : List<T> where T : class, IName, new()
{
    public List<T> Get(Func<T, bool>? lambda)
    {
        if (lambda is null) return this;
        return this.Where(lambda).ToList();
    }

    public new void Add(T? item)
    {
        if(item is null) item = new T() { Name = "Empty object" };
        
        base.Add(item);
    }
}
