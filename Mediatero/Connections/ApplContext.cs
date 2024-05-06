using Mediatero.Models;
using Microsoft.EntityFrameworkCore;

namespace Mediatero.Connections
{
    public class ApplContext:DbContext
    {


        public ApplContext(DbContextOptions<ApplContext> options ):base(options) { }
        public virtual DbSet<Empolyee> Empolyee { get; set;}
    }
}
