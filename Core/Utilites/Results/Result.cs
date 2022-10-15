using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilites.Results
{
    public class Result : IResult
    {
        public Result(bool success)
        {
            Success = success;
        }

        public Result(bool success, string Message):this(success)
        {
            Message = Message;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
