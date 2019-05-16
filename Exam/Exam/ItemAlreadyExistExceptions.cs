using System;
using System.Runtime.Serialization;

namespace Exam
{
    [Serializable]
    internal class ItemAlreadyExistExceptions : Exception
    {
        public ItemAlreadyExistExceptions()
        {
        }

        public ItemAlreadyExistExceptions(string message) : base(message)
        {
        }

        public ItemAlreadyExistExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ItemAlreadyExistExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}