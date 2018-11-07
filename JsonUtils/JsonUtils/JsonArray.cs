using System.Collections;
using System.Collections.Generic;

namespace JsonUtils.Parser
{
  public class JsonArray : JsonResult, IEnumerable
  {
    private List<JsonResult> _objects;

    public JsonArray()
    {
      _objects = new List<JsonResult>();
    }
    public IEnumerator GetEnumerator()
    {
      foreach (var obj in _objects)
      {
        yield return obj;
      }
    }
    public void Add(JsonResult item)
    {
      _objects.Add(item);
    }
  }
}
