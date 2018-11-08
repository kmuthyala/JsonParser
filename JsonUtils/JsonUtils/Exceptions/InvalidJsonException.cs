using System;

namespace JsonUtils.Parser.Exceptions
{
  public class InvalidJsonException : Exception
  {
    public InvalidJsonException(short line) : base("Invalid Json at line " + line)
    {
      
    }
  }
}
