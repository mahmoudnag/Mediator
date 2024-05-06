using Mediatero.Data;
using Mediatero.Data.Comman;

using Mediatero.Data.Queries;
using Mediatero.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mediatero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IMediator mediator;
        public EmployeesController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<List<Empolyee>> EmplyeeList()
        {
            var emplyees = await mediator.Send(new GetEmployeeListQuery());
            return emplyees;
        }
        [HttpGet("{id}")]
        public async Task<Empolyee> Employee(int id)
        {
            var emplyee = await mediator.Send(new GetEmployeeByIdQuery() { Id = id });
            return emplyee;
        }
        [HttpPost]
        public async Task<Empolyee> Add(Empolyee employee)
        {
            var returnemplyee = await mediator.Send(new CreateEmpolyeeCommand(

                employee.Name,
                employee.Age

                )

               );
            return returnemplyee;
        }
        [HttpPut]
        public async Task<int> Update(Empolyee employee)
        {
            var returnemplyee = await mediator.Send(new UpdateEmpolyeeCommand(
                employee.Id,

                employee.Name,
                employee.Age

                )

               );
            return returnemplyee;
        }
        [HttpDelete("{id}")]
        public async Task<int> delete(int id)
        {
            var emplyee = await mediator.Send(new DeleteEmpolyeeCommand() { Id = id });
            return emplyee;
        }
    }
}
