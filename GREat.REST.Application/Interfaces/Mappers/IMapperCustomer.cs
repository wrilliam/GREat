using GREat.REST.Application.DTO;
using GREat.REST.Domain.Entities;
using System.Collections.Generic;

namespace GREat.REST.Application.Interfaces.Mappers
{
    public interface IMapperCustomer
    {
        Customer MapDTOToEntity(CustomerDTO customerDTO);

        IEnumerable<CustomerDTO> MapListCustomersDTO(IEnumerable<Customer> customers);

        CustomerDTO MapEntityToDTO(Customer customer);
    }
}