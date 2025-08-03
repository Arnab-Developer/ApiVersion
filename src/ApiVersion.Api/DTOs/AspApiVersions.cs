using System.Collections;

namespace ApiVersion.Api.DTOs;

internal class AspApiVersions : IList<AspApiVersion>
{
    private readonly IList<AspApiVersion> _aspApiVersions;

    public AspApiVersions() : this(new List<AspApiVersion>() { new AspApiVersion(1, 0) })
    {
    }

    public AspApiVersions(IEnumerable<AspApiVersion> aspApiVersions)
    {
        _aspApiVersions = aspApiVersions.ToList();
    }

    public AspApiVersion this[int index]
    {
        get
        {
            return _aspApiVersions[index];
        }
        set
        {
            _aspApiVersions[index] = value;
        }
    }

    public AspApiVersion DefaultVersion
    {
        get
        {
            return _aspApiVersions[0];
        }
    }

    public int Count
    {
        get
        {
            return _aspApiVersions.Count;
        }
    }

    public bool IsReadOnly
    {
        get
        {
            return false;
        }
    }

    public void Add(AspApiVersion item)
    {
        _aspApiVersions.Add(item);
    }

    public void Clear()
    {
        _aspApiVersions.Clear();
    }

    public bool Contains(AspApiVersion item)
    {
        return _aspApiVersions.Contains(item);
    }

    public void CopyTo(AspApiVersion[] array, int arrayIndex)
    {
        _aspApiVersions.CopyTo(array, arrayIndex);
    }

    public IEnumerator<AspApiVersion> GetEnumerator()
    {
        return _aspApiVersions.GetEnumerator();
    }

    public int IndexOf(AspApiVersion item)
    {
        return _aspApiVersions.IndexOf(item);
    }

    public void Insert(int index, AspApiVersion item)
    {
        _aspApiVersions.Insert(index, item);
    }

    public bool Remove(AspApiVersion item)
    {
        return _aspApiVersions.Remove(item);
    }

    public void RemoveAt(int index)
    {
        _aspApiVersions.RemoveAt(index);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}