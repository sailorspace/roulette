using bmsgateway.models;
using MediatR;

namespace bmsgateway.cqrs.commands
{
    public class DeleteEmployeeCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }

}