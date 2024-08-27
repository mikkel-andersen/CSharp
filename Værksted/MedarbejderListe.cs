namespace Værksted;

public class MedarbejderListe<TKey>
{
    private readonly Dictionary<TKey, Medarbejder > _collection = new Dictionary<TKey, Medarbejder >();

    public void AddElement(TKey k, Medarbejder p)
    {
        if (_collection.ContainsKey(k))
        {
            throw new ArgumentException("Person med CPR-Nr findes allerede");
        }
        _collection.Add(k, p);
    }

    public Medarbejder GetElement(TKey k)
    {
        if (!_collection.ContainsKey(k))
        {
            return null;
        }

        return _collection[k];
    }

    public int Size()
    {
        return _collection.Count;
    }
}