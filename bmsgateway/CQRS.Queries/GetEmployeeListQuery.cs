using bmsgateway.models;
using MediatR;

namespace bmsgateway.cqrs.queries
{

    public class GetEmployeeListQuery : IRequest<List<Employee>>
    {


    }

}