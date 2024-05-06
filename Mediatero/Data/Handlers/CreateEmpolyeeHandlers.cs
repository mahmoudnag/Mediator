using Mediatero.Data.Comman;
using Mediatero.Models;
using Mediatero.Services;
using MediatR;

namespace Mediatero.Data.Handlers
{
    public class CreateEmpolyeeHandlers : IRequestHandler<CreateEmpolyeeCommand, Empolyee>
    {
        private readonly IEmployeeReposirory employeeReposirory;
        public CreateEmpolyeeHandlers(IEmployeeReposirory employeeReposirory)
        {
            this.employeeReposirory = employeeReposirory;
        }
        public async Task<Empolyee> Handle(CreateEmpolyeeCommand request, CancellationToken cancel)
        {
            Empolyee employee = new Empolyee()
            {
                Name = request.Name,
                Age = request.Age,
            };


            return await employeeReposirory.AddEmpolyeeByIdAsync(employee);
        }
    }
}
