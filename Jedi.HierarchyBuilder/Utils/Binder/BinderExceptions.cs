using System;
using System.Runtime.Serialization;

namespace Jedi.HierarchyBuilder.Utils.Binder
{
    public class BinderAlreadyInUseException : Exception
    {
        public BinderAlreadyInUseException()
        {
        }

        public BinderAlreadyInUseException(string message) : base(message)
        {
        }

        public BinderAlreadyInUseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BinderAlreadyInUseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    public class BinderNotAssignedException : Exception
    {
        public BinderNotAssignedException()
        {
        }

        public BinderNotAssignedException(string message) : base(message)
        {
        }

        public BinderNotAssignedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BinderNotAssignedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    public class BinderNotSupportSetters : Exception
    {
        public BinderNotSupportSetters()
        {
        }

        public BinderNotSupportSetters(string message) : base(message)
        {
        }

        public BinderNotSupportSetters(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BinderNotSupportSetters(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}