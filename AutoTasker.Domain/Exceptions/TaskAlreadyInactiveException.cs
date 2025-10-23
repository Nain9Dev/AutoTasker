using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTasker.Domain.Exceptions
{
    public class TaskAlreadyInactiveException : InvalidOperationException
    {
        public TaskAlreadyInactiveException(Guid taskId)
            : base($"The task with ID '{taskId}' is already inactive.")
        {
        }
    }
}
