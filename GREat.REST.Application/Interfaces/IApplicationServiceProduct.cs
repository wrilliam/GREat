using GREat.REST.Application.DTO;
using System.Collections.Generic;

namespace GREat.REST.Application.Interfaces
{
    public interface IApplicationServiceProduct
    {
        void Add(ProductDTO productDTO);

        void Update(ProductDTO productDTO);

        void Remove(ProductDTO productDTO);

        IEnumerable<ProductDTO> GetAll();

        ProductDTO GetById(int id);
    }
}