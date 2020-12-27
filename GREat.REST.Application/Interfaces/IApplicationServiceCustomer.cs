using GREat.REST.Application.DTO;
using System.Collections.Generic;

namespace GREat.REST.Application.Interfaces
{
    public interface IApplicationServiceCustomer
    {
        void Add(CustomerDTO customerDTO);

        void Update(CustomerDTO customerDTO);

        void Remove(CustomerDTO customerDTO);

        IEnumerable<CustomerDTO> GetAll();

        CustomerDTO GetById(int id);
    }
}