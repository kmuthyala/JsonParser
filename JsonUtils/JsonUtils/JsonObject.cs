using System.Collections;
using System.Collections.Generic;

namespace JsonUtils.Parser
{
  public class JsonObject : JsonResult, IEnumerable
  {
    private Dictionary<string, JsonResult> _objects;
    
    public JsonObject()
    {
      _objects = new Dictionary<string, JsonResult>();
    }

    public JsonResult this[string key] => _objects[key];

    public bool ContainsKey(string key)
    {
      return _objects.ContainsKey(key);
    }
    public IEnumerator GetEnumerator()
    {
      foreach (var obj in _objects)
      {
        yield return obj;
      }
    }

    public void Add(string key, JsonResult objValue)
    {
      _objects.Add(key, objValue);
    }
  }
}
