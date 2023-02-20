using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Api.Core.Interfaces
{
    public class UseCaseResponseMessage
    {
        public bool Success { get; }

        public string Message { get; }

        protected UseCaseResponseMessage(bool success = false, string message = null)
        {
            this.Success = success;
            this.Message = message;
        }
    }
}
