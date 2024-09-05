using bmsgateway.models;
using MediatR;

namespace bmsgateway.cqrs.commands
{

    public class CreateEmployeeCommand : IRequest<Employee>
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public CreateEmployeeCommand(int pId, string pName, string pEmail, string pAddress, DateTime pDob)
        {
            this.Id = pId;
            this.Name = pName;
            this.Address = pAddress;
            this.Email = pEmail;
            this.DateOfBirth = pDob;

        }

    }
}