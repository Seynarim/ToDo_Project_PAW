using Microsoft.EntityFrameworkCore;

namespace ToDo_Project_PAW.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<TaskModel> Tasks { get; set; }
    }
}
