using Mediatero.Data.Comman;
using Mediatero.Services;
using MediatR;

namespace Mediatero.Data.Handlers
{
    public class DeleteEmpolyeeHandlers : IRequestHandler<DeleteEmpolyeeCommand, int>

    {

        private readonly IEmployeeReposirory employeeReposirory;
        public DeleteEmpolyeeHandlers(IEmployeeReposirory employeeReposirory)
        {
            this.employeeReposirory = employeeReposirory;
        }
        public async Task<int> Handle(DeleteEmpolyeeCommand request, CancellationToken cancel)
        {
            var employee = await employeeReposirory.GetEmpolyeeByIdAsync(request.Id);
            if (employee == null) { return default; }

            return await employeeReposirory.DeleteEmployeeAsync(request.Id);


        }

    }
}
