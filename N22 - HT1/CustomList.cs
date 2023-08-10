using System.Collections;

namespace N22___HT1;

class CustomList<T> 
{
    private T[] _items;
    private int _count;
    private const int DefaultCapasity = 2;


    public CustomList()
    {
        _items = new T[DefaultCapasity];
        _count = 0;
    }

    public CustomList(int capasity)
    {
        _items = new T[capasity];
        _count = 0;
    }


    public void Add(T item)
    {
        if(_count == _items.Length)
        {
            ResizeArray();
        }
        _items[_count++] = item;
    }

    public void AddRange(T[] items)
    {
        foreach(T item in items)
        {
            Add(item);
        }
    }

    public bool Contains(T item)
    {
        for(int i=0; i<_items.Length; i++)
        {
            if (_items[i].Equals(item))
                return true;
        }
        return false;
    }

    public void CopyTo(T[] array)
    {
        if(array.Length < _count)
        {
            throw new ArgumentException("Small length");
        }

        for(int i=0; i<_count; i++)
        {
            array[i] = _items[i];
        }
    }

    public int IndexOf(T item)
    {
        for(int i=0; i < _count; i++)
        {
            if (_items[i].Equals(item)) return i;
        }
        return -1;
    }

    public void Insert(int index, T item)
    {
        if(index < 0 || index >= _items.Length) { throw new ArgumentOutOfRangeException("Index out of range"); }

        if(_count == _items.Length)
            ResizeArray();
        
        for(int i = _count; i > index; i--)
            _items[i] = _items[i-1];

        _items[index] = item;
        _count++;

    }

    public void InsertRange(int index, params T[] items)
    {
        foreach(T item in items)
        {
            Insert(index, item);
            index++;
        }
    }

    public bool Remove(T item)
    {
        int index = IndexOf(item);
        if(index >= 0)
        {
            RemoveAt(index); return true;
        }
        return false;
    }


    public bool RemoveAt(int index)
    {
        if(index < 0 || index >= _count)
        {
            return false;
        }

        for(int i = index; i< _count-1; i++)
        {
            _items[i] = _items[i+1];
        }

        _count--;
        return true;

    }

    public T[] ToArray()
    {
        T[] newArray = new T[_count];
        Array.Copy(_items, newArray, _count); 
        return newArray;
    }



    private void ResizeArray()
    {
        ResizeArray(_items.Length * 2);
    }

    private void ResizeArray(int newSize)
    {
        T[] newArray = new T[newSize];
        Array.Copy(_items, newArray, _count);
        _items = newArray;
    }





}
