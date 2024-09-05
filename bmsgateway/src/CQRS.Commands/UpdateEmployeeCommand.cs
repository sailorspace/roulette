using bmsgateway.models;
using MediatR;

namespace bmsgateway.cqrs.commands
{

    public class UpdateEmployeeCommand : IRequest<Employee>
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public UpdateEmployeeCommand(int pid,string pName, string pEmail, string pAddress, DateTime pDob)
        {
            this.Id=pid;
            this.Name = pName;
            this.Address = pAddress;
            this.Email = pEmail;
            this.DateOfBirth = pDob;

        }

    }
}