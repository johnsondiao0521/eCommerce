using System;
using System.Web.Http;
using eCommerce.ApplicationLayer;
using eCommerce.ApplicationLayer.Products;
using eCommerce.WebService.Models;

namespace eCommerce.WebService.Controllers
{
    /*
     http://localhost:63223/api/product/add?name=iPhone5&quantity=6&cost=422&productcodeid=B2773EBF-CD0C-4F31-83E2-691973E32531
     http://localhost:63223/api/product/get/65D03D7E-E41A-49BC-8680-DC942BABD10A
     */
    public class ProductController : ApiController
    {
        readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public Response<ProductDto> Add([FromUri]ProductDto productDto)
        {
            Response<ProductDto> response = new Response<ProductDto>();
            try
            {
                response.Object = this.productService.Add(productDto);
            }
            catch (Exception ex)
            {
                //log error
                response.Errored = true;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        [HttpGet]
        public Response<ProductDto> Get(Guid id)
        {
            Response<ProductDto> response = new Response<ProductDto>();
            try
            {
                response.Object = this.productService.Get(id);
            }
            catch (Exception ex)
            {
                //log error
                response.Errored = true;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
    }
}
