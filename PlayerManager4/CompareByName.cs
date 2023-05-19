using System.Runtime.InteropServices;

namespace PlayerManager4;

public class CompareByName : IComparer<Player>
{
    public int SortingOrder { get; private set; }

    public CompareByName([Optional] bool sortingOrder)
    {
        SortingOrder = -1 * Convert.ToInt16(sortingOrder);
    }

    public int Compare(Player? x, Player? y)
    {
        if (y == null) return 1;
        if (SortingOrder == -1) return x.Score.CompareTo(y.Score);
        else if (SortingOrder == 0) return String.Compare(x.Name, y.Name, StringComparison.Ordinal);
        return -String.Compare(x.Name, y.Name,StringComparison.Ordinal);
    }
    
}