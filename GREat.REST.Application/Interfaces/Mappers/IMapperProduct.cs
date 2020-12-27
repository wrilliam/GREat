using GREat.REST.Application.DTO;
using GREat.REST.Domain.Entities;
using System.Collections.Generic;

namespace GREat.REST.Application.Interfaces.Mappers
{
    public interface IMapperProduct
    {
        Product MapDTOToEntity(ProductDTO productDTO);

        IEnumerable<ProductDTO> MapListProductsDTO(IEnumerable<Product> products);

        ProductDTO MapEntityToDTO(Product product);
    }
}