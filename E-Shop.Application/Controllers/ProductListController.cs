using E_Shop.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace E_Shop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductListController : Controller
    {
        public Product[] products =
        {
            new Product()
            {
                Id = 1,
                Name = "Product 1",
                Description = "Description 1",
                Specification = "Specification 1",
                Category = "Category 1",
                Price = "Price 1",
                Review = 1,
                Quantity = 1,
                Image = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/9/pr_2022_9_9_9_30_25_22_03.jpg"
            },
            new Product()
            {
                Id = 2,
                Name = "Product 2",
                Description = "Description 2",
                Specification = "Specification 2",
                Category = "Category 2",
                Price = "Price 2",
                Review = 2,
                Quantity = 2,
                Image = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2022/9/pr_2022_9_9_9_30_25_22_03.jpg"
            },
        };

        private readonly ILogger<ProductListController> _logger;

        public ProductListController(ILogger<ProductListController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }
    }
}
