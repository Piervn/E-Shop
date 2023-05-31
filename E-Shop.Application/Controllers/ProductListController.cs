using E_Shop.Domain.Entities;
using E_Shop.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
                Id = Guid.NewGuid(),
                Name = "Pro mouse",
                Description = "Description 1",
                Specification = "Specification 1",
                Category = "Category 1",
                Price = 123,
                Review = 1,
                Quantity = 1,
                Image = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-medium,,2020/4/pr_2020_4_27_11_53_35_124_00.jpg"
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Mouse 2",
                Description = "Description 2",
                Specification = "Specification 2",
                Category = "Category 2",
                Price = 123,
                Review = 2,
                Quantity = 2,
                Image = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-medium,,2022/11/pr_2022_11_24_15_53_35_788_04.jpg"
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Mouse",
                Description = "Description",
                Specification = "Specification",
                Category = "Category",
                Price = 123,
                Review = 1,
                Quantity = 1,
                Image = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-medium,,2022/11/pr_2022_11_24_15_53_35_788_04.jpg"
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Mouse",
                Description = "Description",
                Specification = "Specification",
                Category = "Category",
                Price = 123,
                Review = 1,
                Quantity = 1,
                Image = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-medium,,2022/11/pr_2022_11_24_15_53_35_788_04.jpg"
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Mouse",
                Description = "Description",
                Specification = "Specification",
                Category = "Category",
                Price = 123,
                Review = 1,
                Quantity = 1,
                Image = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-medium,,2022/11/pr_2022_11_24_15_53_35_788_04.jpg"
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Mouse",
                Description = "Description",
                Specification = "Specification",
                Category = "Category",
                Price = 123,
                Review = 1,
                Quantity = 1,
                Image = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-medium,,2022/11/pr_2022_11_24_15_53_35_788_04.jpg"
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Mouse",
                Description = "Description",
                Specification = "Specification",
                Category = "Category",
                Price = 123,
                Review = 1,
                Quantity = 1,
                Image = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-medium,,2022/11/pr_2022_11_24_15_53_35_788_04.jpg"
            },
        };

        private readonly E_ShopDbContext _eshopDbContext;

        public ProductListController(E_ShopDbContext eshopDbContext)
        {
            _eshopDbContext = eshopDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _eshopDbContext.Product.ToListAsync());
            //return products;
        }
    }
}
