using Mediatero.Data.Comman;
using Mediatero.Services;
using MediatR;

namespace Mediatero.Data.Handlers
{
    public class UpdateEmpolyeeHandlers : IRequestHandler<UpdateEmpolyeeCommand, int>
    {
        private readonly IEmployeeReposirory employeeReposirory;
        public UpdateEmpolyeeHandlers(IEmployeeReposirory employeeReposirory)
        {
            this.employeeReposirory = employeeReposirory;
        }
        public async Task<int> Handle(UpdateEmpolyeeCommand request, CancellationToken cancel)
        {
            var employee = await employeeReposirory.GetEmpolyeeByIdAsync(request.Id);
            if (employee == null) { return default; }
            employee.Name = request.Name;
            employee.Age = request.Age;
            return await employeeReposirory.UpdateEmployeeAsync(employee);


        }



    }
}
