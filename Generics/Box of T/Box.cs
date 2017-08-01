using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Box<T>
{
    private IList<T> list;

    public Box()
    {
        this.list = new List<T>();
    }

    public int Count => this.list.Count;

    public void Add(T element)
    {
        this.list.Add(element);
    }

    public T Remove()
    {
        var remainder = list.LastOrDefault();
        list.RemoveAt(list.Count - 1);
        return remainder;
    }
}
