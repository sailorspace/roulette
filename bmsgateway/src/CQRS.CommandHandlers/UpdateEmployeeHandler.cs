using bmsgateway.cqrs.commands;
using bmsgateway.models;
using bmsgateway.repository;
using MediatR;

namespace bmsgateway.cqrs.commandhandlers
{
    public class UpdateEmployeehandler : IRequestHandler<UpdateEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepository _empRepository;
        public UpdateEmployeehandler(IEmployeeRepository employeeRepository)
        {
            this._empRepository = employeeRepository;
        }

        public async Task<Employee> Handle(UpdateEmployeeCommand command, CancellationToken cancellationToken)
        {
            var employee = await _empRepository.GetEmployeeAsync(command.Id);
            if (employee == null)
            {
                return await Task.FromResult<Employee>(new Employee() { Name = "", Email = "" });
            }
            employee.Name = command.Name;
            employee.Address = command.Address;
            employee.Email = command.Email;
            employee.DateOfBirth = command.DateOfBirth;
            return await _empRepository.UpdateEmployeeAsync(employee);

        }
    }
}