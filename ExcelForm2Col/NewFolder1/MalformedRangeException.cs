using System;
using System.Runtime.Serialization;

namespace ExcelForm2Col
{
    [Serializable]
    public class MalformedRangeException : Exception
    {
        public MalformedRangeException()
        {
        }

        public MalformedRangeException(string message) : base(message)
        {
        }

        public MalformedRangeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MalformedRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}