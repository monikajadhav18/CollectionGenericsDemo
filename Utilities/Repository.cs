namespace CollectionGenericsDemo.Utilities;

public class Repository<T> where T : class
{
    private readonly List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public List<T> GetAll()
    {
        return items;
    }
}