using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eCommerce.Application.Customers;
using eCommerce.WebService.Models;

namespace eCommerce.WebService.Controllers
{
    public class CustomerController : ApiController
    {
        readonly ICustomerService customerService;
        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        /// <summary>
        /// http://localhost:58209/api/customer/add?FirstName=john2&LastName=smith2&Email=john2.smith2@microsoft.com&countryid=229074bd-2356-4b5a-8619-cdebba71cc21
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpGet]
        public Response<CustomerDto> Add([FromUri]CustomerDto customer)
        {
            Response<CustomerDto> response = new Response<CustomerDto>();
            try
            {
                response.Data = this.customerService.Add(customer);
            }
            catch (Exception ex)
            {
                response.Errored = true;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        /// <summary>
        /// http://localhost:58209/api/customer/IsEmailAvailable?email=smith.john@microsoft.com
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        [HttpGet]
        public Response<bool> IsEmailAvailable(string email)
        {
            Response<bool> response = new Response<bool>();
            try
            {
                response.Data = this.customerService.IsEmailAvailable(email);
            }
            catch (Exception ex)
            {
                response.Errored = true;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        /// <summary>
        /// http://localhost:58209/api/customer/Getbyid/5D5020DA-47DF-4C82-A722-C8DEAF06AE23
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public Response<CustomerDto> GetById(Guid id)
        {
            Response<CustomerDto> response = new Response<CustomerDto>();
            try
            {
                response.Data = this.customerService.Get(id);
            }
            catch (Exception ex)
            {
                //log error
                response.Errored = true;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        /// <summary>
        /// http://localhost:58209/api/customer/RemoveById/5D5020DA-47DF-4C82-A722-C8DEAF06AE23
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// http://localhost:58209/api/customer/update?id=5D5020DA-47DF-4C82-A722-C8DEAF06AE23&Email=smith.john@microsoft.com
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
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
