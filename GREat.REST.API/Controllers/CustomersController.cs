using GREat.REST.Application.DTO;
using GREat.REST.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GREat.REST.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IApplicationServiceCustomer _applicationServiceCustomer;

        public CustomersController(IApplicationServiceCustomer applicationServiceCustomer)
        {
            this._applicationServiceCustomer = applicationServiceCustomer;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceCustomer.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceCustomer.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] CustomerDTO customerDTO)
        {
            try
            {
                if (customerDTO == null)
                    return NotFound();

                _applicationServiceCustomer.Add(customerDTO);
                return Ok("Customer registered successfully.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] CustomerDTO customerDTO)
        {
            try
            {
                if (customerDTO == null)
                    return NotFound();

                _applicationServiceCustomer.Update(customerDTO);
                return Ok("Customer updated successfully.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] CustomerDTO customerDTO)
        {
            try
            {
                if (customerDTO == null)
                    return NotFound();

                _applicationServiceCustomer.Remove(customerDTO);
                return Ok("Customer deleted successfully.");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}