using bmsgateway.cqrs.commands;
using bmsgateway.models;
using bmsgateway.repository;
using MediatR;

namespace bmsgateway.cqrs.commandhandlers
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        private IEmployeeRepository _empRepository;
        public DeleteEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            this._empRepository = employeeRepository;
        }

        public async Task<bool> Handle(DeleteEmployeeCommand command, CancellationToken cancellationToken)
        {
            var employee = await _empRepository.GetEmployeeAsync(command.Id);
            if (employee == null)
            {
                return await Task.FromResult(false);
            }

            return await _empRepository.DeleteEmployeeAsync(employee.Id);
        }
    }
}
