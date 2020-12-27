using GREat.REST.Application.DTO;
using GREat.REST.Application.Interfaces;
using GREat.REST.Application.Interfaces.Mappers;
using GREat.REST.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace GREat.REST.Application
{
    public class ApplicationServiceCustomer : IApplicationServiceCustomer
    {
        private readonly IServiceCustomer serviceCustomer;
        private readonly IMapperCustomer mapperCustomer;

        public ApplicationServiceCustomer(IServiceCustomer serviceCustomer, IMapperCustomer mapperCustomer)
        {
            this.serviceCustomer = serviceCustomer;
            this.mapperCustomer = mapperCustomer;
        }

        public void Add(CustomerDTO customerDTO)
        {
            var customer = mapperCustomer.MapDTOToEntity(customerDTO);
            serviceCustomer.Add(customer);
        }

        public IEnumerable<CustomerDTO> GetAll()
        {
            var customers = serviceCustomer.GetAll();
            return mapperCustomer.MapListCustomersDTO(customers);
        }

        public CustomerDTO GetById(int id)
        {
            var customer = serviceCustomer.GetById(id);
            return mapperCustomer.MapEntityToDTO(customer);
        }

        public void Remove(CustomerDTO customerDTO)
        {
            var customer = mapperCustomer.MapDTOToEntity(customerDTO);
            serviceCustomer.Remove(customer);
        }

        public void Update(CustomerDTO customerDTO)
        {
            var customer = mapperCustomer.MapDTOToEntity(customerDTO);
            serviceCustomer.Update(customer);
        }
    }
}