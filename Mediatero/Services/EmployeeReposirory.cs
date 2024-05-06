using Mediatero.Connections;
using Mediatero.Models;
using Microsoft.EntityFrameworkCore;

namespace Mediatero.Services
{
    public class EmployeeReposirory : IEmployeeReposirory
    {
        public readonly ApplContext applContext;
        public EmployeeReposirory(ApplContext _applContext ) {
        applContext = _applContext;
        }




        public Task<List<Empolyee>> GetEmployeeReposiroryAsync()
        {
           var result= applContext.Empolyee.ToListAsync();
            return result;
        }

        public async Task<Empolyee> AddEmpolyeeByIdAsync(Empolyee empolyee)
        {
            var result = applContext.Empolyee.Add(empolyee);
            await applContext.SaveChangesAsync();
            return result.Entity;
            
        }

        public async Task<int> DeleteEmployeeAsync(int id)
        {
            var filterdata = applContext.Empolyee.Where(c => c.Id == id).FirstOrDefault();
            applContext.Empolyee.Remove(filterdata);
            return await   applContext.SaveChangesAsync();
          
        }

       
        public Task<Empolyee> GetEmpolyeeByIdAsync(int id)
        {
           var filterdata=applContext.Empolyee.Where(c=>c.Id==id).FirstOrDefaultAsync();
            return filterdata;
        }

        public async Task<int> UpdateEmployeeAsync(Empolyee empolyee)
        {
           applContext.Empolyee.Update(empolyee);
            return await applContext.SaveChangesAsync();
        }
    }
}
