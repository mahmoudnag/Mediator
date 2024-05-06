using Mediatero.Models;
using MediatR;

namespace Mediatero.Data.Comman
{
    public class CreateEmpolyeeCommand : IRequest<Empolyee>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public CreateEmpolyeeCommand(string name, int age)
        {
            Name = name;
            Age = age;
        }


    }
}
