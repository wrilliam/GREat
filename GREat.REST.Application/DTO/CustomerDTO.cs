using System;

namespace GREat.REST.Application.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime Birthdate { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}