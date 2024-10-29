using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Results
{
    public static class DataResultFactory
    {
        public static DataResult<T> Success<T>(T data, string message = "")
        {
            return new DataResult<T>(data, ResultType.Success, message);
        }

        public static DataResult<T> Error<T>(string message = "")
        {
            return new DataResult<T>(default, ResultType.Error, message);
        }
    }
}
