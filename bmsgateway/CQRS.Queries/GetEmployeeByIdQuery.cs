using bmsgateway.models;
using MediatR;

namespace bmsgateway.cqrs.queries
{

    public class GetEmployeeByIdQuery : IRequest<Employee>
    {

        public int Id { get; set; }

    }

}