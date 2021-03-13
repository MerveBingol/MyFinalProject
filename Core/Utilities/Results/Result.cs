using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // this = class ın kendisi demek yani Result

        public Result(bool success, string message):this(success)
        {
            Message = message;// getter ReadOnly dir ve bunlar Constructor da set edilebilirler.
          
        }
        public Result(bool success)
        {
           
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
