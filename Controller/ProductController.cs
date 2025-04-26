
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductController : Controller
{
    private IProductRepository productRepository;
    public ProductController(IProductRepository productRepository)
    {
        this.productRepository= productRepository;
    }

    [HttpGet("GetUserById")]
    public IActionResult GetUserById(int UserID)
    {
        return new JsonResult(productRepository.GetUserByID(UserID));
    }

}