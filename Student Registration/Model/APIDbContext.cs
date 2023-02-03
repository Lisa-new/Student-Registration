using Microsoft.EntityFrameworkCore;

namespace Student_Registration.Model
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions option): base (option)
        {

        }
        public DbSet <Student> Students { get; set; }
    }
}
