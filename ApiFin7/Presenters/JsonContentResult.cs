using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Presenters
{
    public class JsonContentResult : ContentResult
    {
        public JsonContentResult() => this.ContentType = "application/json";
    }
}
