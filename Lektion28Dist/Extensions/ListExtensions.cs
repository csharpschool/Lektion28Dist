using Lektion28Dist.Interfaces;

namespace Lektion28Dist.Extensions;

public static class ListExtensions
{
    public static List<T> GetNames<T>(this List<T> list) where T : class, IName
    {
        foreach (var item in list) { item.Name += " Altered"; }
        return list;
    }

}
