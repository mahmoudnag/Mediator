using MediatR;

namespace Mediatero.Data.Comman
{
    public class DeleteEmpolyeeCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
