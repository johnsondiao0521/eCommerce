using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerce.WebService.Models
{
    public class Response<T> : Response
    {
        public T Data { get; set; }
    }
}