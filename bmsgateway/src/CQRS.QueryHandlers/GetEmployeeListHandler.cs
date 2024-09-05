using bmsgateway.cqrs.queries;
using bmsgateway.models;
using bmsgateway.repository;
using MediatR;

namespace bmsgateway.cqrs.QueryHandlers
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<Employee>>
    {
        private readonly IEmployeeRepository _empRepository;
        public GetEmployeeListHandler(IEmployeeRepository employeeRepository)
        {
            _empRepository = employeeRepository;
        }
        public async Task<List<Employee>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return await _empRepository.GetEmployeeListAsync();
        }

    }

}

