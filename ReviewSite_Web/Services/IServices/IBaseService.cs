﻿using ReviewSite_Web.Models;

namespace ReviewSite_Web.Services.IServices
{
    public interface IBaseService
    {
        APIResponse responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
        
    }
}
