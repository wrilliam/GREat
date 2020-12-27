using GREat.REST.Application.DTO;
using GREat.REST.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GREat.REST.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IApplicationServiceProduct _applicationServiceProduct;

        public ProductsController(IApplicationServiceProduct applicationServiceProduct)
        {
            this._applicationServiceProduct = applicationServiceProduct;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceProduct.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceProduct.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProductDTO productDTO)
        {
            try
            {
                if (productDTO == null)
                    return NotFound();

                _applicationServiceProduct.Add(productDTO);
                return Ok("Product registered successfully.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProductDTO productDTO)
        {
            try
            {
                if (productDTO == null)
                    return NotFound();

                _applicationServiceProduct.Update(productDTO);
                return Ok("Product updated successfully.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ProductDTO productDTO)
        {
            try
            {
                if (productDTO == null)
                    return NotFound();

                _applicationServiceProduct.Remove(productDTO);
                return Ok("Product deleted successfully.");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}