using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Results
{
    public class Result : IResult
    {
        public Result(ResultType resultType, string message = "")
        {
            Success = resultType == ResultType.Success;
            Message = message;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
