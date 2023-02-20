using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Api.Core.Dto
{
    public class Error
    {
        public string Code { get; }

        public string Description { get; }

        public Error(string code, string description)
        {
            this.Code = code;
            this.Description = description;
        }
    }
}
