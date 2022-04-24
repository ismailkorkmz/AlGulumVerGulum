using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Constant
{
    public class EntityResult
    {
        public object Message { get; set; }
        public EntityResultType ResultType { get; set; }
        public EntityResult(object message,EntityResultType resultType=EntityResultType.Success)
        {
            this.Message=message ;
            ResultType = resultType;
        }
    }
    public class EntityResult<T> : EntityResult
    {
        public T Data { get; }
        public EntityResult( T data,object message,EntityResultType resultType= EntityResultType.Success):base(message,resultType)
        {
            Data = data;
        }
    }
}
