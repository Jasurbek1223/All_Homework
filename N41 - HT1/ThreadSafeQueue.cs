using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N41___HT1;

public class ThreadSafeQueue<T> : ISafeQueue<T>
{
    private List<T> _list;
    private readonly object _locker = new object();

    public ThreadSafeQueue()
    {
        _list = new List<T>();
    }

    public void Enqueue(T item)
    {
        lock (_locker)
        {
            if(item == null)
                throw new ArgumentNullException("null");
            _list.Add(item);
        }
    }

    public T Dequeue()
    {
        lock (_locker)
        {
            var res = _list.FirstOrDefault();
            if(res != null)
            {
                _list.Remove(res);
                return res;
            }

            throw new InvalidOperationException("0 items left");
        }
    }
}
