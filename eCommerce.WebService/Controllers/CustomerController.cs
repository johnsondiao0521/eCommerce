using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eCommerce.ApplicationLayer.Customers;
using eCommerce.WebService.Models;

namespace eCommerce.WebService.Controllers
{
    /*
     * http://localhost:63223/api/customer/add?FirstName=john2&LastName=smith2&Email=john2.smith2@microsoft.com
         */
    public class CustomerController : ApiController
    {
        readonly ICustomerService customerService;
        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public Response<CustomerDto> Add([FromUri]CustomerDto customer)
        {
            Response<CustomerDto> response = new Response<CustomerDto>();
            try
            {
                response.Object = this.customerService.Add(customer);
            }
            catch (Exception ex)
            {
                response.Errored = true;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public Response<bool> IsEmailAvailable(string email)
        {
            Response<bool> response = new Response<bool>();
            try
            {
                response.Object = this.customerService.IsEmailAvailable(email);
            }
            catch (Exception ex)
            {
                response.Errored = true;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        [HttpGet]
        public Response<CustomerDto> GetById(Guid id)
        {
            Response<CustomerDto> response = new Response<CustomerDto>();
            try
            {
                response.Object = this.customerService.Get(id);
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
        public Response RemoveById(Guid id)
        {
            Response response = new Response();
            try
            {
                this.customerService.Remove(id);
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
        public Response Update([FromUri]CustomerDto customer)
        {
            Response response = new Response();
            try
            {
                this.customerService.Update(customer);
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
