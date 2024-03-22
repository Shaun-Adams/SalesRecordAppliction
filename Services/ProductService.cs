using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using SalesApp.Models;
using System.Collections.Generic;

namespace SalesApp.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<Product>>("products");
            return result ?? Enumerable.Empty<Product>();
        }

        public async Task<IEnumerable<ProductSale>> GetProductSalesByProductIdAsync(int productId)
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<ProductSale>>($"product-sales?Id={productId}");
            return result ?? Enumerable.Empty<ProductSale>();
        }
    }
}
