using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, ResultType resultType, string message = "")
            : base(resultType, message)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
