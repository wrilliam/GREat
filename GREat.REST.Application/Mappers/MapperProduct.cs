using GREat.REST.Application.DTO;
using GREat.REST.Application.Interfaces.Mappers;
using GREat.REST.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GREat.REST.Application.Mappers
{
    public class MapperProduct : IMapperProduct
    {
        public Product MapDTOToEntity(ProductDTO productDTO)
        {
            var product = new Product()
            {
                Id = productDTO.Id,
                Name = productDTO.Name,
                Price = productDTO.Price
            };

            return product;
        }

        public ProductDTO MapEntityToDTO(Product product)
        {
            var productDTO = new ProductDTO()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };

            return productDTO;
        }

        public IEnumerable<ProductDTO> MapListProductsDTO(IEnumerable<Product> products)
        {
            var dto = products.Select(c => new ProductDTO()
            {
                Id = c.Id,
                Name = c.Name,
                Price = c.Price
            });

            return dto;
        }
    }
}