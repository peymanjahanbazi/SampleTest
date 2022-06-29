using Store;

List<Entity> yesterday = InitializeYesterdayList();
List<Entity> today = InitializeTodayList();

var (NotChangedItems, DeletedItems, NewItems) = PriceComparator.Compare(yesterday, today);

Console.WriteLine("Deleted Items");
DeletedItems.ForEach(x => Console.WriteLine(x));
Console.WriteLine();
Console.WriteLine("New Items");
NewItems.ForEach(x => Console.WriteLine(x));
Console.WriteLine();
Console.WriteLine("Item with no changes");
NotChangedItems.ForEach(x => Console.WriteLine(x));

List<Entity> InitializeYesterdayList()
{
    return new()
    {
        new Entity
        {
            EntityId = new Guid("00000000-0000-0000-0000-000000000000"),
            Price = 11
        },
        new Entity
        {
            EntityId = new Guid("00000000-0000-0000-0000-000000000006"),
            Price = 10
        },
        new Entity
        {
            EntityId = new Guid("00000000-0000-0000-0000-000000000003"),
            Price = 10
        },
        new Entity
        {
            EntityId = new Guid("00000000-0000-0000-0000-000000000002"),
            Price = 10
        }
    };
}

List<Entity> InitializeTodayList()
{
    return new()
    {
        new Entity
        {
            EntityId = new Guid("00000000-0000-0000-0000-000000000000"),
            Price = 10
        },
        new Entity
        {
            EntityId = new Guid("00000000-0000-0000-0000-000000000001"),
            Price = 10
        },
        new Entity
        {
            EntityId = new Guid("00000000-0000-0000-0000-000000000003"),
            Price = 10
        },
        new Entity
        {
            EntityId = new Guid("00000000-0000-0000-0000-000000000005"),
            Price = 10
        }
    };
}