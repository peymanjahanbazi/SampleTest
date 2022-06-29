using Store;

List<Entity> yesterday = new List<Entity> {
            new Entity{
                EntityId =new Guid("00000000-0000-0000-0000-000000000000"),
                Price = 10
            },
            new Entity{
                EntityId =new Guid("00000000-0000-0000-0000-000000000002"),
                Price = 10
            },
            new Entity{
                EntityId =new Guid("00000000-0000-0000-0000-000000000003"),
                Price = 10
            },new Entity{
                EntityId =new Guid("00000000-0000-0000-0000-000000000006"),
                Price = 10
            }
        };

List<Entity> today = new List<Entity> {
            new Entity{
                EntityId =new Guid("00000000-0000-0000-0000-000000000000"),
                Price = 10
            },
            new Entity{
                EntityId =new Guid("00000000-0000-0000-0000-000000000001"),
                Price = 10
            },
            new Entity{
                EntityId =new Guid("00000000-0000-0000-0000-000000000003"),
                Price = 10
            },new Entity{
                EntityId =new Guid("00000000-0000-0000-0000-000000000005"),
                Price = 10
            }
        };
PriceComparator pc = new PriceComparator();
var result = pc.Compare(yesterday, today);
Console.WriteLine("Deleted Items");
result.DeletedItems.ForEach(x => Console.WriteLine(x));
Console.WriteLine("New Items");
result.NewItems.ForEach(x => Console.WriteLine(x));
Console.WriteLine("Item with no changes");
result.NotChangedItems.ForEach(x => Console.WriteLine(x));