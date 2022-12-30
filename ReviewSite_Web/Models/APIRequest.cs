using Microsoft.AspNetCore.Mvc;
using static ReviewSite_Utility.SD;

namespace ReviewSite_Web.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
    }
}
