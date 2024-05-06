using Mediatero.Data.Queries;
using Mediatero.Models;
using Mediatero.Services;
using MediatR;

namespace Mediatero.Data.Handlers
{
    public class GetEmpolyeeHandlers : IRequestHandler<GetEmployeeByIdQuery, Empolyee>
    {
        private readonly IEmployeeReposirory employeeReposirory;
        public GetEmpolyeeHandlers(IEmployeeReposirory employeeReposirory)
        {
            this.employeeReposirory = employeeReposirory;
        }
        public async Task<Empolyee> Handle(GetEmployeeByIdQuery request, CancellationToken cancel)
        {


            return await employeeReposirory.GetEmpolyeeByIdAsync(request.Id);
        }
    }
}
