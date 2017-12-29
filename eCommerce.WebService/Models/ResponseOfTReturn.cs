
namespace eCommerce.WebService.Models
{
    public class Response<TReturn> : Response
    {
        public TReturn Object { get; set; }
    }
}