using Mediatero.Models;

namespace Mediatero.Services
{
    public interface IEmployeeReposirory
    {
        public Task<List<Empolyee>> GetEmployeeReposiroryAsync();
        public Task<Empolyee> GetEmpolyeeByIdAsync(int id);
        public Task<Empolyee> AddEmpolyeeByIdAsync(Empolyee empolyee);


        public Task<int> UpdateEmployeeAsync(Empolyee empolyee);
        public Task<int> DeleteEmployeeAsync(int id);
    }
}
