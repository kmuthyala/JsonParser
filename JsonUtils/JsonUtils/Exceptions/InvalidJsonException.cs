using System;

namespace JsonUtils.Parser.Exceptions
{
  public class InvalidJsonException : Exception
  {
    public InvalidJsonException(int line) : base(line.ToString())
    {

    }
  }
}
