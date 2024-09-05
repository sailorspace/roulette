using bmsgateway.cqrs.commands;
using bmsgateway.models;
using bmsgateway.repository;
using MediatR;

namespace bmsgateway.cqrs.commandhandlers
{

    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepository _empRepository;
        public CreateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            this._empRepository = employeeRepository;
        }
        public async Task<Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee()
            {
                Id = request.Id,
                Email = request.Email,
                Address = request.Address,
                Name = request.Name,
                DateOfBirth = request.DateOfBirth
            };
            return await _empRepository.CreateEmployeeAsync(employee);
            
        }
    }

}