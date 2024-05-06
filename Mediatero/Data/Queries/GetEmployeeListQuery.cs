using Mediatero.Models;
using MediatR;

namespace Mediatero.Data.Queries
{
    public class GetEmployeeListQuery: IRequest<List<Empolyee>>
    {
    }
}
