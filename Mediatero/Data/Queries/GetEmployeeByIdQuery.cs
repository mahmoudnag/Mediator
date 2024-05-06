using Mediatero.Models;
using MediatR;

namespace Mediatero.Data.Queries
{
    public class GetEmployeeByIdQuery:IRequest<Empolyee>
    {
        public int Id { get; set; }
    }
}
