using ReviewSite_Utility;
using ReviewSite_Web.Models;
using ReviewSite_Web.Models.DTO;
using ReviewSite_Web.Services.IServices;

namespace ReviewSite_Web.Services
{
    public class ProductReviewService : BaseService, IProductReviewService    {
        private readonly IHttpClientFactory _clientFactory;
        private string productUrl;
        public ProductReviewService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            productUrl = configuration.GetValue<string>("ServiceUrls:ReviewSiteAPI");
        }

        public Task<T> CreateAsync<T>(ProductReviewCreateDTO dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = dto,
                Url = productUrl + "/api/ProductReviewAPI"
            });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = productUrl + "/api/ProductReviewAPI/" + id
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = productUrl + "/api/ProductReviewAPI"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = productUrl + "/api/ProductReviewAPI/" + id
            });
        }

        public Task<T> UpdateAsync<T>(ProductReviewUpdateDTO dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = dto,
                Url = productUrl + "/api/ProductReviewAPI/" + dto.Id
            });
        }
    }
}
