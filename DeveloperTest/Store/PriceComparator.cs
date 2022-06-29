namespace Store;

public static class PriceComparator
{
    public static (List<Entity> NotChangedItems, List<Entity> DeletedItems, List<Entity> NewItems)
        Compare(List<Entity> yesterdayItems, List<Entity> todayItems)
    {
        if (yesterdayItems is null)
        {
            throw new ArgumentNullException(nameof(yesterdayItems));
        }

        if (todayItems is null)
        {
            throw new ArgumentNullException(nameof(todayItems));
        }

        List<Entity> notChangedItems = new();
        List<Entity> deletedItems = new();
        List<Entity> newItems = new();
        yesterdayItems.Sort((x, y) =>
        {
            return x.EntityId.CompareTo(y.EntityId);
        });
        todayItems.Sort((x, y) =>
        {
            return x.EntityId.CompareTo(y.EntityId);
        });
        int yesterdayIndex = 0;
        int todayIndex = 0;
        while (yesterdayIndex < yesterdayItems.Count && todayIndex < todayItems.Count)
        {
            int comparisionResult = yesterdayItems[yesterdayIndex].EntityId.CompareTo(todayItems[todayIndex].EntityId);
            if (comparisionResult == 0)
            {
                if (yesterdayItems[yesterdayIndex].Price == todayItems[todayIndex].Price)
                {
                    notChangedItems.Add(todayItems[todayIndex]);
                }
                todayIndex++;
                yesterdayIndex++;
            }
            else if (comparisionResult < 0)
            {
                deletedItems.Add(yesterdayItems[yesterdayIndex]);
                yesterdayIndex++;
            }
            else
            {
                newItems.Add(todayItems[todayIndex]);
                todayIndex++;
            }
        }
        if (yesterdayIndex < yesterdayItems.Count)
        {
            deletedItems.AddRange(yesterdayItems.Skip(yesterdayIndex));
        }
        else if (todayIndex < todayItems.Count)
        {
            newItems.AddRange(todayItems.Skip(todayIndex));
        }

        return (notChangedItems, deletedItems, newItems);
    }
}