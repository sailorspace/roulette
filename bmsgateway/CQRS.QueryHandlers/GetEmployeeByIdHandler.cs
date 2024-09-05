using bmsgateway.cqrs.queries;
using bmsgateway.models;
using bmsgateway.repository;
using MediatR;

namespace bmsgateway.cqrs.QueryHandlers
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly IEmployeeRepository _empRepository;
        public GetEmployeeByIdHandler(IEmployeeRepository employeeRepository)
        {
            this._empRepository = employeeRepository;
        }
        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _empRepository.GetEmployeeAsync(request.Id);
        }
    }
}