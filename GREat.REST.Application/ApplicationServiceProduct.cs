using GREat.REST.Application.DTO;
using GREat.REST.Application.Interfaces;
using GREat.REST.Application.Interfaces.Mappers;
using GREat.REST.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace GREat.REST.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct serviceProduct;
        private readonly IMapperProduct mapperProduct;

        public ApplicationServiceProduct(IServiceProduct serviceProduct, IMapperProduct mapperProduct)
        {
            this.serviceProduct = serviceProduct;
            this.mapperProduct = mapperProduct;
        }

        public void Add(ProductDTO productDTO)
        {
            var product = mapperProduct.MapDTOToEntity(productDTO);
            serviceProduct.Add(product);
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            var products = serviceProduct.GetAll();
            return mapperProduct.MapListProductsDTO(products);
        }

        public ProductDTO GetById(int id)
        {
            var product = serviceProduct.GetById(id);
            return mapperProduct.MapEntityToDTO(product);
        }

        public void Remove(ProductDTO productDTO)
        {
            var product = mapperProduct.MapDTOToEntity(productDTO);
            serviceProduct.Remove(product);
        }

        public void Update(ProductDTO productDTO)
        {
            var product = mapperProduct.MapDTOToEntity(productDTO);
            serviceProduct.Update(product);
        }
    }
}