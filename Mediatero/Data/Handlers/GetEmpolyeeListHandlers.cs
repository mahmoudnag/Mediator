using Mediatero.Data.Queries;
using Mediatero.Models;
using Mediatero.Services;
using MediatR;

namespace Mediatero.Data.Handlers
{
    public class GetEmpolyeeListHandlers : IRequestHandler<GetEmployeeListQuery, List<Empolyee>>
    {
        private readonly IEmployeeReposirory employeeReposirory;
        public GetEmpolyeeListHandlers(IEmployeeReposirory employeeReposirory)
        {
            this.employeeReposirory = employeeReposirory;
        }   
        public  async Task <List<Empolyee>> Handle(GetEmployeeListQuery request,CancellationToken cancel)
        {


            return await employeeReposirory.GetEmployeeReposiroryAsync();
        }
    }
}
