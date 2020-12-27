using GREat.REST.Application.DTO;
using GREat.REST.Application.Interfaces.Mappers;
using GREat.REST.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GREat.REST.Application.Mappers
{
    public class MapperCustomer : IMapperCustomer
    {
        public Customer MapDTOToEntity(CustomerDTO customerDTO)
        {
            var customer = new Customer()
            {
                Id = customerDTO.Id,
                Name = customerDTO.Name,
                Cpf = customerDTO.Cpf,
                Rg = customerDTO.Rg,
                Birthdate = customerDTO.Birthdate,
                MotherName = customerDTO.MotherName,
                FatherName = customerDTO.FatherName,
                RegistrationDate = customerDTO.RegistrationDate
            };

            return customer;
        }

        public CustomerDTO MapEntityToDTO(Customer customer)
        {
            var customerDTO = new CustomerDTO()
            {
                Id = customer.Id,
                Name = customer.Name,
                Cpf = customer.Cpf,
                Rg = customer.Rg,
                Birthdate = customer.Birthdate,
                MotherName = customer.MotherName,
                FatherName = customer.FatherName,
                RegistrationDate = customer.RegistrationDate
            };

            return customerDTO;
        }

        public IEnumerable<CustomerDTO> MapListCustomersDTO(IEnumerable<Customer> customers)
        {
            var dto = customers.Select(c => new CustomerDTO()
            {
                Id = c.Id,
                Name = c.Name,
                Cpf = c.Cpf,
                Rg = c.Rg,
                Birthdate = c.Birthdate,
                MotherName = c.MotherName,
                FatherName = c.FatherName,
                RegistrationDate = c.RegistrationDate
            });

            return dto;
        }
    }
}