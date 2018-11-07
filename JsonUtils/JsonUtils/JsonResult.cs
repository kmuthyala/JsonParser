using System.Collections.Generic;

namespace JsonUtils.Parser
{
  public class JsonResult
  {
    public JsonObjectType Type { get; set; }
    public List<short> DuplicatesAt { get; set; }
    public int IsAtLine { get; set; }
    public string Key { get; set; }
    public object Value { get; set; }
    public JsonResult()
    {
      DuplicatesAt = new List<short>();
    }
  }
}
